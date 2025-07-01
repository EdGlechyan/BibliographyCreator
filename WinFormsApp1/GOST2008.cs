using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

using PdfSharp.Pdf;

namespace WinFormsApp1
{
    public partial class GOST2008 : Form
    {
        private GOST2018 mainForm;

        public GOST2008(GOST2018 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            RegisterAllListBoxes(this);
        }

        private readonly UndoRedoListBoxManager _undoManager = new UndoRedoListBoxManager();

        private readonly Dictionary<TabPage, FormSnapshot> _initialSnapshots = new();

        internal enum SourceKind
        {
            // Печатные ресурсы
            PRBook,
            PRJournalArticle,
            RPCollectionArticle,

            // Электронные ресурсы
            EREBook,
            ERJournalArticle,
            ERCollectionArticle,
            ERSite,
        }

        internal sealed record SmartUi(
            Dictionary<string, List<string>> Dict,
            ListBox LbPlaces,
            ListBox LbPublishers,
            ListBox LbSelector,
            System.Windows.Forms.CheckBox CbSmartMode);

        private readonly Dictionary<SourceKind, SmartUi> _smartMap = new();

        private void GOST2008_Load(object sender, EventArgs e)
        {
            // ДОБАВЛЕНИЕ
            _undoManager.ItemAdded += (lb, item, idx) =>
            {
                if (lb != lbResult || item is not ResultItem<SavedEntry> ri)
                    return;

                // Если индекс слишком большой — добавляем в конец,
                // если отрицательный — в начало:
                if (idx < 0)
                    _entries.Insert(0, ri.Entry);
                else if (idx > _entries.Count)
                    _entries.Add(ri.Entry);
                else
                    _entries.Insert(idx, ri.Entry);

                RefreshRestoreButtons();
            };

            // УДАЛЕНИЕ
            _undoManager.ItemRemoved += (lb, item, idx) =>
            {
                if (lb == lbResult)
                {
                    // сначала удаляем из внутреннего списка
                    if (idx >= 0 && idx < _entries.Count)
                        _entries.RemoveAt(idx);

                    // затем корректируем выделение в ListBox
                    if (lbResult.Items.Count == 0)
                    {
                        lbResult.SelectedIndex = -1;
                    }
                    else if (lbResult.SelectedIndex >= lbResult.Items.Count)
                    {
                        // если удалили последний, то выбираем новый последний
                        lbResult.SelectedIndex = lbResult.Items.Count - 1;
                    }

                    RefreshRestoreButtons();
                }
            };

            // ОЧИСТКА
            _undoManager.ItemsCleared += lb =>
            {
                if (lb == lbResult)
                {
                    _entries.Clear();
                    RefreshRestoreButtons();
                }
            };


            lbPRBAuthors.Tag = cbPRBAuthors;
            lbPRJAAuthors.Tag = cbPRJAAuthors;
            lbPRCAAuthors.Tag = cbPRCAAuthors;

            lbEREbAuthors.Tag = cbEREbAuthors;
            lbERJAAuthors.Tag = cbERJAAuthors;
            lbERCAAuthors.Tag = cbERCAAuthors;
            lbERSAuthors.Tag = cbERSAuthors;


            // Привязка селекторов к основным ListBox мест издания (для UpdatePublishingLocationSelector)
            lbPRBPublishingLocation.Tag = lbPRBPublishingLocationSelect;

            lbPRCAPublishingLocation.Tag = lbPRCAPublishingLocationSelect;

            lbEREbPublishingLocation.Tag = lbEREbPublishingLocationSelect;

            lbERCAPublishingLocation.Tag = lbERCAPublishingLocationSelect;


            // Привязка издательств к своим местам издания (для GetDictionaryByListBox, drag'n'drop)
            lbPRBPublisher.Tag = lbPRBPublishingLocation;

            lbPRCAPublisher.Tag = lbPRCAPublishingLocation;

            lbEREbPublisher.Tag = lbEREbPublishingLocation;

            lbERCAPublisher.Tag = lbERCAPublishingLocation;


            // Привязка текстбоксов к своим листбоксам
            tbPRBAuthors.Tag = lbPRBAuthors;
            tbPRBPublishingLocation.Tag = lbPRBPublishingLocation;
            tbPRBPublisher.Tag = lbPRBPublisher;
            tbPRBEditor.Tag = lbPRBEditor;

            tbPRJAAuthors.Tag = lbPRJAAuthors;

            tbPRCAAuthors.Tag = lbPRCAAuthors;
            tbPRCAPublishingLocation.Tag = lbPRCAPublishingLocation;
            tbPRCAPublisher.Tag = lbPRCAPublisher;
            tbPRCAEditor.Tag = lbPRCAEditor;

            tbEREbAuthors.Tag = lbEREbAuthors;
            tbEREbPublishingLocation.Tag = lbEREbPublishingLocation;
            tbEREbPublisher.Tag = lbEREbPublisher;
            tbEREbEditor.Tag = lbEREbEditor;

            tbERJAAuthors.Tag = lbERJAAuthors;

            tbERCAAuthors.Tag = lbERCAAuthors;
            tbERCAPublishingLocation.Tag = lbERCAPublishingLocation;
            tbERCAPublisher.Tag = lbERCAPublisher;
            tbERCAEditor.Tag = lbERCAEditor;

            tbERSAuthors.Tag = lbERSAuthors;

            UpdateListCheckBox(lbPRBAuthors, 1, 4);
            UpdateListCheckBox(lbPRJAAuthors, 1, 4);
            UpdateListCheckBox(lbPRCAAuthors, 1, 4);
            UpdateListCheckBox(lbEREbAuthors, 1, 4);
            UpdateListCheckBox(lbERJAAuthors, 1, 4);
            UpdateListCheckBox(lbERCAAuthors, 1, 4);
            UpdateListCheckBox(lbERSAuthors, 1, 4);

            // ───────── печатные ─────────
            _smartMap[SourceKind.PRBook] = new SmartUi(
                groupedPublishersPRBook,
                lbPRBPublishingLocation,
                lbPRBPublisher,
                lbPRBPublishingLocationSelect,
                cbPRBPublisher);

            _smartMap[SourceKind.RPCollectionArticle] = new SmartUi(
                groupedPublishersPRCollectionArticle,
                lbPRCAPublishingLocation,
                lbPRCAPublisher,
                lbPRCAPublishingLocationSelect,
                cbPRCAPublisher);


            // ───────── электронные ─────────
            _smartMap[SourceKind.EREBook] = new SmartUi(
                groupedPublishersEREbook,
                lbEREbPublishingLocation,
                lbEREbPublisher,
                lbEREbPublishingLocationSelect,
                cbEREbPublisher);

            _smartMap[SourceKind.ERCollectionArticle] = new SmartUi(
                groupedPublishersERCollectionArticle,
                lbERCAPublishingLocation,
                lbERCAPublisher,
                lbERCAPublishingLocationSelect,
                cbERCAPublisher);

            foreach (TabPage outerPage in tcCategories.TabPages)
            {
                var innerTabs = outerPage.Controls
                                         .OfType<TabControl>()
                                         .FirstOrDefault();
                if (innerTabs == null)
                    continue;

                foreach (TabPage innerPage in innerTabs.TabPages)
                    _initialSnapshots[innerPage] = FormSnapshot.Capture(innerPage);
            }
        }

        private sealed record SavedEntry(
            string ResultText,
            int CategoryIndex,
            int TypeIndex,
            FormSnapshot Snapshot,
            SourceKind Kind,
            Dictionary<string, List<string>> PublishersMap,
            bool IsSmartMode,
            bool CanRestore = true
        );


        private ResultItem<SavedEntry>? _lastSavedResult;
        private readonly List<SavedEntry> _entries = new();

        private Dictionary<string, List<string>> groupedPublishersPRBook = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersPRCollectionArticle = new Dictionary<string, List<string>>();

        private Dictionary<string, List<string>> groupedPublishersEREbook = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERCollectionArticle = new Dictionary<string, List<string>>();

        //
        // ------------------------- КОНТЕКСТНОЕ МЕНЮ И ЕГО ФУНКЦИОНАЛ + DRAG AND DROP ДЛЯ LISTBOX ----------------------------
        //

        private bool ShowEditDialog(string initialText, out string editedText)
        {
            // создаём форму
            using var dlg = new Form()
            {
                Text = "Редактировать запись",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                ShowInTaskbar = false,
                Width = 400,
                Height = 200
            };

            var rtb = new RichTextBox()
            {
                Dock = DockStyle.Fill,
                Text = initialText,
                WordWrap = false,
                Font = new System.Drawing.Font("Consolas", 10)
            };
            dlg.Controls.Add(rtb);
            rtb.ContextMenuStrip = cmsRichTextBox_TextBox;

            // кнопки ОК и Отмена
            var pnl = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };
            dlg.Controls.Add(pnl);

            var btnOk = new Button()
            {
                Text = "Применить",
                DialogResult = DialogResult.OK,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
                Width = 80,
                Height = 25,
                Left = dlg.ClientSize.Width - 180,
                Top = 8
            };
            pnl.Controls.Add(btnOk);
            dlg.AcceptButton = btnOk;

            var btnCancel = new Button()
            {
                Text = "Отмена",
                DialogResult = DialogResult.Cancel,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
                Width = 80,
                Height = 25,
                Left = dlg.ClientSize.Width - 90,
                Top = 8
            };
            pnl.Controls.Add(btnCancel);
            dlg.CancelButton = btnCancel;

            // Показываем диалог
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                editedText = rtb.Text;
                return true;
            }
            else
            {
                editedText = initialText;
                return false;
            }
        }

        // Переменная для хранения текущего выбранного ListBox для удаления или захвата элементов
        private ListBox _currentListBox = null;
        private int dragIndex = -1;
        private string _dragSelectedPlace = null;
        private string _savedPublishingLocation = null;


        // Обработка нажатия мыши – начало перетаскивания или контекстное меню
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is not ListBox lb) return;

            if (e.Button == MouseButtons.Left)
            {
                dragIndex = lb.IndexFromPoint(e.Location);

                if (lb.Name.Contains("Publisher"))
                {
                    // mainLocationList = lbPRBPublishingLocation
                    var mainLocationList = lb.Tag as ListBox;
                    // selector          = lbPRBPublishingLocationSelect
                    var selector = mainLocationList?.Tag as ListBox;

                    bool smartModeOn = selector != null && selector.Enabled;

                    if (smartModeOn)                                    // проверяем ТОЛЬКО в Smart Mode
                    {
                        if (selector.SelectedItem is string place)
                            _dragSelectedPlace = place;
                        else if (!string.IsNullOrEmpty(_savedPublishingLocation))
                            _dragSelectedPlace = _savedPublishingLocation;
                        else
                        {
                            MessageBox.Show(
                                "Пожалуйста, выберите место издания, прежде чем перетаскивать издательства местами.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        // Обычный режим – свободное перетаскивание
                        _dragSelectedPlace = null;
                    }
                }

                if (dragIndex != -1)
                    lb.DoDragDrop(lb.Items[dragIndex], DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                _currentListBox = lb;
                int index = lb.IndexFromPoint(e.Location);
                if (index >= 0)
                    lb.SelectedIndex = index;
            }
        }

        // Движение мыши с зажатой кнопкой – инициирует перетаскивание
        private void ListBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragIndex != -1 && sender is ListBox lb)
            {
                lb.DoDragDrop(lb.Items[dragIndex], DragDropEffects.Move);
            }
        }

        // Обработка события DragOver – указываем эффект
        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        // Обработка события DragDrop – перемещение и обновление словаря
        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is not ListBox lb)
                return;

            // 1. Извлекаем перетаскиваемый элемент (ResultItem<SavedEntry> или string)
            object dragItem = e.Data.GetData(typeof(ResultItem<SavedEntry>))
                           ?? e.Data.GetData(typeof(string));
            if (dragItem == null)
                return;

            // 2. Определяем старый и новый индексы
            int oldIndex = lb.Items.IndexOf(dragItem);
            if (oldIndex < 0)
                return;

            Point pt = lb.PointToClient(new Point(e.X, e.Y));
            int rawIndex = lb.IndexFromPoint(pt);
            if (rawIndex < 0 || rawIndex > lb.Items.Count)
                rawIndex = lb.Items.Count;

            // после удаления индекс смещается, поэтому корректируем
            int newIndex = rawIndex > oldIndex ? rawIndex - 1 : rawIndex;

            // Защита от перетаскивания в то же место
            if (newIndex == oldIndex)
                return;

            // 3. Выполняем в Undo/Redo
            _undoManager.Execute(
                lb,
                // --- Do: удалить+вставить
                () =>
                {
                    lb.Items.RemoveAt(oldIndex);
                    lb.Items.Insert(newIndex, dragItem);
                    lb.SelectedIndex = newIndex;

                    // Если это список результатов — переставляем и в _entries
                    if (lb == lbResult)
                    {
                        var moved = _entries[oldIndex];
                        _entries.RemoveAt(oldIndex);
                        _entries.Insert(newIndex, moved);
                        RefreshRestoreButtons();
                    }
                },
                // --- Undo: вернуть обратно
                () =>
                {
                    lb.Items.RemoveAt(newIndex);
                    lb.Items.Insert(oldIndex, dragItem);
                    lb.SelectedIndex = oldIndex;

                    if (lb == lbResult)
                    {
                        var moved = _entries[newIndex];
                        _entries.RemoveAt(newIndex);
                        _entries.Insert(oldIndex, moved);
                        RefreshRestoreButtons();
                    }
                }
            );

            // 4. Дополнительная логика для остальных ListBox
            if (lb.Name.Contains("PublishingLocation") && lb.Tag is ListBox selector)
            {
                UpdatePublishingLocationSelector(lb, selector);
            }
            else if (lb.Name.Contains("Publisher") && _dragSelectedPlace is not null)
            {
                var dict = GetDictionaryByListBox(lb);
                dict[_dragSelectedPlace] = lb.Items.Cast<string>().ToList();
            }
        }

        private void cmsListBox_Opening(object sender, CancelEventArgs e)
        {
            if (_currentListBox == lbResult)
            {
                int idx = _currentListBox.SelectedIndex;
                if (idx >= 0 && idx < _entries.Count)
                {
                    var entry = _entries[idx];
                    tsmiRestoreEntry.Visible = true;
                    tsmiRestoreEntry.Enabled = entry.CanRestore;
                }
                else
                {
                    tsmiRestoreEntry.Visible = false;
                }
            }
            else
            {
                tsmiRestoreEntry.Visible = false;
            }

            bool hasSel = _currentListBox != null && _currentListBox.SelectedIndex >= 0;
            tsmiDeleteSelected.Visible = hasSel;
            tsmiCopy.Visible = hasSel;
            tsmiEdit.Visible = hasSel;
            tsmiUndo.Enabled = _currentListBox != null && _undoManager.CanUndo(_currentListBox);
            tsmiDeleteAll.Enabled = _currentListBox?.Items.Count > 0;
            toolStripSeparator5.Visible = _currentListBox != null && _currentListBox.SelectedIndex >= 0;
        }

        // Кнопка "Удалить"
        private void tsmiDeleteSelected_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null && _currentListBox.SelectedIndex >= 0)
            {
                _undoManager.DeleteItem(_currentListBox);

                // Если удаляем автора из lbPRBAuthors – обновляем чекбокс
                if (_currentListBox.Name.Contains("Authors"))
                {
                    UpdateListCheckBox(_currentListBox, 1, 4);
                }

                if (_currentListBox.Name.Contains("PublishingLocation") && _currentListBox.Tag is ListBox selectListBox)
                {
                    UpdatePublishingLocationSelector(_currentListBox, selectListBox);
                }
            }
        }

        // Кнопка "Удалить все"
        private void tsmiDeleteAll_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null)
            {
                _undoManager.ClearItems(_currentListBox);

                // Если удаляем автора из lbPRBAuthors – обновляем чекбокс
                if (_currentListBox.Name.Contains("Authors"))
                {
                    UpdateListCheckBox(_currentListBox, 1, 4);
                }

                if (_currentListBox.Name.Contains("PublishingLocation") && _currentListBox.Tag is ListBox selectListBox)
                {
                    UpdatePublishingLocationSelector(_currentListBox, selectListBox);
                }
            }
        }

        // Кнопка "Копировать"
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null && _currentListBox.SelectedIndex >= 0)
            {
                string selectedItem = _currentListBox.Items[_currentListBox.SelectedIndex].ToString();
                Clipboard.SetText(selectedItem);
            }
        }

        private void RefreshRestoreButtons()
        {
            // «Восстановить последнюю запись» активна, только если именно последняя запись CanRestore == true
            if (_entries.Count > 0)
                tsmiRestoreLastEntry.Enabled = _entries[^1].CanRestore;  // ^1 — последний элемент
            else
                tsmiRestoreLastEntry.Enabled = false;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (_currentListBox == null || _currentListBox.SelectedIndex < 0)
                return;

            int idx = _currentListBox.SelectedIndex;
            string oldText = _currentListBox.Items[idx].ToString();
            string newText = oldText;
            bool isAuthor = _currentListBox.Name.Contains("Authors")
                            || _currentListBox.Name.Contains("Editor");

            // Цикл повторного показа диалога, пока ввод не станет валидным
            while (true)
            {
                // Показываем диалог с текущим значением
                if (!ShowEditDialog(newText, out string candidate))
                    return;  // Отмена

                // Проверяем на пустую строку
                if (string.IsNullOrWhiteSpace(candidate))
                {
                    MessageBox.Show(
                        "Пустую строку добавить нельзя",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    newText = candidate;  // подставим в поле то, что ввёл пользователь
                    continue;             // повторяем диалог
                }

                // Проверка авторов/редакторов
                if (isAuthor && !AuthorsRegex.IsMatch(candidate))
                {
                    MessageBox.Show(
                        "Неверный формат имени. Разрешены те же варианты, что и при добавлении",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    newText = candidate;
                    continue; // повторяем диалог
                }

                // Всё валидно — выходим из цикла
                newText = candidate;
                break;
            }

            // редактируем элемент в lbResult
            if (_currentListBox == lbResult)
            {
                var oldItem = (ResultItem<SavedEntry>)_currentListBox.Items[idx];
                var oldEntry = oldItem.Entry;

                // создаём новую запись с CanRestore = false
                var newEntry = oldEntry with { ResultText = newText, CanRestore = false };
                var newItem = new ResultItem<SavedEntry>(newText, newEntry);

                // регистрируем замену в Undo/Redo
                _undoManager.Execute(
                    lbResult,
                    doAction: () =>
                    {
                        lbResult.Items[idx] = newItem;
                        _entries[idx] = newEntry;
                    },
                    undoAction: () =>
                    {
                        lbResult.Items[idx] = oldItem;
                        _entries[idx] = oldEntry;
                    });

                RefreshRestoreButtons();
                return;
            }
            // остальные ListBox
            else
            {
                _undoManager.EditItem(_currentListBox, idx, newText);

                if (_currentListBox.Name.Contains("PublishingLocation") &&
                    _currentListBox.Tag is ListBox locationSelector)
                {
                    var dict = GetDictionaryByListBox(_currentListBox);
                    if (dict.TryGetValue(oldText, out var pubs))
                    {
                        dict.Remove(oldText);
                        dict[newText] = pubs;
                    }
                    UpdatePublishingLocationSelector(_currentListBox, locationSelector);
                }
                else if (_currentListBox.Name.Contains("Publisher") &&
                         _currentListBox.Tag is ListBox pubSelector &&
                         pubSelector.SelectedItem is string placeKey)
                {
                    var dict = GetDictionaryByListBox(_currentListBox);
                    if (dict.TryGetValue(placeKey, out var list) && idx < list.Count)
                        list[idx] = newText;
                }
            }
        }

        private void tsmiRestoreEntry_Click(object sender, EventArgs e)
        {
            RestoreEntry(lbResult.SelectedIndex);
        }

        private void tsmiRestoreLastEntry_Click(object sender, EventArgs e)
        {
            int idx = _entries.FindLastIndex(ent => ent.CanRestore);
            if (idx == -1)
            {
                MessageBox.Show("Нет результатов для восстановления.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RestoreEntry(idx);
        }

        private void tsmiClearForm_Click(object sender, EventArgs e)
        {
            var outer = tcCategories.SelectedTab;
            var innerTabs = outer.Controls
                                 .OfType<TabControl>()
                                 .FirstOrDefault();
            if (innerTabs == null)
                return;

            var activePage = innerTabs.SelectedTab;

            // Восстанавливаем снимок страницы
            if (_initialSnapshots.TryGetValue(activePage, out var snap))
                snap.Restore();

            // Гасим smart-режим
            var kind = GetCurrentKind();
            if (kind.HasValue && _smartMap.TryGetValue(kind.Value, out var ui))
            {
                ui.CbSmartMode.Checked = false;
                ui.Dict.Clear();
                ui.LbPlaces.Items.Clear();
                ui.LbSelector.Items.Clear();
                ui.LbPublishers.Items.Clear();
            }

            // Обновляем чекбоксы авторов
            RefreshAuthorCheckboxes();
        }

        private void cmsRichTextBox_TextBox_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Определяем, для какого RichTextBox вызвано меню
            var menu = sender as ContextMenuStrip;
            var tb = menu?.SourceControl as TextBoxBase;
            if (tb == null)
            {
                e.Cancel = true;
                return;
            }

            // Активируем/деактивируем пункты меню
            tsmiUndoRichTextBox.Enabled = tb.CanUndo;
            tsmiCutRichTextBox.Enabled = tb.SelectionLength > 0;
            tsmiCopyRichTextBox.Enabled = tb.SelectionLength > 0;
            tsmiPasteRichTextBox.Enabled = Clipboard.ContainsText();
            tsmiDeleteRichTextBox.Enabled = tb.SelectionLength > 0;
            tsmiSelectAllRichTextBox.Enabled = tb.TextLength > 0;
            tsmiUnableClearingRichTextBox1.Visible = tb == rtbGOST;
            tsmiUnableClearingRichTextBox2.Visible = tb == rtbMLA;
            toolStripSeparator4.Visible = tb == rtbGOST || tb == rtbMLA;
            tsmiClearRichTextBox.Enabled = tb.TextLength > 0;
        }

        private void UniversalRichTextBox_TextBox_MenuItemClick(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var tb = cmsRichTextBox_TextBox.SourceControl as TextBoxBase;
            if (tb == null || menuItem == null) return;

            // Определяем действие по тексту пункта меню
            switch (menuItem.Text)
            {
                case "Очистить":
                    if (tb.TextLength > 0) tb.Clear();
                    break;
                case "Отменить":
                    if (tb.CanUndo) tb.Undo();
                    break;
                case "Вырезать":
                    if (tb.SelectionLength > 0) tb.Cut();
                    break;
                case "Копировать":
                    if (tb.SelectionLength > 0) tb.Copy();
                    break;
                case "Вставить":
                    if (Clipboard.ContainsText()) CleanPasteHelper.PasteWithoutNewlines(tb);
                    break;
                case "Удалить":
                    if (tb.SelectionLength > 0) tb.SelectedText = "";
                    break;
                case "Выделить все":
                    if (tb.TextLength > 0) tb.SelectAll();
                    break;
            }
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            if (_currentListBox != null && _undoManager.CanUndo(_currentListBox))
                _undoManager.Undo(_currentListBox);
        }

        private void cmsMainTabControl_Opening(object sender, CancelEventArgs e)
        {
            RefreshRestoreButtons();
        }

        //
        // ------------------------- ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ ----------------------------
        //

        private static readonly Regex AuthorsRegex = new Regex(
            @"^\s*" +
            @"(?:" +                                                  // Автор 1
                @"(?:[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+[A-ZА-ЯЁ]{1,}\.\s*(?:[A-ZА-ЯЁ]{1,}\.)?" +
                @"|" +
                @"[A-ZА-ЯЁ]{1,}\.\s*(?:[A-ZА-ЯЁ]{1,}\.)?\s+[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+" +
            @")" +
            @"(?:\s*,\s*" +                                           // , Автор N
                @"(?:" +
                    @"(?:[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+[A-ZА-ЯЁ]{1,}\.\s*(?:[A-ZА-ЯЁ]{1,}\.)?" +
                    @"|" +
                    @"[A-ZА-ЯЁ]{1,}\.\s*(?:[A-ZА-ЯЁ]{1,}\.)?\s+[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+" +
                @")" +
            @")*" +
            @"\s*$",
            RegexOptions.Compiled);

        private static readonly Regex SurnameInitialsRegex = new Regex(
            @"^\s*" +
            @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+" +
            @"(?<i1>[A-ZА-ЯЁ]{1,}\.)\s*" +
            @"(?<i2>[A-ZА-ЯЁ]{1,}\.)?" +
            @"\s*$",
            RegexOptions.Compiled);

        private void HandlePublishingLocationSelection(object sender)
        {
            if (sender is ListBox lb && lb.SelectedItem is string selected)
            {
                _dragSelectedPlace = selected;
                _savedPublishingLocation = selected;
            }
        }

        // Функция обработчик вставки текста через Ctrl V
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox textBox)
                return;

            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                CleanPasteHelper.PasteWithoutNewlines(textBox);
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (textBox.Tag is not ListBox targetListBox)
                    return;

                // Обработка ввода места издания
                if (targetListBox.Name.Contains("PublishingLocation"))
                {
                    AddStringToListBox(textBox, targetListBox);

                    // после добавления места обновляем селектор умного режима
                    if (targetListBox.Tag is ListBox selector)
                        UpdatePublishingLocationSelector(targetListBox, selector);

                    return;
                }

                // Обработка ввода издательства (умный режим или нет)
                if (targetListBox.Name.Contains("Publisher"))
                {
                    // основный список мест, к которому привязано это поле
                    var mainLocationList = targetListBox.Tag as ListBox;
                    var selector = mainLocationList?.Tag as ListBox;

                    bool smartModeEnabled = selector != null && selector.Enabled;
                    var groupedPublishers = GetDictionaryByListBox(targetListBox);

                    AddStringToPublisherListBox(
                        textBox,
                        targetListBox,
                        smartModeEnabled,
                        selector,
                        groupedPublishers);

                    // в обычном режиме ничего больше не нужно
                    return;
                }

                AddStringToListBox(textBox, targetListBox);
            }
        }

        // Функция обработчик нажатий delete и backspace для удаления записей из listbox
        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(sender is ListBox listBox))
                return;

            // Ctrl+Z → Undo
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (_undoManager.CanUndo(listBox))
                {
                    _undoManager.Undo(listBox);

                    if (listBox.Name.Contains("Authors"))
                        UpdateListCheckBox(listBox, 1, 4);
                    if (listBox.Name.Contains("PublishingLocation") && listBox.Tag is ListBox selectListBox)
                        UpdatePublishingLocationSelector(listBox, selectListBox);
                }
                e.Handled = true;
                return;
            }

            // Ctrl+Y → Redo
            if (e.Control && e.KeyCode == Keys.Y)
            {
                if (_undoManager.CanRedo(listBox))
                {
                    _undoManager.Redo(listBox);

                    if (listBox.Name.Contains("Authors"))
                        UpdateListCheckBox(listBox, 1, 4);
                    if (listBox.Name.Contains("PublishingLocation") && listBox.Tag is ListBox selectListBox)
                        UpdatePublishingLocationSelector(listBox, selectListBox);
                }
                e.Handled = true;
                return;
            }

            // Delete или Backspace → удаление с сохранением для Undo
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                int selectedIndex = listBox.SelectedIndex;
                if (selectedIndex < 0)
                    return;

                _undoManager.DeleteItem(listBox);

                if (listBox.Name.Contains("Authors"))
                    UpdateListCheckBox(listBox, 1, 4);
                if (listBox.Name.Contains("PublishingLocation") && listBox.Tag is ListBox selectListBox)
                    UpdatePublishingLocationSelector(listBox, selectListBox);

                e.Handled = true;
            }
        }

        // Добавление строк в ListBox
        public void AddStringToListBox(TextBox sourceTextBox, ListBox targetListBox)
        {
            string raw = sourceTextBox.Text;
            string input = raw.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Пустую строку добавить нельзя",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (targetListBox.Name.Contains("Authors") || targetListBox.Name.Contains("Editor"))
            {
                if (!AuthorsRegex.IsMatch(input))
                {
                    MessageBox.Show(
                        "Неверный формат имени.\n" +
                        "Допустимые варианты: «Фамилия И. О.», «И. О. Фамилия», «Фамилия И.» или «И. Фамилия».\n" +
                        "Можно перечислять несколько авторов через запятую.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Если это список авторов/редакторов — разбиваем по запятым
            IEnumerable<string> items =
                (targetListBox.Name.Contains("Authors") || targetListBox.Name.Contains("Editor"))
                    ? input.Split(',').Select(x => x.Trim()).Where(x => x.Length > 0)
                    : new[] { input };

            foreach (string item in items)
                _undoManager.AddItem(targetListBox, item);

            sourceTextBox.Clear();

            if (targetListBox.Name.Contains("Authors"))
                UpdateListCheckBox(targetListBox, 1, 4);
        }

        public void AddStringToPublisherListBox(TextBox sourceTextBox, ListBox targetListBox,
            bool smartModeEnabled, ListBox publishingLocationSelector,
            Dictionary<string, List<string>> groupedPublishers)
        {
            string input = sourceTextBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите издательство", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (smartModeEnabled)
            {
                // Если умный режим включён, то нужно выбрать место издания в publishingLocationSelector
                if (publishingLocationSelector.SelectedItem == null)
                {
                    MessageBox.Show("Выберите место издания в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedPlace = publishingLocationSelector.SelectedItem.ToString();
                // Если для выбранного места ещё нет списка издательств, создаём его.
                if (!groupedPublishers.ContainsKey(selectedPlace))
                {
                    groupedPublishers[selectedPlace] = new List<string>();
                }
                groupedPublishers[selectedPlace].Add(input);

                // Обновляем отображение ListBox с издательствами для выбранного места
                UpdatePublishersForSelectedPlace(targetListBox, publishingLocationSelector, groupedPublishers);
            }
            else
            {
                _undoManager.AddItem(targetListBox, input);
                // Если умный режим выключен, просто добавляем издательство
                //targetListBox.Items.Add(input);
            }

            sourceTextBox.Clear();
        }

        // Сбор строк из ListBox в список строк
        private List<string> GetStringsList(ListBox listBox)
        {
            List<string> strings = new List<string>();
            foreach (var item in listBox.Items)
            {
                string str = item.ToString().Trim();
                if (!string.IsNullOrEmpty(str))
                    strings.Add(str);
            }
            return strings;
        }

        static string NameFormatting(string author)
        {
            string cleaned = Regex.Replace(author, @"\s*,\s*", " ").Trim();
            cleaned = Regex.Replace(cleaned, @"\s+", " ");

            var match = Regex.Match(cleaned,
                @"^(?:" +
                    @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+" +
                    @"(?<i1>[A-ZА-ЯЁ]{1,})\.?\s*(?<i2>[A-ZА-ЯЁ]{1,})?\.?" +
                  @"|" +
                    @"(?<i1>[A-ZА-ЯЁ]{1,})\.?\s*(?<i2>[A-ZА-ЯЁ]{1,})?\.?\s+" +
                    @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)" +
                @")$");

            if (!match.Success)
                return cleaned;

            string fam = match.Groups["surname"].Value;
            string i1 = match.Groups["i1"].Value;
            string i2 = match.Groups["i2"].Value;

            // Берём только первые буквы и ставим точку.
            var sb = new StringBuilder();
            sb.Append(fam).Append(' ')
              .Append(i1[0]).Append('.');

            if (!string.IsNullOrEmpty(i2))
                sb.Append(i2[0]).Append('.');

            return sb.ToString();
        }


        // Принимает строку вида "Фамилия В. Н." (запятая опциональна)
        // и возвращает строку "В. Н. Фамилия", если строка соответствует шаблону.
        private string ReverseAuthorName(string author)
        {
            var regex = new Regex(
                @"^(?:" +
                    @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+" +
                    @"(?<i1>[A-ZА-ЯЁ]{1,}\.)\s*(?<i2>[A-ZА-ЯЁ]{1,}\.)?" +
                  @"|" +
                    @"(?<i1>[A-ZА-ЯЁ]{1,}\.)\s*(?<i2>[A-ZА-ЯЁ]{1,}\.)?\s+" +
                    @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)" +
                @")$");

            var m = regex.Match(author.Trim());
            if (!m.Success) return author;

            string s = m.Groups["surname"].Value;
            string i1 = m.Groups["i1"].Value.Trim();
            string i2 = m.Groups["i2"].Value.Trim();

            return string.IsNullOrEmpty(i2)
                ? $"{i1} {s}"
                : $"{i1}{i2} {s}";
        }

        //// Метод, который гарантирует, что после фамилии вставлена запятая,
        //// если её нет во входной строке (например, преобразует "Дорман В. Н." в "Дорман, В. Н.").
        //private string EnsureComma(string author)
        //{
        //    if (author.Contains(','))           // Запятая уже есть — ничего не трогаем
        //        return author.Trim();

        //    var m = SurnameInitialsRegex.Match(author);
        //    if (!m.Success)                     // Не тот формат — вернуть как есть
        //        return author;

        //    string fam = m.Groups["surname"].Value;
        //    string i1 = m.Groups["i1"].Value.Trim();
        //    string i2 = m.Groups["i2"].Value.Trim();

        //    return string.IsNullOrEmpty(i2)
        //        ? $"{fam}, {i1}".Trim()
        //        : $"{fam}, {i1} {i2}".Trim();
        //}

        //// Преобразование полного имени в формат "Фамилия Инициалы"
        //public static string ToSurnameWithInitials(string fullName)
        //{
        //    var regex = new Regex(
        //        @"^\s*" +
        //        @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+" +
        //        @"(?<name>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)" +
        //        @"(?:\s+(?<patr>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+))?" +
        //        @"\s*$",
        //        RegexOptions.Compiled);

        //    var m = regex.Match(fullName);
        //    if (!m.Success)                     // Не узнаётся — вернуть пустую строку
        //        return string.Empty;

        //    string fam = m.Groups["surname"].Value;
        //    string nIni = m.Groups["name"].Value.Substring(0, 1);
        //    string pIni = m.Groups["patr"].Success
        //                    ? m.Groups["patr"].Value.Substring(0, 1)
        //                    : null;

        //    return pIni == null
        //        ? $"{fam} {nIni}."
        //        : $"{fam} {nIni}. {pIni}.";
        //}

        // Связь мест издания и издателей через ":"
        private string CombinePlacesAndPublishers(List<string> places, List<string> publishers)
        {
            List<string> combined = new List<string>();

            for (int i = 0; i < places.Count; i++)
            {
                string place = places[i];
                string publisher = (i < publishers.Count) ? publishers[i] : null;

                if (!string.IsNullOrEmpty(publisher))
                    combined.Add($"{place}: {publisher}");
                else
                    combined.Add(place);
            }

            return string.Join("; ", combined);
        }

        // Умный режим связи мест издания и издательств (когда у места издания несколько издательств)
        private string CombinePlacesAndGroupedPublishers(List<string> places, Dictionary<string, List<string>> groupedPublishers)
        {
            List<string> result = new List<string>();

            foreach (string place in places)
            {
                if (groupedPublishers.TryGetValue(place, out var publishers) && publishers.Count > 0)
                    result.Add(place + ": " + string.Join(": ", publishers));
                else
                    result.Add(place); // Добавляем даже если издательств нет
            }

            return string.Join("; ", result);
        }

        // Метод обновления списка издательств по месту изадния для умного режима
        private void UpdatePublishersForSelectedPlace(ListBox lbPublisherList, ListBox lbPublishingLocationSelect, Dictionary<string, List<string>> groupedPublishers)
        {
            if (lbPublishingLocationSelect.SelectedItem == null) return;

            string selectedPlace = lbPublishingLocationSelect.SelectedItem.ToString();
            lbPublisherList.Items.Clear();

            if (groupedPublishers.ContainsKey(selectedPlace))
            {
                foreach (var publisher in groupedPublishers[selectedPlace])
                {
                    lbPublisherList.Items.Add(publisher);
                }
            }
        }

        // Функция для получения словаря по листбоксу мест издания
        private Dictionary<string, List<string>> GetDictionaryByListBox(ListBox lb)
        {
            if (lb == lbPRBPublishingLocation || lb == lbPRBPublisher) return groupedPublishersPRBook;
            if (lb == lbPRCAPublishingLocation || lb == lbPRCAPublisher) return groupedPublishersPRCollectionArticle;

            if (lb == lbEREbPublishingLocation || lb == lbEREbPublisher) return groupedPublishersEREbook;
            if (lb == lbERCAPublishingLocation || lb == lbERCAPublisher) return groupedPublishersERCollectionArticle;

            return new Dictionary<string, List<string>>(); // Если не найден
        }

        // Обновление списка мест издания для умного режима
        private void UpdatePublishingLocationSelector(ListBox lbPublishingLocations, ListBox lbPublishingLocationSelect)
        {
            lbPublishingLocationSelect.Items.Clear();

            // Добавляем все текущие места издания в селектор
            foreach (var item in lbPublishingLocations.Items)
            {
                lbPublishingLocationSelect.Items.Add(item);
            }

            // Очистка словаря: удаляем ключи, которых больше нет в ListBox
            Dictionary<string, List<string>> dict = GetDictionaryByListBox(lbPublishingLocations);
            if (dict != null)
            {
                var validKeys = lbPublishingLocations.Items.Cast<string>().ToHashSet();
                var keysToRemove = dict.Keys.Where(k => !validKeys.Contains(k)).ToList();

                foreach (var key in keysToRemove)
                {
                    dict.Remove(key);
                }
            }
        }

        // Включение умного режима
        private void TogglePublisherSmartMode(bool enabled, ListBox lbPublisher, ListBox lbLocationSelect,
            Dictionary<string, List<string>> groupedPublishers, string defaultGroupKey = "Default")
        {
            if (enabled)
            {
                // Включаем умный режим: делаем ListBox выбора места активным.
                lbLocationSelect.Enabled = true;

                // Если в обычном ListBox с издательствами уже есть элементы, переносим их в группу "Default".
                if (lbPublisher.Items.Count > 0)
                {
                    if (!groupedPublishers.ContainsKey(defaultGroupKey))
                    {
                        groupedPublishers[defaultGroupKey] = new List<string>();
                    }
                    foreach (var item in lbPublisher.Items)
                    {
                        groupedPublishers[defaultGroupKey].Add(item.ToString());
                    }
                    // Очищаем ListBox, чтобы новые издательства добавлялись уже по умной логике.
                    lbPublisher.Items.Clear();
                }
            }
            else
            {
                // Выключаем умный режим: делаем ListBox выбора места неактивным.
                lbLocationSelect.Enabled = false;

                // Здесь, если в словаре есть группа "Default", возвращаем её элементы в ListBox.
                if (groupedPublishers.ContainsKey(defaultGroupKey))
                {
                    lbPublisher.Items.Clear();
                    foreach (var item in groupedPublishers[defaultGroupKey])
                    {
                        lbPublisher.Items.Add(item);
                    }
                    // После восстановления данных удаляем группу "Default", чтобы очистить временное хранилище.
                    groupedPublishers.Remove(defaultGroupKey);
                }
                else
                {
                    // Если группы "Default" нет, просто очищаем ListBox.
                    lbPublisher.Items.Clear();
                }
            }
        }

        // Универсальная функция для логики чек бокса авторов
        private void UpdateListCheckBox(ListBox listBox, int minCount, int maxCount)
        {
            if (listBox.Tag is System.Windows.Forms.CheckBox checkBox)
            {
                int itemCount = listBox.Items.Count;

                bool canUse = itemCount >= minCount && itemCount < maxCount;

                checkBox.Enabled = canUse;

                if (!canUse && checkBox.Checked)
                    checkBox.Checked = false;
            }
        }

        private void RestoreEntry(int entryIndex)
        {
            if (entryIndex < 0 || entryIndex >= _entries.Count || _entries[entryIndex] == null)
            {
                MessageBox.Show("Эту запись восстановить нельзя.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (entryIndex < 0 || entryIndex >= _entries.Count)
            {
                MessageBox.Show("Нет результатов для восстановления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lbResult.SelectedIndex = entryIndex;
            var entry = _entries[entryIndex];

            // Восстановить вкладки
            tcCategories.SelectedIndex = entry.CategoryIndex;
            var catPage = tcCategories.SelectedTab;
            var inner = catPage.Controls.OfType<TabControl>().FirstOrDefault();
            if (inner != null && entry.TypeIndex >= 0)
                inner.SelectedIndex = entry.TypeIndex;

            // Восстановить все стандартные поля (TextBox, CheckBox, ListBox и т.д.)
            entry.Snapshot.Restore();

            // Восстановить Smart-режим издательств
            if (_smartMap.TryGetValue(entry.Kind, out var ui))
            {
                const string DefaultKey = "Default";

                ui.CbSmartMode.Checked = entry.IsSmartMode;

                ui.Dict.Clear();
                foreach (var kv in entry.PublishersMap)
                    ui.Dict[kv.Key] = new List<string>(kv.Value);

                if (entry.IsSmartMode)
                {
                    // Заполнить LbPlaces и LbSelector всеми местами (кроме Default)
                    ui.LbPlaces.Items.Clear();
                    ui.LbSelector.Items.Clear();
                    foreach (var place in ui.Dict.Keys.Where(k => k != DefaultKey))
                    {
                        ui.LbPlaces.Items.Add(place);
                        ui.LbSelector.Items.Add(place);
                    }

                    // Если есть хотя бы одно место — выбрать первый и обновить список издательств
                    if (ui.LbSelector.Items.Count > 0)
                    {
                        ui.LbSelector.SelectedIndex = 0;
                        UpdatePublishersForSelectedPlace(
                            ui.LbPublishers,
                            ui.LbSelector,
                            ui.Dict);
                    }
                    else
                    {
                        ui.LbPublishers.Items.Clear();
                    }
                }
                // иначе ничего не трогаем
            }

            // Обновить состояние чекбоксов авторов
            RefreshAuthorCheckboxes();
        }

        private void RememberCurrentState(out FormSnapshot snapshot,
                                  out int categoryIndex,
                                  out int typeIndex)
        {
            categoryIndex = tcCategories.SelectedIndex;

            TabPage catPage = tcCategories.SelectedTab;
            TabControl innerTab = catPage.Controls
                                         .OfType<TabControl>()
                                         .FirstOrDefault();

            typeIndex = innerTab?.SelectedIndex ?? -1;

            System.Windows.Forms.Control activePage = innerTab?.SelectedTab ?? catPage;
            snapshot = FormSnapshot.Capture(activePage);
        }

        // проход по всей форме и вызов UpdateListCheckBox где нужно
        private void RefreshAuthorCheckboxes()
        {
            foreach (var lb in FormSnapshot.GetAll(this).OfType<ListBox>())
            {
                if (lb.Name.Contains("Authors") && lb.Tag is System.Windows.Forms.CheckBox cb)
                {
                    UpdateListCheckBox(lb, 1, 4);
                }
            }
        }

        private SourceKind? GetCurrentKind()
        {
            // ── Печатные ──
            if (tcCategories.SelectedTab == tpPrintedResources)
            {
                if (tcPRTypes.SelectedTab == tpPRBook) return SourceKind.PRBook;
                if (tcPRTypes.SelectedTab == tpPRJournalArticle) return SourceKind.PRJournalArticle;
                if (tcPRTypes.SelectedTab == tpRPCollectionArticle) return SourceKind.RPCollectionArticle;
            }
            // ── Электронные ресурсы ──
            else if (tcCategories.SelectedTab == tpElectronicResources)
            {
                if (tcERTypes.SelectedTab == tpEREbook) return SourceKind.EREBook;
                if (tcERTypes.SelectedTab == tpERJournalArticle) return SourceKind.ERJournalArticle;
                if (tcERTypes.SelectedTab == tpERCollectionArticle) return SourceKind.ERCollectionArticle;
                if (tcERTypes.SelectedTab == tpERSite) return SourceKind.ERSite;
            }

            return null;
        }

        // Возвращает «снимок» groupedPublishers и признак включённого smart-режима для данного типа.
        private (Dictionary<string, List<string>> snapshot, bool smartModeEnabled) GetPublisherSnapshot(SourceKind kind)
        {
            if (_smartMap.TryGetValue(kind, out var ui))
            {
                // Клонируем словарь, чтобы дальнейшие правки формы на него не влияли
                var snap = ui.Dict
                             .ToDictionary(
                                kv => kv.Key,
                                kv => new List<string>(kv.Value)
                             );
                return (snap, ui.CbSmartMode.Checked);
            }
            // Для типов без UI издательств/мест
            return (new Dictionary<string, List<string>>(), false);
        }

        // Рекурсивно пробегаем все контролы и регистрируем ListBox у менеджера
        private void RegisterAllListBoxes(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control c in parent.Controls)
            {
                if (c is ListBox lb)
                    _undoManager.Register(lb);

                // Если есть вложенные контейнеры, спускаемся внутрь
                if (c.HasChildren)
                    RegisterAllListBoxes(c);
            }
        }

        // Получить плоский список всех ListBox на форме
        private IEnumerable<ListBox> GetAllListBoxes(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control c in parent.Controls)
            {
                if (c is ListBox lb)
                    yield return lb;

                if (c.HasChildren)
                {
                    foreach (var child in GetAllListBoxes(c))
                        yield return child;
                }
            }
        }

        //
        // ------------------------- КАТЕГОРИЯ "ПЕЧАТНЫЕ РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "КНИГА" ----------------------------

        private void buttonPRBAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbPRBAuthors, lbPRBAuthors);
        }

        private void buttonPRBPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbPRBPublishingLocation, lbPRBPublishingLocation);
            UpdatePublishingLocationSelector(lbPRBPublishingLocation, lbPRBPublishingLocationSelect);
        }

        private void buttonPRBPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbPRBPublisher,
                lbPRBPublisher,
                cbPRBPublisher.Checked,
                lbPRBPublishingLocationSelect,
                groupedPublishersPRBook
            );
        }

        private void buttonPRBEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbPRBEditor, lbPRBEditor);
        }

        private void cbPRBPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbPRBPublisher.Checked,
                lbPRBPublisher,
                lbPRBPublishingLocationSelect,
                groupedPublishersPRBook
            );
        }

        private void lbPRBPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbPRBPublisher,
                lbPRBPublishingLocationSelect,
                groupedPublishersPRBook
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessBook()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbPRBAuthors);
            var rawEditors = GetStringsList(lbPRBEditor);

            string title = tbPRBTitle.Text.Trim().TrimEnd('.', ' ');
            string docType = tbPRBDocumentType.Text.Trim().TrimEnd('.', ' ');
            string translator = tbPRBTranslator.Text.Trim().TrimEnd('.', ' ');
            string editionInfo = tbPRBEditionNumber.Text.Trim().TrimEnd('.', ' ');
            string editorType = cbPRBEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";
            string year = tbPRBPublishYear.Text.Trim().TrimEnd('.', ' ');
            string pages = tbPRBPagesCount.Text.Trim().TrimEnd('.', ' ');

            var places = GetStringsList(lbPRBPublishingLocation);
            var pubs = GetStringsList(lbPRBPublisher);
            bool smartMode = cbPRBPublisher.Checked;

            var errs = new List<string>();
            if (rawAuthors.Count == 0) errs.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errs.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errs.Add("Не указано ни одно место издания");
            if (!smartMode && pubs.Count == 0) errs.Add("Не указано ни одно издательство");
            if (smartMode && groupedPublishersPRBook.Values.Sum(l => l.Count) == 0)
                errs.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errs.Add("Не заполнено поле «Год издания»");

            if (errs.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errs),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formatted = rawAuthors.Select(NameFormatting).ToList();
            var reversed = formatted.Select(ReverseAuthorName).ToList();
            int aCnt = formatted.Count;
            bool forceCut = cbPRBAuthors.Checked && aCnt >= 1;
            bool cutMode = aCnt > 3 || forceCut;

            bool hasTranslator = !string.IsNullOrEmpty(translator);
            bool hasEditors = rawEditors.Count > 0;

            string fullTitle = title;
            if (!string.IsNullOrEmpty(docType))
                fullTitle += $": {docType}";

            string head;
            if (!cutMode)   // ≤3 авторов
            {
                head = $"{string.Join(", ", formatted)} {fullTitle}";
                if (!hasTranslator && !hasEditors && !head.EndsWith("."))
                    head += ".";
            }
            else            // >3 авторов или принудительное сокращение
            {
                string firstUpTo3 = string.Join(", ", reversed.Take(3));
                head = $"{fullTitle} / {firstUpTo3} [и др.]";
                if (!hasTranslator && !hasEditors && !head.EndsWith("."))
                    head += ".";
            }

            string transBlock = "";
            if (hasTranslator)
            {
                transBlock = $" / пер. {translator}";
                if (!hasEditors)
                {
                    if (!transBlock.EndsWith("."))
                        transBlock += ".";
                }
                else
                {
                    transBlock = transBlock.TrimEnd('.') + ".";
                }
            }

            string editorsJoined = string.Join(", ", rawEditors);
            string resp = "";
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                resp = editorType switch
                {
                    var s when s.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase)
                        => $"под общей редакцией {editorsJoined}",
                    var s when s.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase)
                        => $"ответственный редактор {editorsJoined}",
                    _ => $"под редакцией {editorsJoined}"
                };
            }
            string respBlock = string.IsNullOrEmpty(resp) ? "" : $" / {resp}.";

            string editionBlock = "";
            if (!string.IsNullOrEmpty(editionInfo))
            {
                editionBlock = dotMode
                    ? $" {editionInfo}."
                    : $"{SEP}{editionInfo}.";
            }

            string imprint = smartMode
                ? CombinePlacesAndGroupedPublishers(places, groupedPublishersPRBook)
                : CombinePlacesAndPublishers(places, pubs);
            string imprintBlock = $"{SEP}{imprint}, {year}.";

            string pagesBlock = string.IsNullOrEmpty(pages)
                ? ""
                : $"{SEP}{pages} с.";

            string result = (head + transBlock + respBlock +
                             editionBlock + imprintBlock + pagesBlock)
                            .Replace("..", ".")
                            .Replace(" .", ".")
                            .Trim();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbPRBAuthors.Items.Clear();
                lbPRBPublishingLocation.Items.Clear();
                lbPRBPublisher.Items.Clear();
                lbPRBEditor.Items.Clear();
                lbPRBPublishingLocationSelect.Items.Clear();
                groupedPublishersPRBook.Clear();

                tbPRBTitle.Clear();
                tbPRBDocumentType.Clear();
                tbPRBTranslator.Clear();
                tbPRBEditionNumber.Clear();
                tbPRBPublishYear.Clear();
                tbPRBPagesCount.Clear();

                cbPRBPublisher.Checked = false;
                cbPRBAuthors.Checked = false;

                UpdateListCheckBox(lbPRBAuthors, 1, 4);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ЖУРНАЛА" ----------------------------

        private void buttonPRJAAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbPRJAAuthors, lbPRJAAuthors);
        }

        private void ProcessJournalArticle()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbPRJAAuthors);
            string article = tbPRJAArticleTitle.Text.Trim().TrimEnd('.', ' ');
            string journal = tbPRJAJournalName.Text.Trim().TrimEnd('.', ' ');
            string year = tbPRJAPublishYear.Text.Trim().TrimEnd('.', ' ');
            string issue = tbPRJANumber.Text.Trim().TrimEnd('.', ' ');
            string pagesRange = tbPRJAPages.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (rawAuthors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(article)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(journal)) errors.Add("Не заполнено поле «Название журнала»");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(issue)) errors.Add("Не заполнено поле «Номер журнала»");
            if (string.IsNullOrEmpty(pagesRange)) errors.Add("Не заполнено поле «Диапазон страниц»");
            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formatted = rawAuthors.Select(NameFormatting).ToList();      // «Иванов И.И.»
            var reversed = formatted.Select(ReverseAuthorName).ToList();    // «И.И. Иванов»
            int aCnt = formatted.Count;
            bool forceCut = cbPRJAAuthors.Checked && aCnt >= 1;
            bool cutMode = aCnt > 3 || forceCut;

            string head;
            if (!cutMode)
            {
                head = $"{string.Join(", ", formatted)} {article} // {journal}.";
            }
            else
            {
                string first3 = string.Join(", ", reversed.Take(3));
                head = $"{article} / {first3} [и др.] // {journal}.";
            }

            string yearBlock = $"{SEP}{year}.";
            string issueBlock = $"{SEP}№ {issue}.";
            string pagesBlock = $"{SEP} С.{pagesRange}";

            string result = (head + yearBlock + issueBlock + pagesBlock)
                            .Replace("..", ".")
                            .Replace(" .", ".")
                            .TrimEnd();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbPRJAAuthors.Items.Clear();
                tbPRJAArticleTitle.Clear();
                tbPRJAJournalName.Clear();
                tbPRJAPublishYear.Clear();
                tbPRJANumber.Clear();
                tbPRJAPages.Clear();
                cbPRJAAuthors.Checked = false;
                UpdateListCheckBox(lbPRJAAuthors, 1, 4);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ СБОРНИКА" ----------------------------

        private void buttonPRCAAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbPRCAAuthors, lbPRCAAuthors);
        }

        private void buttonPRCAPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbPRCAPublishingLocation, lbPRCAPublishingLocation);
            UpdatePublishingLocationSelector(lbPRCAPublishingLocation, lbPRCAPublishingLocationSelect);
        }

        private void buttonPRCAPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbPRCAPublisher,
                lbPRCAPublisher,
                cbPRCAPublisher.Checked,
                lbPRCAPublishingLocationSelect,
                groupedPublishersPRCollectionArticle
            );
        }

        private void buttonPRCAEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbPRCAEditor, lbPRCAEditor);
        }

        private void cbPRCAPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbPRCAPublisher.Checked,
                lbPRCAPublisher,
                lbPRCAPublishingLocationSelect,
                groupedPublishersPRCollectionArticle
            );
        }

        private void lbPRCAPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbPRCAPublisher,
                lbPRCAPublishingLocationSelect,
                groupedPublishersPRCollectionArticle
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessCollectionArticle()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbPRCAAuthors);
            var rawEditors = GetStringsList(lbPRCAEditor);
            string articleTitle = tbPRCAArticleTitle.Text.Trim().TrimEnd('.', ' ');
            string collectionTitle = tbPRCACollectionName.Text.Trim().TrimEnd('.', ' ');
            string collectionType = tbPRCACollectionType.Text.Trim().TrimEnd('.', ' ');
            string editorType = cbPRCAEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            var places = GetStringsList(lbPRCAPublishingLocation);
            var publishers = GetStringsList(lbPRCAPublisher);
            bool smartMode = cbPRCAPublisher.Checked;

            string year = tbPRCAPublishYear.Text.Trim().TrimEnd('.', ' ');
            string extraType = cbPRCAExtraType.SelectedItem?.ToString() ?? "";
            string extraCount = tbPRCAExtraCount.Text.Trim().TrimEnd('.', ' ');
            string extraNumber = tbPRCAExtraNumber.Text.Trim().TrimEnd('.', ' ');
            string pages = tbPRCAPages.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (rawAuthors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(articleTitle)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(collectionTitle)) errors.Add("Не заполнено поле «Название сборника»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!smartMode && publishers.Count == 0) errors.Add("Не указано ни одно издательство");
            if (smartMode && groupedPublishersPRCollectionArticle.Values.Sum(l => l.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(pages)) errors.Add("Не заполнено поле «Диапазон страниц»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formattedAuthors = rawAuthors.Select(NameFormatting).ToList();
            var reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int authorCount = formattedAuthors.Count;
            bool forceShort = cbPRCAAuthors.Checked && authorCount >= 1;
            bool shortMode = authorCount > 3 || forceShort;

            string head;
            if (!shortMode)
            {
                head = $"{string.Join(", ", formattedAuthors)} {articleTitle}";
            }
            else
            {
                var firstThree = string.Join(", ", reversedAuthors.Take(3));
                head = $"{articleTitle} / {firstThree} [и др.]";
            }

            string collBlock = $" // {collectionTitle}";
            if (!string.IsNullOrEmpty(collectionType))
                collBlock += $": {collectionType}";

            if (!string.IsNullOrEmpty(extraCount))
            {
                // «в N т.», «в N вып.», «в N ч.»
                string abbrCount = extraType switch
                {
                    "Том" => "т.",
                    "Выпуск" => "вып.",
                    "Часть" => "ч.",
                    _ => extraType.ToLowerInvariant()
                };
                collBlock += $": в {extraCount} {abbrCount}";
            }

            var editorsJoined = string.Join(", ", rawEditors);
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                string resp = editorType switch
                {
                    var s when s.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase)
                        => $"под общей редакцией {editorsJoined}",
                    var s when s.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase)
                        => $"ответственный редактор {editorsJoined}",
                    _ => $"под редакцией {editorsJoined}"
                };
                collBlock += $" / {resp}";
            }

            if (!collBlock.TrimEnd().EndsWith("."))
                collBlock += ".";

            string imprint = smartMode
                ? CombinePlacesAndGroupedPublishers(places, groupedPublishersPRCollectionArticle)
                : CombinePlacesAndPublishers(places, publishers);
            string imprintBlock = $"{SEP}{imprint}, {year}.";

            var postImprint = new List<string>();
            if (!string.IsNullOrEmpty(extraNumber))
            {
                string abbrId = extraType switch
                {
                    "Том" => "Т.",
                    "Выпуск" => "Вып.",
                    "Часть" => "Ч.",
                    _ => extraType
                };
                postImprint.Add($"{SEP}{abbrId} {extraNumber}.");
            }
            postImprint.Add($"{SEP} С. {pages}.");

            string result = head
                          + collBlock
                          + imprintBlock
                          + string.Concat(postImprint);

            result = result
                     .Replace("..", ".")
                     .Replace(" .", ".")
                     .TrimEnd();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbPRCAAuthors.Items.Clear();
                lbPRCAPublishingLocation.Items.Clear();
                lbPRCAPublisher.Items.Clear();
                lbPRCAEditor.Items.Clear();
                lbPRCAPublishingLocationSelect.Items.Clear();
                groupedPublishersPRCollectionArticle.Clear();

                tbPRCAArticleTitle.Clear();
                tbPRCACollectionName.Clear();
                tbPRCACollectionType.Clear();
                tbPRCAPublishYear.Clear();
                tbPRCAExtraCount.Clear();
                tbPRCAExtraNumber.Clear();
                tbPRCAPages.Clear();

                cbPRCAPublisher.Checked = false;
                cbPRCAAuthors.Checked = false;

                UpdateListCheckBox(lbPRCAAuthors, 1, 4);
            }
        }

        //
        // ------------------------- КАТЕГОРИЯ "ЭЛЕКТРОННЫЕ РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "ЭЛЕКТРОННАЯ КНИГА" ----------------------------

        private void buttonEREbAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbAuthors, lbEREbAuthors);
        }

        private void buttonEREbPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbPublishingLocation, lbEREbPublishingLocation);
            UpdatePublishingLocationSelector(lbEREbPublishingLocation, lbEREbPublishingLocationSelect);
        }

        private void buttonEREbPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbEREbPublisher,
                lbEREbPublisher,
                cbEREbPublisher.Checked,
                lbEREbPublishingLocationSelect,
                groupedPublishersEREbook
            );
        }

        private void buttonEREbEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbEditor, lbEREbEditor);
        }

        private void cbEREbPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbEREbPublisher.Checked,
                lbEREbPublisher,
                lbEREbPublishingLocationSelect,
                groupedPublishersEREbook
            );
        }

        private void lbEREbPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbEREbPublisher,
                lbEREbPublishingLocationSelect,
                groupedPublishersEREbook
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessElectronicBook()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbEREbAuthors);
            var rawEditors = GetStringsList(lbEREbEditor);

            string title = tbEREbTitle.Text.Trim().TrimEnd('.', ' ');
            string docType = tbEREbDocumentType.Text.Trim().TrimEnd('.', ' ');
            string translator = tbEREbTranslator.Text.Trim().TrimEnd('.', ' ');
            string editionInfo = tbEREbEditionNumber.Text.Trim().TrimEnd('.', ' ');
            string editorType = cbEREbEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";
            string year = tbEREbPublishYear.Text.Trim().TrimEnd('.', ' ');
            string pages = tbEREbPages.Text.Trim().TrimEnd('.', ' ');

            var places = GetStringsList(lbEREbPublishingLocation);
            var pubs = GetStringsList(lbEREbPublisher);
            bool smartMode = cbEREbPublisher.Checked;

            string url = tbEREbURL.Text.Trim();
            string accessDate = tbEREbAccessDate.Text.Trim();
            string sysReq = tbEREbSystemRequirements.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (rawAuthors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!smartMode && pubs.Count == 0) errors.Add("Не указано ни одно издательство");
            if (smartMode && groupedPublishersEREbook.Values.Sum(l => l.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formatted = rawAuthors.Select(NameFormatting).ToList();    // «Белянин В.П.»
            var reversed = formatted.Select(ReverseAuthorName).ToList();  // «В.П. Белянин»
            int aCnt = formatted.Count;
            bool forceCut = cbEREbAuthors.Checked && aCnt >= 1;
            bool cutMode = aCnt > 3 || forceCut;
            string editorsJoined = string.Join(", ", rawEditors);

            string fullTitle = title;
            if (!string.IsNullOrEmpty(docType))
                fullTitle += $": {docType}";

            string head;
            if (!cutMode)
            {
                head = $"{string.Join(", ", formatted)} {fullTitle}{(string.IsNullOrEmpty(editorsJoined) ? "." : "")}";
            }
            else
            {
                string firstThree = string.Join(", ", reversed.Take(3));
                head = $"{fullTitle} / {firstThree} [и др.]{(string.IsNullOrEmpty(editorsJoined) ? "." : "")}";
            }

            string transBlock = string.IsNullOrEmpty(translator)
                ? ""
                : $" / пер. {translator}{(string.IsNullOrEmpty(editorsJoined) && !($" / пер. {translator}").Trim().EndsWith(".") ? "." : "")}";

            string resp = "";
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                resp = editorType switch
                {
                    var s when s.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase)
                        => $"под общей редакцией {editorsJoined}",
                    var s when s.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase)
                        => $"ответственный редактор {editorsJoined}",
                    _ => $"под редакцией {editorsJoined}"
                };
            }
            string respBlock = string.IsNullOrEmpty(resp)
                ? ""
                : $" / {resp}" + (!($" / {resp}").Trim().EndsWith(".") ? "." : "");

            string editionBlock = string.IsNullOrEmpty(editionInfo)
                ? ""
                : $"{SEP}{editionInfo}.";

            string imprint = smartMode
                ? CombinePlacesAndGroupedPublishers(places, groupedPublishersEREbook)
                : CombinePlacesAndPublishers(places, pubs);
            string imprintBlock = $"{SEP}{imprint}, {year}{(string.IsNullOrEmpty(pages) ? "" : ".")}";

            string pagesBlock = string.IsNullOrEmpty(pages)
                ? ""
                : $"{SEP}{pages} с.";

            string elecMark = " [Электронный ресурс].";

            string sysReqBlock = string.IsNullOrEmpty(sysReq)
                ? ""
                : $" Систем. требования: {sysReq}.";

            string urlBlock = $" URL: {url} (дата обращения: {accessDate}).";

            string result = head
                          + transBlock
                          + respBlock
                          + editionBlock
                          + imprintBlock
                          + pagesBlock
                          + elecMark
                          + sysReqBlock
                          + urlBlock;

            result = result
                .Replace("..", ".")
                .Replace(" .", ".")
                .Trim();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbEREbAuthors.Items.Clear();
                lbEREbPublishingLocation.Items.Clear();
                lbEREbPublisher.Items.Clear();
                lbEREbEditor.Items.Clear();
                lbEREbPublishingLocationSelect.Items.Clear();
                groupedPublishersEREbook.Clear();

                tbEREbTitle.Clear();
                tbEREbDocumentType.Clear();
                tbEREbTranslator.Clear();
                tbEREbEditionNumber.Clear();
                tbEREbPublishYear.Clear();
                tbEREbPages.Clear();

                tbEREbURL.Clear();
                tbEREbAccessDate.Clear();
                tbEREbSystemRequirements.Clear();

                cbEREbPublisher.Checked = false;
                cbEREbAuthors.Checked = false;

                UpdateListCheckBox(lbEREbAuthors, 1, 4);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ЭЛЕКТРОННОГО ЖУРНАЛА" ----------------------------

        private void buttonERJAAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERJAAuthors, lbERJAAuthors);
        }

        private void ProcessElectronicJournalArticle()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbERJAAuthors);
            string title = tbERJAArticleTitle.Text.Trim().TrimEnd('.', ' ');
            string journal = tbERJAJournalName.Text.Trim().TrimEnd('.', ' ');
            string journalType = tbERJAJournalType.Text.Trim().TrimEnd('.', ' ');
            string year = tbERJAPublishYear.Text.Trim().TrimEnd('.', ' ');
            string issue = tbERJANumber.Text.Trim().TrimEnd('.', ' ');
            string pages = tbERJAPages.Text.Trim().TrimEnd('.', ' ');
            string url = tbERJAURL.Text.Trim().TrimEnd('.', ' '); ;
            string access = tbERJAAccessDate.Text.Trim().TrimEnd('.', ' '); ;
            string pubDate = tbERJAPublishDate.Text.Trim().TrimEnd('.', ' ');
            string sysReq = tbERJASystemRequirements.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (rawAuthors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(journal)) errors.Add("Не заполнено поле «Название журнала»");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(access)) errors.Add("Не заполнено поле «Дата обращения»");
            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formatted = rawAuthors.Select(NameFormatting).ToList();      // напр. «Иванов И.И.»
            var reversed = formatted.Select(ReverseAuthorName).ToList();   // напр. «И.И. Иванов»
            int aCnt = formatted.Count;
            bool forceCut = cbERJAAuthors.Checked && aCnt >= 1;
            bool cutMode = aCnt > 3 || forceCut;
            string head;
            if (!cutMode)
            {
                head = $"{string.Join(", ", formatted)} {title}";
            }
            else
            {
                string firstThree = string.Join(", ", reversed.Take(3));
                head = $"{title} / {firstThree} [и др.]";
            }

            string journalBlock = $" // {journal}";
            if (!string.IsNullOrEmpty(journalType))
                journalBlock += $": {journalType}";
            if (!journalBlock.TrimEnd().EndsWith("."))
                journalBlock += ".";

            bool hasDate = !string.IsNullOrEmpty(pubDate);
            bool hasIssue = !string.IsNullOrEmpty(issue);
            bool hasPages = !string.IsNullOrEmpty(pages);

            // год
            string yearBlock = $"{SEP}{year}"
                + ((hasDate || hasIssue || hasPages) ? "." : "");

            // дата публикации
            string dateBlock = hasDate
                ? $"{SEP}{pubDate}"
                    + ((hasIssue || hasPages) ? "." : "")
                : "";

            // номер выпуска
            string issueBlock = hasIssue
                ? $"{SEP}№ {issue}"
                    + (hasPages ? "." : "")
                : "";

            string pagesBlock = hasPages
                ? $"{SEP}С. {pages}"
                : "";

            string elecMark = " [Электронный ресурс].";
            string sysReqBlock = string.IsNullOrEmpty(sysReq)
                ? ""
                : $" Систем. требования: {sysReq}.";
            string urlBlock = string.IsNullOrEmpty(sysReqBlock)
                ? $" URL: {url} (дата обращения: {access})."
                : $"{SEP}URL: {url} (дата обращения: {access}).";

            string result = head
                  + journalBlock
                  + yearBlock
                  + dateBlock
                  + issueBlock
                  + pagesBlock
                  + elecMark
                  + sysReqBlock
                  + urlBlock;

            result = result
                .Replace("..", ".")
                .Replace(" .", ".")
                .Trim();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbERJAAuthors.Items.Clear();
                tbERJAArticleTitle.Clear();
                tbERJAJournalName.Clear();
                tbERJAJournalType.Clear();
                tbERJAPublishYear.Clear();
                tbERJANumber.Clear();
                tbERJAPages.Clear();
                tbERJAURL.Clear();
                tbERJAAccessDate.Clear();
                tbERJAPublishDate.Clear();
                tbERJASystemRequirements.Clear();
                cbERJAAuthors.Checked = false;
                UpdateListCheckBox(lbERJAAuthors, 1, 4);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ЭЛЕКТРОННОГО СБОРНИКА" ----------------------------

        private void buttonERCAAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERCAAuthors, lbERCAAuthors);
        }

        private void buttonERCAPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbERCAPublishingLocation, lbERCAPublishingLocation);
            UpdatePublishingLocationSelector(lbERCAPublishingLocation, lbERCAPublishingLocationSelect);
        }

        private void buttonERCAPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERCAPublisher,
                lbERCAPublisher,
                cbERCAPublisher.Checked,
                lbERCAPublishingLocationSelect,
                groupedPublishersERCollectionArticle
            );
        }

        private void buttonERCAEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERCAEditor, lbERCAEditor);
        }

        private void cbERCAPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbERCAPublisher.Checked,
                lbERCAPublisher,
                lbERCAPublishingLocationSelect,
                groupedPublishersERCollectionArticle
            );
        }

        private void lbERCAPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbERCAPublisher,
                lbERCAPublishingLocationSelect,
                groupedPublishersERCollectionArticle
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessElectronicCollectionArticle()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbERCAAuthors);
            var rawEditors = GetStringsList(lbERCAEditor);

            string articleTitle = tbERCAArticleTitle.Text.Trim().TrimEnd('.', ' ');
            string collectionTitle = tbERCACollectionName.Text.Trim().TrimEnd('.', ' ');
            string collectionType = tbERCACollectionType.Text.Trim().TrimEnd('.', ' ');
            string editorType = cbERCAEditorType.SelectedItem?.ToString()?.Trim().TrimEnd('.', ' ') ?? "";

            var places = GetStringsList(lbERCAPublishingLocation);
            var publishers = GetStringsList(lbERCAPublisher);
            bool smartMode = cbERCAPublisher.Checked;

            string year = tbERCAPublishYear.Text.Trim().TrimEnd('.', ' ');
            string pubDate = tbERCAPublishDate.Text.Trim().TrimEnd('.', ' ');
            string extraType = cbERCAExtraType.SelectedItem?.ToString() ?? "";    // «Том», «Выпуск» или «Часть»
            string extraCount = tbERCAExtraCount.Text.Trim().TrimEnd('.', ' ');
            string extraNumber = tbERCAExtraNumber.Text.Trim().TrimEnd('.', ' ');
            string pages = tbERCAPages.Text.Trim().TrimEnd('.', ' ');

            string url = tbERCAURL.Text.Trim();
            string accessDate = tbERCAAccessDate.Text.Trim();
            string sysReq = tbERCASystemRequirements.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (rawAuthors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(articleTitle)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(collectionTitle)) errors.Add("Не заполнено поле «Название сборника»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!smartMode && publishers.Count == 0) errors.Add("Не указано ни одно издательство");
            if (smartMode && groupedPublishersERCollectionArticle.Values.Sum(l => l.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(pages)) errors.Add("Не заполнено поле «Количество/диапазон страниц»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formattedAuthors = rawAuthors.Select(NameFormatting).ToList();
            var reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int authorCount = formattedAuthors.Count;
            bool forceShort = cbERCAAuthors.Checked && authorCount >= 1;
            bool shortMode = authorCount > 3 || forceShort;

            string head;
            if (!shortMode)
            {
                head = $"{string.Join(", ", formattedAuthors)} {articleTitle}";
            }
            else
            {
                var firstThree = string.Join(", ", reversedAuthors.Take(3));
                head = $"{articleTitle} / {firstThree} [и др.]";
            }

            string collBlock = $" // {collectionTitle}";
            if (!string.IsNullOrEmpty(collectionType))
                collBlock += $": {collectionType}";

            if (!string.IsNullOrEmpty(extraCount))
            {
                // «в N т.», «в N вып.», «в N ч.»
                string abbrCount = extraType switch
                {
                    "Том" => "т.",
                    "Выпуск" => "вып.",
                    "Часть" => "ч.",
                    _ => extraType.ToLowerInvariant()
                };
                collBlock += $": в {extraCount} {abbrCount}";
            }

            var editorsJoined = string.Join(", ", rawEditors);
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                string resp = editorType switch
                {
                    var s when s.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase)
                        => $"под общей редакцией {editorsJoined}",
                    var s when s.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase)
                        => $"ответственный редактор {editorsJoined}",
                    _ => $"под редакцией {editorsJoined}"
                };
                collBlock += $" / {resp}";
            }
            if (!collBlock.TrimEnd().EndsWith("."))
                collBlock += ".";

            string imprint = smartMode
                ? CombinePlacesAndGroupedPublishers(places, groupedPublishersERCollectionArticle)
                : CombinePlacesAndPublishers(places, publishers);
            string imprintBlock = $"{SEP}{imprint}, {year}.";
            string dateBlock = string.IsNullOrEmpty(pubDate)
                ? ""
                : $"{SEP}{pubDate}.";

            var postImprint = new List<string>();
            if (!string.IsNullOrEmpty(extraNumber))
            {
                string abbrId = extraType switch
                {
                    "Том" => "Т.",
                    "Выпуск" => "Вып.",
                    "Часть" => "Ч.",
                    _ => extraType
                };
                postImprint.Add($"{SEP}{abbrId} {extraNumber}.");
            }
            if (Regex.IsMatch(pages, @"^\d+$"))
            {
                postImprint.Add($"{SEP} {pages} с.");
            }
            else if (Regex.IsMatch(pages, @"^\d+\s*-\s*\d+$"))
            {
                string range = Regex.Replace(pages, @"\s*-\s*", "-");
                postImprint.Add($"{SEP} С. {range}");
            }
            else
            {
                // нераспознанный формат — просто по умолчанию
                postImprint.Add($"{SEP} {pages} с.");
            }

            string elecMark = " [Электронный ресурс].";
            string sysReqBlock = string.IsNullOrEmpty(sysReq)
                ? ""
                : $" Систем. требования: {sysReq}.";
            string urlBlock = string.IsNullOrEmpty(sysReqBlock)
                ? $" URL: {url} (дата обращения: {accessDate})."
                : $"{SEP}URL: {url} (дата обращения: {accessDate}).";

            string result = head
                          + collBlock
                          + imprintBlock
                          + dateBlock
                          + string.Concat(postImprint)
                          + elecMark
                          + sysReqBlock
                          + urlBlock;

            result = result
                .Replace("..", ".")
                .Replace(" .", ".")
                .TrimEnd();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            // оборачиваем
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            // передаём в Undo-менеджер
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbERCAAuthors.Items.Clear();
                lbERCAPublishingLocation.Items.Clear();
                lbERCAPublisher.Items.Clear();
                lbERCAEditor.Items.Clear();
                lbERCAPublishingLocationSelect.Items.Clear();
                groupedPublishersERCollectionArticle.Clear();

                tbERCAArticleTitle.Clear();
                tbERCACollectionName.Clear();
                tbERCACollectionType.Clear();
                tbERCAPublishYear.Clear();
                tbERCAPublishDate.Clear();
                tbERCAExtraCount.Clear();
                tbERCAExtraNumber.Clear();
                tbERCAPages.Clear();

                tbERCAURL.Clear();
                tbERCAAccessDate.Clear();
                tbERCASystemRequirements.Clear();

                cbERCAPublisher.Checked = false;
                cbERCAAuthors.Checked = false;

                UpdateListCheckBox(lbERCAAuthors, 1, 4);
            }
        }

        // ------------------------- ТИП "САЙТ" ----------------------------

        private void buttonERSAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERSAuthors, lbERSAuthors);
        }

        private void ProcessSite()
        {
            bool dotMode = cbDotDelimiter.Checked;
            string SEP = dotMode ? ". " : " — ";

            var rawAuthors = GetStringsList(lbERSAuthors);
            string title = tbERSResourceTitle.Text.Trim().TrimEnd('.', ' ');
            string siteName = tbERSSiteName.Text.Trim().TrimEnd('.', ' ');
            string year = tbERSPublishYear.Text.Trim().TrimEnd('.', ' ');
            string fullDate = tbERSPublishDate.Text.Trim().TrimEnd('.', ' ');
            string updateDate = tbERSUpdateDate.Text.Trim().TrimEnd('.', ' ');
            string sysReq = tbERSSystemRequirements.Text.Trim().TrimEnd('.', ' ');
            string url = tbERSURL.Text.Trim().TrimEnd(' ', '.');
            string accessDate = tbERSAccessDate.Text.Trim().TrimEnd('.', ' ');

            var errors = new List<string>();
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие ресурса»");
            if (string.IsNullOrEmpty(siteName)) errors.Add("Не заполнено поле «Название сайта»");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год публикации»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");
            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formatted = rawAuthors.Select(NameFormatting).ToList();
            var reversed = formatted.Select(ReverseAuthorName).ToList();
            int aCnt = formatted.Count;
            bool forceCut = cbERSAuthors.Checked && aCnt >= 1;
            bool cutMode = aCnt > 3 || forceCut;

            string titleWithSite = $"{title}: {siteName}{(cutMode ? "" : ".")}";

            string head;
            if (rawAuthors.Count == 0)
            {
                head = titleWithSite;
            }
            else
            {
                if (!cutMode)
                {
                    // ≤3 авторов: все авторы + заголовок с «: сайт»
                    head = $"{string.Join(", ", formatted)} {titleWithSite}";
                }
                else
                {
                    // >3 авторов: заголовок+сайт + «/ первые три [и др.]»
                    head = $"{titleWithSite} / {string.Join(", ", reversed.Take(3))} [и др.].";
                }
            }

            string yearBlock, dateBlock;
            if (string.IsNullOrEmpty(fullDate))
            {
                yearBlock = $"{SEP}{year}";
                dateBlock = "";
            }
            else
            {
                yearBlock = $"{SEP}{year}.";
                dateBlock = $"{SEP}{fullDate}";
            }

            const string elecMark = " [Электронный ресурс].";

            string sysReqBlock = string.IsNullOrEmpty(sysReq) ? "" : $" Систем. требования: {sysReq}.";
            string updateDateBlock = string.IsNullOrEmpty(updateDate) ? "" : $" Дата обновления: {updateDate}.";

            string urlBlock = $"{SEP}URL: {url} (дата обращения: {accessDate}).";

            string result = string.Concat(
                head,
                yearBlock,
                dateBlock,
                elecMark,
                sysReqBlock,
                updateDateBlock,
                urlBlock
            )
            .Replace("..", ".")
            .Replace(" .", ".")
            .Trim();

            var kind = GetCurrentKind()!.Value;
            RememberCurrentState(out var snap, out int catIx, out int typeIx);
            var (pubSnap, smartOn) = GetPublisherSnapshot(kind);
            var saved = new SavedEntry(result, catIx, typeIx, snap, kind, pubSnap, smartOn);
            _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
            _undoManager.AddItem(lbResult, _lastSavedResult);

            if (!tsmiSaveFormData.Checked)
            {
                lbERSAuthors.Items.Clear();
                tbERSResourceTitle.Clear();
                tbERSSiteName.Clear();
                tbERSPublishYear.Clear();
                tbERSPublishDate.Clear();
                tbERSUpdateDate.Clear();
                tbERSSystemRequirements.Clear();
                tbERSURL.Clear();
                tbERSAccessDate.Clear();
                cbERSAuthors.Checked = false;
                UpdateListCheckBox(lbERSAuthors, 1, 4);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string gostRaw = rtbGOST.Text.Trim();
                string mlaRaw = rtbMLA.Text.Trim();
                if (string.IsNullOrEmpty(gostRaw) || string.IsNullOrEmpty(mlaRaw))
                {
                    MessageBox.Show("Оба поля (ГОСТ и MLA) должны быть заполнены.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var rgGOST = new Regex(
                    @"^.*?//\s+(?:(?<journal>.+?)(?=(?:\.\s*\d{4}\.)|(?:\.\s*№\s*\d+(?:\s*\([^)]*\))?\.(?:\s*(?:\d{4}\.|\s*URL:)))))?\s*(?:\.\s*)?(?:(?<year>\d{4})\.\s*)?(?:(?:№\s*(?<issue>\d+(?:\s*\([^)]*\))?)\.\s*)?)(?:-|–)?\s*(?:С\.\s*\d{1,4}-\d{1,4}\.\s*)?URL:\s+(?<url>\S+?)\s*\(дата обращения:\s*(?<access>\d{2}\.\d{2}\.\d{4})\)",
                    RegexOptions.Singleline
                );
                var mG = rgGOST.Match(gostRaw);
                if (!mG.Success)
                {
                    MessageBox.Show("ГОСТ-строка не распознана.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string gJournal = mG.Groups["journal"].Value.Trim();
                string gYear = mG.Groups["year"].Value.Trim();
                string gIssue = mG.Groups["issue"].Value.Trim();
                string gURL = mG.Groups["url"].Value.Trim();
                string gAcc = mG.Groups["access"].Value.Trim();

                var rgMLA = new Regex(
                    @"^(?<mlaAuthors>[^""“”«»]+?)\s*[\""“”«»](?<mlaTitle>[^""“”«»]+)[\""“”«»]" +
                    @"(?=.*\bpp\.?\s*(?<pages>\d{1,4}(?:\s*[-–—-]\s*\d{1,4})?))" +
                    @"(?:(?=.*\bno\.\s*(?<no>\d{1,4})))?" +
                    @"(?:(?=.*doi:(?<doi>10\.\d{4,9}/[-._;()/:A-Z0-9]+)))?.*$",
                    RegexOptions.Singleline | RegexOptions.IgnoreCase
                );
                var mM = rgMLA.Match(mlaRaw);
                if (!mM.Success)
                {
                    MessageBox.Show("MLA-строка не распознана.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // авторы
                string[] mlaAuthors = mM.Groups["mlaAuthors"].Value
                    .Replace(" and ", ",", StringComparison.OrdinalIgnoreCase)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => NameFormatting(a.Trim()))
                    .ToArray();
                string mlaTitle = mM.Groups["mlaTitle"].Value.Trim();
                string mlaPages = mM.Groups["pages"].Value.Trim();
                string mlaNo = mM.Groups["no"].Value.Trim();
                const string SEP = " — ";

                var sb = new StringBuilder();

                bool forceCut = cbERJAAuthors.Checked && mlaAuthors.Length >= 1;
                bool cutMode = mlaAuthors.Length > 3 || forceCut;
                if (!cutMode)
                {
                    // ≤3 авторов: все “в голову”
                    sb.Append(string.Join(", ", mlaAuthors))
                      .Append(' ')
                      .Append(mlaTitle);
                    // перечисляем авторов после «/»:
                    sb.Append(" / ")
                      .Append(string.Join(", ", mlaAuthors.Select(ReverseAuthorName)));
                }
                else
                {
                    // >3 авторов:
                    sb.Append(mlaTitle)
                      .Append(" / ")
                      .Append(string.Join(", ",
                          mlaAuthors.Take(3)
                                    .Select(ReverseAuthorName)))
                      .Append(" [и др.]");
                }

                sb.Append(" // ").Append(gJournal).Append('.')
                  .Append(SEP).Append(gYear);

                string finalNo = !string.IsNullOrEmpty(mlaNo)
                                   ? mlaNo
                                   : gIssue;
                if (!string.IsNullOrEmpty(finalNo))
                    sb.Append('.').Append(SEP)
                      .Append("№ ").Append(finalNo);

                if (!string.IsNullOrEmpty(mlaPages))
                    sb.Append('.').Append(SEP)
                      .Append("С. ").Append(mlaPages);

                sb.Append(" [Электронный ресурс].")
                  .Append(" URL: ")
                  .Append(gURL)
                  .Append(" (дата обращения: ")
                  .Append(gAcc)
                  .Append(").");

                if (!tsmiUnableClearingRichTextBox1.Checked) rtbGOST.Clear();
                if (!tsmiUnableClearingRichTextBox2.Checked) rtbMLA.Clear();

                string result = sb.ToString();

                RememberCurrentState(out var snap, out int catIx, out int typeIx);

                // для конвертации это просто пустой словарь и false
                var kind = GetCurrentKind() ?? SourceKind.ERSite;
                var (pubSnap, smartOn) = GetPublisherSnapshot(kind);

                // собираем SavedEntry, но запрещаем восстановления
                var saved = new SavedEntry(
                    result,
                    catIx,
                    typeIx,
                    snap,
                    kind,
                    pubSnap,
                    smartOn,
                    false
                );

                _lastSavedResult = new ResultItem<SavedEntry>(result, saved);
                _undoManager.AddItem(lbResult, _lastSavedResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неожиданная ошибка: " + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFillForm_Click(object sender, EventArgs e)
        {
            try
            {
                string gostRaw = rtbGOST.Text.Trim();
                string mlaRaw = rtbMLA.Text.Trim();
                if (string.IsNullOrWhiteSpace(gostRaw) ||
                    string.IsNullOrWhiteSpace(mlaRaw))
                {
                    MessageBox.Show("Заполните оба поля (ГОСТ и MLA).",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var rgGOST = new Regex(
                    @"^.*?//\s+(?:(?<journal>.+?)(?=(?:\.\s*\d{4}\.)|(?:\.\s*№\s*\d+(?:\s*\([^)]*\))?\.(?:\s*(?:\d{4}\.|\s*URL:)))))?\s*(?:\.\s*)?(?:(?<year>\d{4})\.\s*)?(?:(?:№\s*(?<issue>\d+(?:\s*\([^)]*\))?)\.\s*)?)(?:-|–)?\s*(?:С\.\s*\d{1,4}-\d{1,4}\.\s*)?URL:\s+(?<url>\S+?)\s*\(дата обращения:\s*(?<access>\d{2}\.\d{2}\.\d{4})\)",
                    RegexOptions.Singleline
                );
                var mG = rgGOST.Match(gostRaw);
                if (!mG.Success)
                {
                    MessageBox.Show("ГОСТ-строка не распознана.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string gJournal = mG.Groups["journal"].Value.Trim();
                string gYear = mG.Groups["year"].Value.Trim();
                string gIssue = mG.Groups["issue"].Value.Trim();
                string gURL = mG.Groups["url"].Value.Trim();
                string gAcc = mG.Groups["access"].Value.Trim();

                var rgMLA = new Regex(
                  @"^(?<mlaAuthors>[^""“”«»]+?)\s*[\""“”«»](?<mlaTitle>[^""“”«»]+)[\""“”«»]" +
                  @"(?=.*\bpp\.?\s*(?<pages>\d{1,4}(?:\s*[-–—-]\s*\d{1,4})?))" +
                  @"(?:(?=.*\bno\.\s*(?<no>\d{1,4})))?" +
                  @"(?:(?=.*doi:(?<doi>10\.\d{4,9}\/[-._;()\/:A-Z0-9]+)))?.*$",
                  RegexOptions.Singleline | RegexOptions.IgnoreCase
                );
                var mM = rgMLA.Match(mlaRaw);
                if (!mM.Success)
                {
                    MessageBox.Show("MLA-строка не распознана.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // авторы
                var authors = mM.Groups["mlaAuthors"].Value
                    .Replace(" and ", ",", StringComparison.OrdinalIgnoreCase)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => NameFormatting(a.Trim()))
                    .ToArray();

                string mlaTitle = mM.Groups["mlaTitle"].Value.Trim();
                string mlaPages = mM.Groups["pages"].Value.Trim();
                string mlaNo = mM.Groups["no"].Value.Trim();

                lbERJAAuthors.Items.Clear();
                foreach (var a in authors.Select(ReverseAuthorName))
                    lbERJAAuthors.Items.Add(a);
                UpdateListCheckBox(lbERJAAuthors, 1, 5);

                tbERJAArticleTitle.Text = mlaTitle;
                tbERJAJournalName.Text = gJournal;
                tbERJAJournalType.Clear();
                tbERJAPublishYear.Text = gYear;

                string finalNo = !string.IsNullOrEmpty(mlaNo) ? mlaNo : gIssue;
                tbERJANumber.Text = finalNo;

                tbERJAPages.Text = mlaPages;

                tbERJAPublishDate.Clear();
                tbERJASystemRequirements.Clear();

                tbERJAURL.Text = gURL;
                tbERJAAccessDate.Text = gAcc;

                tcCategories.SelectedTab = tpElectronicResources;
                tcERTypes.SelectedTab = tpERJournalArticle;

                if (!tsmiUnableClearingRichTextBox1.Checked) rtbGOST.Clear();
                if (!tsmiUnableClearingRichTextBox2.Checked) rtbMLA.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неожиданная ошибка: " + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Единая функция для кнопки "Добавить", которая определяет активные вкладки
        // и вызывает функцию формирования записи для соответствующего типа источника.
        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (tcCategories.SelectedTab == tpPrintedResources)
            {
                if (tcPRTypes.SelectedTab == tpPRBook)
                {
                    ProcessBook();
                }
                else if (tcPRTypes.SelectedTab == tpPRJournalArticle)
                {
                    ProcessJournalArticle();
                }
                else if (tcPRTypes.SelectedTab == tpRPCollectionArticle)
                {
                    ProcessCollectionArticle();
                }
            }
            else if (tcCategories.SelectedTab == tpElectronicResources)
            {
                if (tcERTypes.SelectedTab == tpEREbook)
                {
                    ProcessElectronicBook();
                }
                else if (tcERTypes.SelectedTab == tpERJournalArticle)
                {
                    ProcessElectronicJournalArticle();
                }
                else if (tcERTypes.SelectedTab == tpERCollectionArticle)
                {
                    ProcessElectronicCollectionArticle();
                }
                else if (tcERTypes.SelectedTab == tpERSite)
                {
                    ProcessSite();
                }
            }
        }

        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            string strCopy = "";
            foreach (var item in lbResult.Items)
            {
                string str = item.ToString().Trim();
                if (!string.IsNullOrEmpty(str))
                    strCopy += str + "\n";
            }

            if (string.IsNullOrEmpty(strCopy))
            {
                MessageBox.Show(
                    "Список результатов пуст. Нечего копировать.",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            Clipboard.SetText(strCopy);
        }

        private void ExportToWord(List<string> lines, string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);

                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    var mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                    var body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                    foreach (string line in lines)
                    {
                        var paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph();

                        var paraProps = new DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties
                        {
                            Justification = new DocumentFormat.OpenXml.Wordprocessing.Justification
                            {
                                Val = DocumentFormat.OpenXml.Wordprocessing.JustificationValues.Both
                            },
                            SpacingBetweenLines = new DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines
                            {
                                Line = "360", // 1.5 строки
                                LineRule = DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues.Auto,
                                Before = "0",
                                After = "0"
                            },
                            Indentation = new DocumentFormat.OpenXml.Wordprocessing.Indentation
                            {
                                FirstLine = "709" // 1.25 см 
                            }
                        };

                        paragraph.Append(paraProps);

                        var run = new DocumentFormat.OpenXml.Wordprocessing.Run();
                        var runProps = new DocumentFormat.OpenXml.Wordprocessing.RunProperties
                        {
                            RunFonts = new DocumentFormat.OpenXml.Wordprocessing.RunFonts
                            {
                                Ascii = "Times New Roman",
                                HighAnsi = "Times New Roman"
                            },
                            FontSize = new DocumentFormat.OpenXml.Wordprocessing.FontSize
                            {
                                Val = "28" // 14 pt
                            }
                        };

                        run.Append(runProps);
                        run.Append(new DocumentFormat.OpenXml.Wordprocessing.Text(line)
                        {
                            Space = SpaceProcessingModeValues.Preserve
                        });

                        paragraph.Append(run);
                        body.Append(paragraph);
                    }

                    mainPart.Document.Save();
                }

                MessageBox.Show("Word-файл успешно сохранён.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Файл занят другим процессом:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPdf(List<string> lines, string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);

                // Создаём документ
                var document = new MigraDoc.DocumentObjectModel.Document();
                document.Info.Title = "Список литературы";

                var normal = document.Styles["Normal"];
                normal.Font.Name = "Times New Roman";
                normal.Font.Size = Unit.FromPoint(14);
                normal.ParagraphFormat.LineSpacingRule = LineSpacingRule.Multiple;
                normal.ParagraphFormat.LineSpacing = 1.5; // множитель
                normal.ParagraphFormat.FirstLineIndent = Unit.FromCentimeter(1.25); // 1.25 см
                normal.ParagraphFormat.SpaceBefore = 0;
                normal.ParagraphFormat.SpaceAfter = 0;
                normal.ParagraphFormat.Alignment = ParagraphAlignment.Justify;

                // Секция и параграфы
                var section = document.AddSection();
                foreach (var line in lines)
                {
                    var para = section.AddParagraph();
                    para.Style = "Normal";
                    para.AddText(line);
                }

                // Рендерим и сохраняем
                var renderer = new PdfDocumentRenderer
                {
                    Document = document
                };
                renderer.RenderDocument();
                renderer.PdfDocument.Save(filePath);

                MessageBox.Show("PDF-файл успешно сохранён.", "Готово",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Файл занят другим процессом:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWordExportResult_Click(object sender, EventArgs e)
        {
            var lines = lbResult.Items
                    .Cast<ResultItem<SavedEntry>>()  // приводим к нужному типу
                    .Select(ri => ri.Text)           // берём только текст
                    .ToList();

            if (lines.Count == 0)
            {
                MessageBox.Show(
                    "Список результатов пуст. Нечего экспортировать.",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = "Список литературы.docx"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ExportToWord(lines, dlg.FileName);
            }
        }

        private void buttonPDFExportResult_Click(object sender, EventArgs e)
        {
            var lines = lbResult.Items
                    .Cast<ResultItem<SavedEntry>>()  // приводим к нужному типу
                    .Select(ri => ri.Text)           // берём только текст
                    .ToList();

            if (lines.Count == 0)
            {
                MessageBox.Show(
                    "Список результатов пуст. Нечего экспортировать.",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "PDF Document (*.pdf)|*.pdf",
                FileName = "Список литературы.pdf"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(lines, dlg.FileName);
            }
        }

        private void buttonToGOST2018_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void GOST2008_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
