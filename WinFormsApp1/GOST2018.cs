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
    public partial class GOST2018 : Form
    {
        public GOST2018()
        {
            InitializeComponent();
            RegisterAllListBoxes(this);
        }
        private readonly UndoRedoListBoxManager _undoManager = new UndoRedoListBoxManager();

        private readonly Dictionary<TabPage, FormSnapshot> _initialSnapshots = new();

        internal enum SourceKind
        {
            // Однотомные
            SVBook,
            SVConference,
            SVGOST,
            SVLegislative,
            SVDissertationAbstract,
            SVDissertation,

            // Многотомные
            MVWhole,
            MVVolume,

            // Электронные ресурсы
            EBook,
            EWholeEdition,
            EVolumeEdition,
            EConferenceMaterials,
            ECollections,
            EJournalArticle,
            EMultimedia,
            EWebsite,

            // Составные части
            CPBookArticle,
            CPConferenceArticle,
            CPJournalArticle,
            CPNewspaperArticle,
            CPWebsiteArticle
        }


        internal sealed record SmartUi(
            Dictionary<string, List<string>> Dict,
            ListBox LbPlaces,
            ListBox LbPublishers,
            ListBox LbSelector,
            System.Windows.Forms.CheckBox CbSmartMode);

        private readonly Dictionary<SourceKind, SmartUi> _smartMap = new();

        private void GOST2018_Load(object sender, EventArgs e)
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


            lbSVBAuthors.Tag = cbSVBAuthors;
            lbMVWMAuthors.Tag = cbMVWMAuthors;
            lbMVSVAuthors.Tag = cbMVSVAuthors;
            lbEREbAuthors.Tag = cbEREbAuthors;
            lbERWEEAuthors.Tag = cbERWEEAuthors;
            lbEREESVAuthors.Tag = cbEREESVAuthors;
            lbEREjAAuthors.Tag = cbEREjAAuthors;
            lbERMEAuthors.Tag = cbERMEAuthors;
            lbCPBAArticleAuthors.Tag = cbCPBAArticleAuthors;
            lbCPBABookAuthors.Tag = cbCPBABookAuthors;
            lbCPCAArticleAuthors.Tag = cbCPCAArticleAuthors;
            lbCPCAConferenceAuthors.Tag = cbCPCAConferenceAuthors;
            lbCPJAArticleAuthors.Tag = cbCPJAArticleAuthors;
            lbCPWAArticleAuthors.Tag = cbCPWAArticleAuthors;

            // Привязка селекторов к основным ListBox мест издания (для UpdatePublishingLocationSelector)
            lbSVBPublishingLocation.Tag = lbSVBPublishingLocationSelect;
            lbMVWMPublishingLocation.Tag = lbMVWMPublishingLocationSelect;
            lbMVSVPublishingLocation.Tag = lbMVSVPublishingLocationSelect;
            lbEREbPublishingLocation.Tag = lbEREbPublishingLocationSelect;
            lbERWEEPublishingLocation.Tag = lbERWEEPublishingLocationSelect;
            lbEREESVPublishingLocation.Tag = lbEREESVPublishingLocationSelect;
            lbERECMPublishingLocation.Tag = lbERECMPublishingLocationSelect;
            lbERECPublishingLocation.Tag = lbERECPublishingLocationSelect;
            lbERMEPublishingLocation.Tag = lbERMEPublishingLocationSelect;
            lbSVGOSTPublishingLocation.Tag = lbSVGOSTPublishingLocationSelect;
            lbSVLMPublishingLocation.Tag = lbSVLMPublishingLocationSelect;
            lbERWPublishingLocation.Tag = lbERWPublishingLocationSelect;
            lbCPBAPublishingLocation.Tag = lbCPBAPublishingLocationSelect;
            lbCPCAPublishingLocation.Tag = lbCPCAPublishingLocationSelect;

            // Привязка издательств к своим местам издания (для GetDictionaryByListBox, drag'n'drop)
            lbSVBPublisher.Tag = lbSVBPublishingLocation;
            lbSVCMPublisher.Tag = lbSVCMPublishingLocation;
            lbSVGOSTPublisher.Tag = lbSVGOSTPublishingLocation;
            lbSVLMPublisher.Tag = lbSVLMPublishingLocation;
            lbMVWMPublisher.Tag = lbMVWMPublishingLocation;
            lbMVSVPublisher.Tag = lbMVSVPublishingLocation;
            lbEREbPublisher.Tag = lbEREbPublishingLocation;
            lbERWEEPublisher.Tag = lbERWEEPublishingLocation;
            lbEREESVPublisher.Tag = lbEREESVPublishingLocation;
            lbERECMPublisher.Tag = lbERECMPublishingLocation;
            lbERECPublisher.Tag = lbERECPublishingLocation;
            lbERMEPublisher.Tag = lbERMEPublishingLocation;
            lbERWPublisher.Tag = lbERWPublishingLocation;
            lbCPBAPublisher.Tag = lbCPBAPublishingLocationSelect;
            lbCPCAPublisher.Tag = lbCPCAPublishingLocationSelect;

            // Привязка текстбоксов к своим листбоксам
            tbSVBAuthors.Tag = lbSVBAuthors;
            tbSVBPublishingLocation.Tag = lbSVBPublishingLocation;
            tbSVBPublisher.Tag = lbSVBPublisher;
            tbSVBEditor.Tag = lbSVBEditor;
            tbSVCMPublishingLocation.Tag = lbSVCMPublishingLocation;
            tbSVCMPublisher.Tag = lbSVCMPublisher;
            tbSVCMEditor.Tag = lbSVCMEditor;
            tbSVGOSTPublishingLocation.Tag = lbSVGOSTPublishingLocation;
            tbSVGOSTPublisher.Tag = lbSVGOSTPublisher;
            tbSVLMPublishingLocation.Tag = lbSVLMPublishingLocation;
            tbSVLMPublisher.Tag = lbSVLMPublisher;
            tbMVWMAuthors.Tag = lbMVWMAuthors;
            tbMVWMPublishingLocation.Tag = lbMVWMPublishingLocation;
            tbMVWMPublisher.Tag = lbMVWMPublisher;
            tbMVWMEditor.Tag = lbMVWMEditor;
            tbMVSVAuthors.Tag = lbMVSVAuthors;
            tbMVSVPublishingLocation.Tag = lbMVSVPublishingLocation;
            tbMVSVPublisher.Tag = lbMVSVPublisher;
            tbMVSVEditor.Tag = lbMVSVEditor;
            tbEREbAuthors.Tag = lbEREbAuthors;
            tbEREbPublishingLocation.Tag = lbEREbPublishingLocation;
            tbEREbPublisher.Tag = lbEREbPublisher;
            tbEREbEditor.Tag = lbEREbEditor;
            tbERWEEAuthors.Tag = lbERWEEAuthors;
            tbERWEEPublishingLocation.Tag = lbERWEEPublishingLocation;
            tbERWEEPublisher.Tag = lbERWEEPublisher;
            tbERWEEEditor.Tag = lbERWEEEditor;
            tbEREESVAuthors.Tag = lbEREESVAuthors;
            tbEREESVPublishingLocation.Tag = lbEREESVPublishingLocation;
            tbEREESVPublisher.Tag = lbEREESVPublisher;
            tbEREESVEditor.Tag = lbEREESVEditor;
            tbERECMEditorialBoard.Tag = lbERECMEditorialBoard;
            tbERECMEditor.Tag = lbERECMEditor;
            tbERECMPublishingLocation.Tag = lbERECMPublishingLocation;
            tbERECMPublisher.Tag = lbERECMPublisher;
            tbERECEditorialBoard.Tag = lbERECEditorialBoard;
            tbERECEditor.Tag = lbERECEditor;
            tbERECPublishingLocation.Tag = lbERECPublishingLocation;
            tbERECPublisher.Tag = lbERECPublisher;
            tbEREjAAuthors.Tag = lbEREjAAuthors;
            tbERMEAuthors.Tag = lbERMEAuthors;
            tbERMEPublishingLocation.Tag = lbERMEPublishingLocation;
            tbERMEPublisher.Tag = lbERMEPublisher;
            tbERWPublishingLocation.Tag = lbERWPublishingLocation;
            tbERWPublisher.Tag = lbERWPublisher;
            tbCPBAArticleAuthors.Tag = lbCPBAArticleAuthors;
            tbCPBABookAuthors.Tag = lbCPBABookAuthors;
            tbCPBAPublishingLocation.Tag = lbCPBAPublishingLocation;
            tbCPBAPublisher.Tag = lbCPBAPublisher;
            tbCPCAArticleAuthors.Tag = lbCPCAArticleAuthors;
            tbCPCAConferenceAuthors.Tag = lbCPCAConferenceAuthors;
            tbCPCAEditor.Tag = lbCPCAEditor;
            tbCPCAPublishingLocation.Tag = lbCPCAPublishingLocation;
            tbCPCAPublisher.Tag = lbCPCAPublisher;
            tbCPJAArticleAuthors.Tag = lbCPJAArticleAuthors;
            tbCPNAArticleAuthors.Tag = lbCPNAArticleAuthors;
            tbCPWAArticleAuthors.Tag = lbCPWAArticleAuthors;


            UpdateListCheckBox(lbSVBAuthors, 1, 5);
            UpdateListCheckBox(lbMVWMAuthors, 1, 5);
            UpdateListCheckBox(lbMVSVAuthors, 1, 5);
            UpdateListCheckBox(lbEREbAuthors, 1, 5);
            UpdateListCheckBox(lbERWEEAuthors, 1, 5);
            UpdateListCheckBox(lbEREESVAuthors, 1, 5);
            UpdateListCheckBox(lbEREjAAuthors, 1, 5);
            UpdateListCheckBox(lbERMEAuthors, 1, 5);
            UpdateListCheckBox(lbCPBAArticleAuthors, 1, 5);
            UpdateListCheckBox(lbCPBABookAuthors, 1, 5);
            UpdateListCheckBox(lbCPCAArticleAuthors, 1, 5);
            UpdateListCheckBox(lbCPCAConferenceAuthors, 1, 5);
            UpdateListCheckBox(lbCPJAArticleAuthors, 1, 5);
            UpdateListCheckBox(lbCPWAArticleAuthors, 1, 5);

            // ───────── однотомные ─────────
            _smartMap[SourceKind.SVBook] = new SmartUi(
                groupedPublishersSVBook,
                lbSVBPublishingLocation,
                lbSVBPublisher,
                lbSVBPublishingLocationSelect,
                cbSVBPublisher);

            _smartMap[SourceKind.SVConference] = new SmartUi(
                groupedPublishersSVConferenceMaterials,
                lbSVCMPublishingLocation,
                lbSVCMPublisher,
                lbSVCMPublishingLocationSelect,
                cbSVCMPublisher);

            _smartMap[SourceKind.SVGOST] = new SmartUi(
                groupedPublishersSVGOST,
                lbSVGOSTPublishingLocation,
                lbSVGOSTPublisher,
                lbSVGOSTPublishingLocationSelect,
                cbSVGOSTPublisher);

            _smartMap[SourceKind.SVLegislative] = new SmartUi(
                groupedPublishersSVLegislativeMaterial,
                lbSVLMPublishingLocation,
                lbSVLMPublisher,
                lbSVLMPublishingLocationSelect,
                cbSVLMPublisher);

            // ───────── многотомные ─────────
            _smartMap[SourceKind.MVWhole] = new SmartUi(
                groupedPublishersMVWholeMultivolume,
                lbMVWMPublishingLocation,
                lbMVWMPublisher,
                lbMVWMPublishingLocationSelect,
                cbMVWMPublisher);

            _smartMap[SourceKind.MVVolume] = new SmartUi(
                groupedPublishersMVSeparateVolume,
                lbMVSVPublishingLocation,
                lbMVSVPublisher,
                lbMVSVPublishingLocationSelect,
                cbMVSVPublisher);

            // ───────── электронные ─────────
            _smartMap[SourceKind.EBook] = new SmartUi(
                groupedPublishersEREbook,
                lbEREbPublishingLocation,
                lbEREbPublisher,
                lbEREbPublishingLocationSelect,
                cbEREbPublisher);

            _smartMap[SourceKind.EWholeEdition] = new SmartUi(
                groupedPublishersERWholeElectronicEdition,
                lbERWEEPublishingLocation,
                lbERWEEPublisher,
                lbERWEEPublishingLocationSelect,
                cbERWEEPublisher);

            _smartMap[SourceKind.EVolumeEdition] = new SmartUi(
                groupedPublishersERElectronicEditionSeparateVolume,
                lbEREESVPublishingLocation,
                lbEREESVPublisher,
                lbEREESVPublishingLocationSelect,
                cbEREESVPublisher);

            _smartMap[SourceKind.EConferenceMaterials] = new SmartUi(
                groupedPublishersERElectronicConferenceMaterials,
                lbERECMPublishingLocation,
                lbERECMPublisher,
                lbERECMPublishingLocationSelect,
                cbERECMPublisher);

            _smartMap[SourceKind.ECollections] = new SmartUi(
                groupedPublishersERElectronicCollections,
                lbERECPublishingLocation,
                lbERECPublisher,
                lbERECPublishingLocationSelect,
                cbERECPublisher);

            _smartMap[SourceKind.EMultimedia] = new SmartUi(
                groupedPublishersERMultimediaEdition,
                lbERMEPublishingLocation,
                lbERMEPublisher,
                lbERMEPublishingLocationSelect,
                cbERMEPublisher);

            _smartMap[SourceKind.EWebsite] = new SmartUi(
                groupedPublishersERWebsite,
                lbERWPublishingLocation,
                lbERWPublisher,
                lbERWPublishingLocationSelect,
                cbERWPublisher);

            // ───────── составные части ─────────
            _smartMap[SourceKind.CPBookArticle] = new SmartUi(
                groupedPublishersCPBookArticle,
                lbCPBAPublishingLocation,
                lbCPBAPublisher,
                lbCPBAPublishingLocationSelect,
                cbCPBAPublisher);

            _smartMap[SourceKind.CPConferenceArticle] = new SmartUi(
                groupedPublishersCPConferenceArticle,
                lbCPCAPublishingLocation,
                lbCPCAPublisher,
                lbCPCAPublishingLocationSelect,
                cbCPCAPublisher);

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

        private Dictionary<string, List<string>> groupedPublishersSVBook = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersSVConferenceMaterials = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersSVGOST = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersSVLegislativeMaterial = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersMVWholeMultivolume = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersMVSeparateVolume = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersEREbook = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERWholeElectronicEdition = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERElectronicEditionSeparateVolume = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERElectronicConferenceMaterials = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERElectronicCollections = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERMultimediaEdition = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersERWebsite = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersCPBookArticle = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> groupedPublishersCPConferenceArticle = new Dictionary<string, List<string>>();

        //
        // ------------------------- СЛОВАРЬ СОКРАЩЕНИЙ ----------------------------
        //
        Dictionary<string, string> abbreviations = new Dictionary<string, string>
        {
            { "автор", "авт." },
            { "автор и составитель", "авт. и сост." },
            { "автореферат", "автореф." },
            { "академия", "акад." },
            { "аналитический", "аналит." },
            { "английский", "англ." },
            { "аннотация", "аннот." },
            { "библиография", "библиогр." },
            { "бюллетень", "бюл." },
            { "[и другие]", "[и др.]" },
            { "издание 4-е, исправленное", "изд. 4-е, испр." },
            { "издательство", "изд-во" },
            { "институт", "ин-т" },
            { "информационный", "информ." },
            { "исторический", "ист." },
            { "кандидат", "канд." },
            { "конференция", "конф." },
            { "министерство", "м-во" },
            { "монография", "моногр." },
            { "научный", "науч." },
            { "немецкий", "нем." },
            { "областной", "обл." },
            { "ответственный", "отв." },
            { "ответственный редактор", "отв. ред." },
            { "официальный текст", "офиц. текст" },
            { "перевод", "пер." },
            { "перевод с английского", "пер. с англ." },
            { "переводчик", "пер." },
            { "переиздание", "переизд." },
            { "под редакцией", "под ред." },
            { "популярный", "попул." },
            { "посвященный", "посвящ." },
            { "приложение", "прил." },
            { "редактор", "ред." },
            { "редакционная коллегия", "редкол." },
            { "редакция", "ред." },
            { "русский", "рус." },
            { "сборник", "сб." },
            { "серия", "сер." },
            { "словарь", "слов." },
            { "собрание", "собр." },
            { "составитель", "сост." },
            { "справочник", "справ." },
            { "справочное пособие", "справ. пособие" },
            { "тематический", "темат." },
            { "том", "т." },
            { "университет", "ун-т" },
            { "утвержден", "утв." },
            { "учебное пособие", "учеб. пособие" },
            { "учебно-методическое пособие", "учеб.-метод. пособие" },
            { "федеральный закон", "федер. закон" },
            { "французский", "фр." },
            { "часть", "ч." },
            { "экономических", "экон." },
            { "энциклопедия", "энцикл." },
            { "язык", "яз." },
            { "Автор", "авт." },
            { "Автор и составитель", "авт. и сост." },
            { "Автореферат", "автореф." },
            { "Академия", "акад." },
            { "Аналитический", "аналит." },
            { "Английский", "англ." },
            { "Аннотация", "аннот." },
            { "Библиография", "библиогр." },
            { "Бюллетень", "бюл." },
            { "[И другие]", "[и др.]" },
            { "Издание 4-е, исправленное", "изд. 4-е, испр." },
            { "Издательство", "изд-во" },
            { "Институт", "ин-т" },
            { "Информационный", "информ." },
            { "Исторический", "ист." },
            { "Кандидат", "канд." },
            { "Конференция", "конф." },
            { "Министерство", "м-во" },
            { "Монография", "моногр." },
            { "Научный", "науч." },
            { "Немецкий", "нем." },
            { "Областной", "обл." },
            { "Ответственный", "отв." },
            { "Ответственный редактор", "отв. ред." },
            { "Официальный текст", "офиц. текст" },
            { "Перевод", "пер." },
            { "Перевод с английского", "пер. с англ." },
            { "Переводчик", "пер." },
            { "Переиздание", "переизд." },
            { "Под редакцией", "под ред." },
            { "Популярный", "попул." },
            { "Посвященный", "посвящ." },
            { "Приложение", "прил." },
            { "Редактор", "ред." },
            { "Редакционная коллегия", "редкол." },
            { "Редакция", "ред." },
            { "Русский", "рус." },
            { "Сборник", "сб." },
            { "Серия", "сер." },
            { "Словарь", "слов." },
            { "Собрание", "собр." },
            { "Составитель", "сост." },
            { "Справочник", "справ." },
            { "Справочное пособие", "справ. пособие" },
            { "Тематический", "темат." },
            { "Том", "т." },
            { "Университет", "ун-т" },
            { "Утвержден", "утв." },
            { "Учебное пособие", "учеб. пособие" },
            { "Учебно-методическое пособие", "учеб.-метод. пособие" },
            { "Федеральный закон", "федер. закон" },
            { "Французский", "фр." },
            { "Часть", "ч." },
            { "Экономических", "экон." },
            { "Энциклопедия", "энцикл." },
            { "Язык", "яз." }
        };

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

            // 1. Извлекаем перетаскиваемый элемент
            object dragItem = e.Data.GetData(typeof(ResultItem<SavedEntry>))
                           ?? e.Data.GetData(typeof(string));
            if (dragItem == null)
                return;

            // 2. Старый индекс
            int oldIndex = lb.Items.IndexOf(dragItem);
            if (oldIndex < 0)
                return;

            // 3. Новый индекс по позиции мыши
            Point pt = lb.PointToClient(new Point(e.X, e.Y));
            int rawIndex = lb.IndexFromPoint(pt);
            if (rawIndex < 0 || rawIndex > lb.Items.Count)
                rawIndex = lb.Items.Count;

            int newIndex = rawIndex > oldIndex ? rawIndex - 1 : rawIndex;
            if (newIndex == oldIndex)
                return; // ничто не меняем

            // Для списка результатов заранее запоминаем, какой _entries элемент перемещаем
            SavedEntry? movedEntry = null;
            if (lb == lbResult)
                movedEntry = _entries[oldIndex];

            // 4. Выполняем Do/Undo через UndoRedoManager
            _undoManager.Execute(
                lb,
                // --- Do: удаляем и вставляем в обе коллекции
                () =>
                {
                    // ListBox.Items
                    lb.Items.RemoveAt(oldIndex);
                    lb.Items.Insert(newIndex, dragItem);
                    lb.SelectedIndex = newIndex;

                    // _entries
                    if (lb == lbResult && movedEntry != null)
                    {
                        _entries.RemoveAt(oldIndex);
                        _entries.Insert(newIndex, movedEntry);
                        RefreshRestoreButtons();
                    }
                },
                // --- Undo: находим текущие позиции по объекту и возвращаем обратно
                () =>
                {
                    // В ListBox.Items ищем dragItem
                    int idxInList = lb.Items.IndexOf(dragItem);
                    if (idxInList >= 0)
                    {
                        lb.Items.RemoveAt(idxInList);
                        lb.Items.Insert(oldIndex, dragItem);
                        lb.SelectedIndex = oldIndex;
                    }

                    // В _entries ищем movedEntry
                    if (lb == lbResult && movedEntry != null)
                    {
                        int idxInEntries = _entries.IndexOf(movedEntry);
                        if (idxInEntries >= 0)
                        {
                            _entries.RemoveAt(idxInEntries);
                            _entries.Insert(oldIndex, movedEntry);
                            RefreshRestoreButtons();
                        }
                    }
                }
            );

            // 5. Дополнительная логика для других ListBox
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
                sb.Append(' ').Append(i2[0]).Append('.');

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
                : $"{i1} {i2} {s}";
        }

        // Метод, который гарантирует, что после фамилии вставлена запятая,
        // если её нет во входной строке (например, преобразует "Дорман В. Н." в "Дорман, В. Н.").
        private string EnsureComma(string author)
        {
            if (author.Contains(','))           // Запятая уже есть — ничего не трогаем
                return author.Trim();

            var m = SurnameInitialsRegex.Match(author);
            if (!m.Success)                     // Не тот формат — вернуть как есть
                return author;

            string fam = m.Groups["surname"].Value;
            string i1 = m.Groups["i1"].Value.Trim();
            string i2 = m.Groups["i2"].Value.Trim();

            return string.IsNullOrEmpty(i2)
                ? $"{fam}, {i1}".Trim()
                : $"{fam}, {i1} {i2}".Trim();
        }

        // Преобразование полного имени в формат "Фамилия Инициалы"
        public static string ToSurnameWithInitials(string fullName)
        {
            var regex = new Regex(
                @"^\s*" +
                @"(?<surname>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)\s+" +
                @"(?<name>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+)" +
                @"(?:\s+(?<patr>[A-ZА-ЯЁ][A-Za-zА-Яа-яЁё]+))?" +
                @"\s*$",
                RegexOptions.Compiled);

            var m = regex.Match(fullName);
            if (!m.Success)                     // Не узнаётся — вернуть пустую строку
                return string.Empty;

            string fam = m.Groups["surname"].Value;
            string nIni = m.Groups["name"].Value.Substring(0, 1);
            string pIni = m.Groups["patr"].Success
                            ? m.Groups["patr"].Value.Substring(0, 1)
                            : null;

            return pIni == null
                ? $"{fam} {nIni}."
                : $"{fam} {nIni}. {pIni}.";
        }

        // Связь мест издания и издателей через ":"
        private string CombinePlacesAndPublishers(List<string> places, List<string> publishers)
        {
            List<string> combined = new List<string>();

            for (int i = 0; i < places.Count; i++)
            {
                string place = places[i];
                string publisher = (i < publishers.Count) ? publishers[i] : null;

                if (!string.IsNullOrEmpty(publisher))
                    combined.Add($"{place} : {publisher}");
                else
                    combined.Add(place);
            }

            return string.Join(" ; ", combined);
        }

        // Умный режим связи мест издания и издательств (когда у места издания несколько издательств)
        private string CombinePlacesAndGroupedPublishers(List<string> places, Dictionary<string, List<string>> groupedPublishers)
        {
            List<string> result = new List<string>();

            foreach (string place in places)
            {
                if (groupedPublishers.TryGetValue(place, out var publishers) && publishers.Count > 0)
                    result.Add(place + " : " + string.Join(" : ", publishers));
                else
                    result.Add(place); // Добавляем даже если издательств нет
            }

            return string.Join(" ; ", result);
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
            if (lb == lbSVBPublishingLocation || lb == lbSVBPublisher) return groupedPublishersSVBook;
            if (lb == lbSVCMPublishingLocation || lb == lbSVCMPublisher) return groupedPublishersSVConferenceMaterials;
            if (lb == lbSVGOSTPublishingLocation || lb == lbSVGOSTPublisher) return groupedPublishersSVGOST;
            if (lb == lbSVLMPublishingLocation || lb == lbSVLMPublisher) return groupedPublishersSVLegislativeMaterial;
            if (lb == lbMVWMPublishingLocation || lb == lbMVWMPublisher) return groupedPublishersMVWholeMultivolume;
            if (lb == lbMVSVPublishingLocation || lb == lbMVSVPublisher) return groupedPublishersMVSeparateVolume;
            if (lb == lbEREbPublishingLocation || lb == lbEREbPublisher) return groupedPublishersEREbook;
            if (lb == lbERWEEPublishingLocation || lb == lbERWEEPublisher) return groupedPublishersERWholeElectronicEdition;
            if (lb == lbEREESVPublishingLocation || lb == lbEREESVPublisher) return groupedPublishersERElectronicEditionSeparateVolume;
            if (lb == lbERECMPublishingLocation || lb == lbERECMPublisher) return groupedPublishersERElectronicConferenceMaterials;
            if (lb == lbERECPublishingLocation || lb == lbERECPublisher) return groupedPublishersERElectronicCollections;
            if (lb == lbERMEPublishingLocation || lb == lbERMEPublisher) return groupedPublishersERMultimediaEdition;
            if (lb == lbERWPublishingLocation || lb == lbERWPublisher) return groupedPublishersERWebsite;

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

        private string ApplyAbbreviations(string text)
        {
            if (!cbWordAbbreviation.Checked)
                return text;

            foreach (var kvp in abbreviations
                               .OrderByDescending(k => k.Key.Length))
            {
                string key = kvp.Key;
                string repl = kvp.Value;

                // Проверяем, чем начинается/заканчивается ключ
                bool startsWithLetter = char.IsLetterOrDigit(key[0]);
                bool endsWithLetter = char.IsLetterOrDigit(key[^1]);

                // Ставим \b только возле буквенно‑цифровых границ
                string pattern =
                    $"{(startsWithLetter ? @"\b" : "")}" +
                    Regex.Escape(key) +
                    $"{(endsWithLetter ? @"\b" : "")}";

                text = Regex.Replace(text, pattern, m =>
                {
                    // Сохраняем заглавность первой буквы, если в оригинале она была
                    bool firstIsUpper = char.IsUpper(m.Value
                                                        .First(c => char.IsLetter(c)));
                    string r = repl;

                    return firstIsUpper
                        ? char.ToUpper(r[0]) + r[1..]
                        : r;

                }, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            }

            return text;
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
            // ── Однотомные ──
            if (tcCategories.SelectedTab == tpSingleVolume)
            {
                if (tcSVTypes.SelectedTab == tpSVBook) return SourceKind.SVBook;
                if (tcSVTypes.SelectedTab == tpSVConferenceMaterials) return SourceKind.SVConference;
                if (tcSVTypes.SelectedTab == tpSVGOST) return SourceKind.SVGOST;
                if (tcSVTypes.SelectedTab == tpSVLegislativeMaterial) return SourceKind.SVLegislative;
                if (tcSVTypes.SelectedTab == tpSVDissertationAbstract) return SourceKind.SVDissertationAbstract;
                if (tcSVTypes.SelectedTab == tpSVDissertation) return SourceKind.SVDissertation;
            }
            // ── Многотомные ──
            else if (tcCategories.SelectedTab == tpMultiVolume)
            {
                if (tcMVTypes.SelectedTab == tpMVWholeMultivolume) return SourceKind.MVWhole;
                if (tcMVTypes.SelectedTab == tpMVSeparateVolume) return SourceKind.MVVolume;
            }
            // ── Электронные ресурсы ──
            else if (tcCategories.SelectedTab == tpElectronicResources)
            {
                if (tcERTypes.SelectedTab == tpEREbook) return SourceKind.EBook;
                if (tcERTypes.SelectedTab == tpERWholeElectronicEdition) return SourceKind.EWholeEdition;
                if (tcERTypes.SelectedTab == tpERElectronicEditionSeparateVolume) return SourceKind.EVolumeEdition;
                if (tcERTypes.SelectedTab == tpERElectronicConferenceMaterials) return SourceKind.EConferenceMaterials;
                if (tcERTypes.SelectedTab == tpERElectronicCollections) return SourceKind.ECollections;
                if (tcERTypes.SelectedTab == tpEREjournalArticle) return SourceKind.EJournalArticle;
                if (tcERTypes.SelectedTab == tpERMultimediaEdition) return SourceKind.EMultimedia;
                if (tcERTypes.SelectedTab == tpERWebsite) return SourceKind.EWebsite;
            }
            // ── Составные части ──
            else if (tcCategories.SelectedTab == tpConstituentParts)
            {
                if (tcCPTypes.SelectedTab == tpCPBookArticle) return SourceKind.CPBookArticle;
                if (tcCPTypes.SelectedTab == tpCPConferenceArticle) return SourceKind.CPConferenceArticle;
                if (tcCPTypes.SelectedTab == tpCPJournalArticle) return SourceKind.CPJournalArticle;
                if (tcCPTypes.SelectedTab == tpCPNewspaperArticle) return SourceKind.CPNewspaperArticle;
                if (tcCPTypes.SelectedTab == tpCPWebsiteArticle) return SourceKind.CPWebsiteArticle;
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
        // ------------------------- КАТЕГОРИЯ "ОДНОЧАСТНЫЕ (ОДНОТОМНЫЕ) РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "КНИГА" ----------------------------

        private void buttonSVBAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBAuthors, lbSVBAuthors);
        }

        private void buttonSVBPublishingLocationAdd_Click(Object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBPublishingLocation, lbSVBPublishingLocation);
            UpdatePublishingLocationSelector(lbSVBPublishingLocation, lbSVBPublishingLocationSelect);
        }

        private void buttonSVBPublisherAdd_Click(Object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbSVBPublisher,
                lbSVBPublisher,
                cbSVBPublisher.Checked,
                lbSVBPublishingLocationSelect,
                groupedPublishersSVBook
            );
        }

        private void buttonSVBEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVBEditor, lbSVBEditor);
        }

        private void cbSVBPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbSVBPublisher.Checked,
                lbSVBPublisher,
                lbSVBPublishingLocationSelect,
                groupedPublishersSVBook
            );
        }

        private void lbSVBPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbSVBPublisher,
                lbSVBPublishingLocationSelect,
                groupedPublishersSVBook
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessBook()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbSVBAuthors);
            List<string> places = GetStringsList(lbSVBPublishingLocation);
            List<string> publishers = GetStringsList(lbSVBPublisher);
            List<string> editors = GetStringsList(lbSVBEditor);

            string title = tbSVBTitle.Text.Trim();
            string parallelTitle = tbSVBParallelTitle.Text.Trim();
            string year = tbSVBPublishYear.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Название»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbSVBPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbSVBPublisher.Checked && groupedPublishersSVBook.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string docType = tbSVBDocumentType.Text.Trim();
            string editionNumber = tbSVBEditionNumber.Text.Trim();
            string pages = tbSVBPagesCount.Text.Trim();
            string series = tbSVBSeries.Text.Trim();
            string isbn = tbSVBISBN.Text.Trim();
            string translator = tbSVBTranslator.Text.Trim();
            string organization = tbSVBOrganization.Text.Trim();
            string contentType = tbSVBContentType.Text.Trim();
            string editorType = cbSVBEditorType.SelectedItem?.ToString()?.Trim('"').Trim();

            string fullTitle = string.IsNullOrEmpty(parallelTitle)
                ? title
                : $"{title} = {parallelTitle}";

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string titleAndAuthors;
            if (cbSVBAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = string.IsNullOrEmpty(docType)
                    ? $"{fullTitle} / {firstThree} [и другие]"
                    : $"{fullTitle} : {docType} / {firstThree} [и другие]";
            }
            else
            {
                if (countA == 1)
                {
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{authorsWithComma[0]} {fullTitle} / {reversedAuthors[0]}"
                        : $"{authorsWithComma[0]} {fullTitle} : {docType} / {reversedAuthors[0]}";
                }
                else if (countA == 2 || countA == 3)
                {
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{authorsWithComma[0]} {fullTitle} / {allRev}"
                        : $"{authorsWithComma[0]} {fullTitle} : {docType} / {allRev}";
                }
                else if (countA == 4)
                {
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} / {allRev}"
                        : $"{fullTitle} : {docType} / {allRev}";
                }
                else if (countA >= 5)
                {
                    string firstThree = string.Join(", ", reversedAuthors.Take(3));
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} / {firstThree} [и другие]"
                        : $"{fullTitle} : {docType} / {firstThree} [и другие]";
                }
                else
                {
                    titleAndAuthors = fullTitle;
                }
            }

            string editorsJoined = string.Join(", ", editors);
            string responsibilityBlock = "";
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
            {
                responsibilityBlock = !string.IsNullOrEmpty(responsibilityBlock)
                    ? $"{responsibilityBlock} ; {organization}"
                    : organization;
            }

            string firstBlock = string.IsNullOrEmpty(responsibilityBlock)
                ? titleAndAuthors
                : $"{titleAndAuthors} ; {responsibilityBlock}";

            string editionTranslation = "";
            if (!string.IsNullOrEmpty(editionNumber) && !string.IsNullOrEmpty(translator))
                editionTranslation = $"{editionNumber} ; перевод с {translator}";
            else if (!string.IsNullOrEmpty(editionNumber))
                editionTranslation = editionNumber;
            else if (!string.IsNullOrEmpty(translator))
                editionTranslation = $"перевод с {translator}";

            string imprint = cbSVBPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersSVBook)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string contBlock = string.IsNullOrEmpty(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            if (!string.IsNullOrEmpty(firstBlock)) blocks.Add(firstBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(editionTranslation)) blocks.Add(editionTranslation.TrimEnd('.'));
            if (!string.IsNullOrEmpty(imprint)) blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(contBlock)) blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbSVBAuthors.Items.Clear();
                lbSVBPublishingLocation.Items.Clear();
                lbSVBPublisher.Items.Clear();
                lbSVBEditor.Items.Clear();
                lbSVBPublishingLocationSelect.Items.Clear();
                tbSVBTitle.Clear();
                tbSVBParallelTitle.Clear();
                tbSVBPublishYear.Clear();
                tbSVBPagesCount.Clear();
                tbSVBDocumentType.Clear();
                tbSVBEditor.Clear();
                tbSVBEditionNumber.Clear();
                tbSVBSeries.Clear();
                tbSVBISBN.Clear();
                tbSVBTranslator.Clear();
                tbSVBOrganization.Clear();
                tbSVBContentType.Clear();
                groupedPublishersSVBook.Clear();
                cbSVBPublisher.Checked = false;
                UpdateListCheckBox(lbSVBAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "МАТЕРИАЛЫ КОНФЕРЕНЦИИ" ----------------------------

        private void buttonSVCPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVCMPublishingLocation, lbSVCMPublishingLocation);
            UpdatePublishingLocationSelector(lbSVCMPublishingLocation, lbSVCMPublishingLocationSelect);
        }

        private void buttonSVCPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbSVCMPublisher,
                lbSVCMPublisher,
                cbSVCMPublisher.Checked,
                lbSVCMPublishingLocationSelect,
                groupedPublishersSVConferenceMaterials
            );
        }

        private void cbSVCMPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbSVCMPublisher.Checked,
                lbSVCMPublisher,
                lbSVCMPublishingLocationSelect,
                groupedPublishersSVConferenceMaterials
            );
        }

        private void lbSVCMPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbSVCMPublisher,
                lbSVCMPublishingLocationSelect,
                groupedPublishersSVConferenceMaterials
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonSVCEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVCMEditor, lbSVCMEditor);
        }

        private void ProcessConferenceMaterials()
        {
            List<string> errors = new List<string>();
            List<string> editors = GetStringsList(lbSVCMEditor);
            List<string> places = GetStringsList(lbSVCMPublishingLocation);
            List<string> publishers = GetStringsList(lbSVCMPublisher);

            string eventTitle = tbSVCMEventTitle.Text.Trim();
            string publicationType = tbSVCMPublicationType.Text.Trim();
            string eventPlace = tbSVCMEventPlace.Text.Trim();
            string eventDate = tbSVCMEventDate.Text.Trim();
            string partCount = tbSVCMPartCount.Text.Trim();
            string partNumberAndTitle = tbSVCMPartNumberAndTitle.Text.Trim();
            string year = tbSVCMPublishYear.Text.Trim();
            string pages = tbSVCMPagesCount.Text.Trim();
            string isbn = tbSVCMISBN.Text.Trim();
            string contentType = tbSVCMContentType.Text.Trim();
            string editorType = cbSVCMEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            if (string.IsNullOrEmpty(eventTitle)) errors.Add("Не заполнено поле «Название мероприятия»");
            if (string.IsNullOrEmpty(publicationType)) errors.Add("Не заполнено поле «Вид издания»");
            if (string.IsNullOrEmpty(eventPlace)) errors.Add("Не заполнено поле «Город проведения»");
            if (string.IsNullOrEmpty(eventDate)) errors.Add("Не заполнено поле «Дата проведения»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!cbSVCMPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbSVCMPublisher.Checked && groupedPublishersSVConferenceMaterials.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string editorsJoined = string.Join(", ", editors);
            string responsibilityBlock = "";

            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            string partBlock = "";
            if (!string.IsNullOrEmpty(partCount)) partBlock += $"в {partCount} ч.";
            if (!string.IsNullOrEmpty(partNumberAndTitle)) partBlock += (partBlock != "" ? " " : "") + partNumberAndTitle;
            if (!string.IsNullOrEmpty(responsibilityBlock)) partBlock += $" / {responsibilityBlock}";

            string eventBlock = $"{eventTitle} : {publicationType}, {eventPlace}, {eventDate}";
            if (!string.IsNullOrEmpty(partBlock)) eventBlock += $" : {partBlock}";

            string imprint = cbSVCMPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersSVConferenceMaterials)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string isbnBlock = string.IsNullOrWhiteSpace(isbn) ? "" : $"ISBN {isbn}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            if (!string.IsNullOrEmpty(eventBlock)) blocks.Add(eventBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(imprint)) blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(contBlock)) blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbSVCMEventTitle.Clear();
                tbSVCMPublicationType.Clear();
                tbSVCMEventPlace.Clear();
                tbSVCMEventDate.Clear();
                tbSVCMPartCount.Clear();
                tbSVCMPartNumberAndTitle.Clear();
                tbSVCMPublishYear.Clear();
                tbSVCMPagesCount.Clear();
                tbSVCMISBN.Clear();
                tbSVCMContentType.Clear();
                lbSVCMEditor.Items.Clear();
                lbSVCMPublishingLocation.Items.Clear();
                groupedPublishersSVConferenceMaterials.Clear();
                lbSVCMPublisher.Items.Clear();
                lbSVCMPublishingLocationSelect.Items.Clear();
                cbSVCMPublisher.Checked = false;
            }
        }


        // ------------------------- ТИП "ГОСТ" ----------------------------

        private void buttonSVGOSTPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVGOSTPublishingLocation, lbSVGOSTPublishingLocation);
            UpdatePublishingLocationSelector(lbSVGOSTPublishingLocation, lbSVGOSTPublishingLocationSelect);
        }

        private void buttonSVGOSTPublisher_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbSVGOSTPublisher,
                lbSVGOSTPublisher,
                cbSVGOSTPublisher.Checked,
                lbSVGOSTPublishingLocationSelect,
                groupedPublishersSVGOST
            );
        }

        private void cbSVGOSTPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbSVGOSTPublisher.Checked,
                lbSVGOSTPublisher,
                lbSVGOSTPublishingLocationSelect,
                groupedPublishersSVGOST
            );
        }

        private void lbSVGOSTPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbSVGOSTPublisher,
                lbSVGOSTPublishingLocationSelect,
                groupedPublishersSVGOST
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessGOST()
        {
            List<string> errors = new List<string>();

            List<string> places = GetStringsList(lbSVGOSTPublishingLocation);
            List<string> publishers = GetStringsList(lbSVGOSTPublisher);

            string docNumber = tbSVGOSTDocumentNumber.Text.Trim();
            string title = tbSVGOSTTitle.Text.Trim();
            string parallelTitle = tbSVGOSTParallelTitle.Text.Trim();
            string docType = tbSVGOSTDocumentType.Text.Trim();
            string additions = tbSVGOSTAdditions.Text.Trim();
            string approval = tbSVGOSTApprovalDate.Text.Trim();
            bool introduced = cbGOSTFirstTime.Checked;
            string implementDate = tbSVGOSTImplementDate.Text.Trim();
            string developer = tbSVGOSTDeveloper.Text.Trim();
            string year = tbSVGOSTPublishYear.Text.Trim();
            string pages = tbSVGOSTPagesCount.Text.Trim();
            string contentType = tbSVGOSTContentType.Text.Trim();

            if (string.IsNullOrWhiteSpace(docNumber)) errors.Add("Не заполнено поле «Номер документа»");
            if (string.IsNullOrWhiteSpace(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbSVGOSTPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbSVGOSTPublisher.Checked && groupedPublishersSVGOST.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrWhiteSpace(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titleBlock = $"{docNumber}. {title}";
            if (!string.IsNullOrWhiteSpace(parallelTitle)) titleBlock += $" = {parallelTitle}";

            List<string> exts = new List<string>();
            if (!string.IsNullOrWhiteSpace(docType)) exts.Add(docType);
            if (!string.IsNullOrWhiteSpace(additions)) exts.Add(additions);
            if (!string.IsNullOrWhiteSpace(approval)) exts.Add(approval);
            if (introduced) exts.Add("введен впервые");
            if (!string.IsNullOrWhiteSpace(implementDate)) exts.Add($"дата введения {implementDate}");

            if (exts.Count > 0)
                titleBlock += " : " + string.Join(" : ", exts);

            if (!string.IsNullOrWhiteSpace(developer))
                titleBlock += $" / разработан {developer}";

            string imprint = cbSVGOSTPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersSVGOST)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleBlock.TrimEnd('.'));
            blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(contBlock)) blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbSVGOSTDocumentNumber.Clear();
                tbSVGOSTTitle.Clear();
                tbSVGOSTParallelTitle.Clear();
                tbSVGOSTDocumentType.Clear();
                tbSVGOSTAdditions.Clear();
                tbSVGOSTApprovalDate.Clear();
                cbGOSTFirstTime.Checked = false;
                tbSVGOSTImplementDate.Clear();
                tbSVGOSTDeveloper.Clear();
                tbSVGOSTPublishYear.Clear();
                tbSVGOSTPagesCount.Clear();
                tbSVGOSTContentType.Clear();
                lbSVGOSTPublishingLocation.Items.Clear();
                lbSVGOSTPublisher.Items.Clear();
                lbSVGOSTPublishingLocationSelect.Items.Clear();
                groupedPublishersSVGOST.Clear();
                cbSVGOSTPublisher.Checked = false;
            }
        }


        // ------------------------- ТИП "ЗАКОНОДАТЕЛЬНЫЕ МАТЕРИАЛЫ" ----------------------------

        private void buttonSVLMPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbSVLMPublishingLocation, lbSVLMPublishingLocation);
            UpdatePublishingLocationSelector(lbSVLMPublishingLocation, lbSVLMPublishingLocationSelect);
        }

        private void buttonSVLMPublisher_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbSVLMPublisher,
                lbSVLMPublisher,
                cbSVLMPublisher.Checked,
                lbSVLMPublishingLocationSelect,
                groupedPublishersSVLegislativeMaterial
            );
        }

        private void cbSVLMPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbSVLMPublisher.Checked,
                lbSVLMPublisher,
                lbSVLMPublishingLocationSelect,
                groupedPublishersSVLegislativeMaterial
            );
        }

        private void lbSVLMPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbSVLMPublisher,
                lbSVLMPublishingLocationSelect,
                groupedPublishersSVLegislativeMaterial
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessLegislativeMaterial()
        {
            List<string> errors = new List<string>();

            List<string> places = GetStringsList(lbSVLMPublishingLocation);
            List<string> publishers = GetStringsList(lbSVLMPublisher);

            string title = tbSVLMTitle.Text.Trim();
            string abbreviation = tbSVLMAbbreviation.Text.Trim();
            string docType = tbSVLMDocumentType.Text.Trim();
            string additions = tbSVLMAdditions.Text.Trim();
            string adoptionDate = tbSVLMImplementDate.Text.Trim();
            string approvalDate = tbSVLMApprovalDate.Text.Trim();
            string year = tbSVLMPublishYear.Text.Trim();
            string pages = tbSVLMPagesCount.Text.Trim();
            string series = tbSVLMSeries.Text.Trim();
            string isbn = tbSVLMISBN.Text.Trim();
            string contentType = tbSVLMContentType.Text.Trim();

            if (string.IsNullOrWhiteSpace(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbSVLMPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbSVLMPublisher.Checked && groupedPublishersSVLegislativeMaterial.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrWhiteSpace(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titleBlock = $"Российская Федерация. Законы. {title}";
            List<string> exts = new List<string>();

            if (!string.IsNullOrWhiteSpace(abbreviation)) exts.Add(abbreviation);
            if (!string.IsNullOrWhiteSpace(docType)) exts.Add(docType);
            if (!string.IsNullOrWhiteSpace(additions)) exts.Add(additions);

            List<string> approvalParts = new List<string>();
            if (!string.IsNullOrWhiteSpace(adoptionDate)) approvalParts.Add($"принят Государственной думой {adoptionDate}");
            if (!string.IsNullOrWhiteSpace(approvalDate)) approvalParts.Add($"одобрен Советом Федерации {approvalDate}");
            if (approvalParts.Count > 0) exts.Add($"[{string.Join(" : ", approvalParts)}]");

            if (exts.Count > 0)
                titleBlock += " : " + string.Join(" : ", exts);

            string imprint = cbSVLMPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersSVLegislativeMaterial)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrWhiteSpace(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrWhiteSpace(isbn) ? "" : $"ISBN {isbn}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleBlock.TrimEnd('.'));
            blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbSVLMTitle.Clear();
                tbSVLMAbbreviation.Clear();
                tbSVLMDocumentType.Clear();
                tbSVLMAdditions.Clear();
                tbSVLMImplementDate.Clear();
                tbSVLMApprovalDate.Clear();
                tbSVLMPublishYear.Clear();
                tbSVLMPagesCount.Clear();
                tbSVLMSeries.Clear();
                tbSVLMISBN.Clear();
                tbSVLMContentType.Clear();
                lbSVLMPublishingLocation.Items.Clear();
                lbSVLMPublisher.Items.Clear();
                lbSVLMPublishingLocationSelect.Items.Clear();
                groupedPublishersSVLegislativeMaterial.Clear();
                cbSVLMPublisher.Checked = false;
            }
        }

        // ------------------------- ТИП "АВТОРЕФЕРАТ ДИССЕРТАЦИИ" ----------------------------

        private void ProcessDissertationAbstract()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(tbSVDAAuthor.Text))
                errors.Add("Не заполнено поле «Автор (полное имя)»");
            if (string.IsNullOrWhiteSpace(tbSVDATitle.Text))
                errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrWhiteSpace(tbSVDASpecialty.Text))
                errors.Add("Не заполнено поле «Специальность (код и название)»");
            if (string.IsNullOrWhiteSpace(tbSVDADegree.Text))
                errors.Add("Не заполнено поле «Ученая степень»");
            if (string.IsNullOrWhiteSpace(tbSVDAPublishingLocation.Text))
                errors.Add("Не заполнено поле «Место издания»");
            if (string.IsNullOrWhiteSpace(tbSVDAPublishYear.Text))
                errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrWhiteSpace(tbSVDADefenseLocation.Text))
                errors.Add("Не заполнено поле «Место защиты»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = tbSVDATitle.Text.Trim();
            string specialty = tbSVDASpecialty.Text.Trim();
            string degree = tbSVDADegree.Text.Trim();
            string fullName = tbSVDAAuthor.Text.Trim();
            string organization = tbSVDAOrganization.Text.Trim();
            string publishingPlace = tbSVDAPublishingLocation.Text.Trim();
            string year = tbSVDAPublishYear.Text.Trim();
            string pages = tbSVDAPagesCount.Text.Trim();
            string bibliography = tbSVDABibliography.Text.Trim();
            string defenseLocation = tbSVDADefenseLocation.Text.Trim();
            string contentType = tbSVDAContentType.Text.Trim();

            string authorShort = ToSurnameWithInitials(fullName);
            if (string.IsNullOrEmpty(authorShort))
            {
                MessageBox.Show("Неверный формат имени. Ожидается «Фамилия Имя» или «Фамилия Имя Отчество».",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string authorWithComma = EnsureComma(authorShort);

            List<string> exts = new List<string>();
            if (!string.IsNullOrEmpty(specialty)) exts.Add($"специальность {specialty}");
            if (!string.IsNullOrEmpty(degree)) exts.Add($"автореферат диссертации на соискание ученой степени {degree}");

            string titleBlock = $"{authorWithComma} {title}";
            if (exts.Count > 0) titleBlock += " : " + string.Join(" : ", exts);

            List<string> respParts = new List<string>();
            if (!string.IsNullOrEmpty(fullName)) respParts.Add(fullName);
            if (!string.IsNullOrEmpty(organization)) respParts.Add(organization);
            if (respParts.Count > 0) titleBlock += " / " + string.Join(" ; ", respParts);

            string imprint = $"{publishingPlace}, {year}";
            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string biblioBlock = string.IsNullOrWhiteSpace(bibliography) ? "" : $"Библиография: с. {bibliography}";
            string defenseBlock = $"Место защиты: {defenseLocation}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleBlock.TrimEnd('.'));
            blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(biblioBlock)) blocks.Add(biblioBlock.TrimEnd('.'));
            blocks.Add(defenseBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbSVDAAuthor.Clear();
                tbSVDATitle.Clear();
                tbSVDASpecialty.Clear();
                tbSVDADegree.Clear();
                tbSVDAOrganization.Clear();
                tbSVDAPublishingLocation.Clear();
                tbSVDAPublishYear.Clear();
                tbSVDAPagesCount.Clear();
                tbSVDABibliography.Clear();
                tbSVDADefenseLocation.Clear();
                tbSVDAContentType.Clear();
            }
        }

        // ------------------------- ТИП "ДИССЕРТАЦИЯ" ----------------------------

        private void ProcessDissertation()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(tbSVDTitle.Text))
                errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrWhiteSpace(tbSVDSpecialty.Text))
                errors.Add("Не заполнено поле «Специальность (код и название)»");
            if (string.IsNullOrWhiteSpace(tbSVDDegree.Text))
                errors.Add("Не заполнено поле «Ученая степень»");
            if (string.IsNullOrWhiteSpace(tbSVDAuthor.Text))
                errors.Add("Не заполнено поле «Автор (полное имя)»");
            if (string.IsNullOrWhiteSpace(tbSVDPublishingLocation.Text))
                errors.Add("Не заполнено поле «Место издания»");
            if (string.IsNullOrWhiteSpace(tbSVDPublishYear.Text))
                errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = tbSVDTitle.Text.Trim();
            string specialty = tbSVDSpecialty.Text.Trim();
            string degree = tbSVDDegree.Text.Trim();
            string fullName = tbSVDAuthor.Text.Trim();
            string organization = tbSVDOrganization.Text.Trim();
            string place = tbSVDPublishingLocation.Text.Trim();
            string year = tbSVDPublishYear.Text.Trim();
            string pages = tbSVDPagesCount.Text.Trim();
            string bibliography = tbSVDBibliography.Text.Trim();
            string contentType = tbSVDContentType.Text.Trim();

            string authorShort = ToSurnameWithInitials(fullName);
            if (string.IsNullOrEmpty(authorShort))
            {
                MessageBox.Show("Неверный формат имени. Ожидается «Фамилия Имя» или «Фамилия Имя Отчество».",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string authorWithComma = EnsureComma(authorShort);

            List<string> exts = new List<string>();
            if (!string.IsNullOrEmpty(specialty)) exts.Add($"специальность {specialty}");
            if (!string.IsNullOrEmpty(degree)) exts.Add($"диссертация на соискание ученой степени {degree}");

            string mainBlock = $"{authorWithComma} {title}";
            if (exts.Count > 0)
                mainBlock += " : " + string.Join(" : ", exts);

            List<string> slashParts = new List<string>();
            if (!string.IsNullOrEmpty(fullName)) slashParts.Add(fullName);
            if (!string.IsNullOrEmpty(organization)) slashParts.Add(organization);
            if (slashParts.Count > 0)
                mainBlock += " / " + string.Join(" ; ", slashParts);

            string imprint = $"{place}, {year}";
            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string biblioBlock = string.IsNullOrWhiteSpace(bibliography) ? "" : $"Библиография: с. {bibliography}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(mainBlock.TrimEnd('.'));
            blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(biblioBlock)) blocks.Add(biblioBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbSVDTitle.Clear();
                tbSVDSpecialty.Clear();
                tbSVDDegree.Clear();
                tbSVDAuthor.Clear();
                tbSVDOrganization.Clear();
                tbSVDPublishingLocation.Clear();
                tbSVDPublishYear.Clear();
                tbSVDPagesCount.Clear();
                tbSVDBibliography.Clear();
                tbSVDContentType.Clear();
            }
        }

        //
        // ------------------------- КАТЕГОРИЯ "МНОГОЧАСТНЫЕ (МНОГОТОМНЫЕ) РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "МНОГОТОМНОЕ ИЗДАНИЕ В ЦЕЛОМ" ----------------------------

        private void buttonMVWMAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVWMAuthors, lbMVWMAuthors);
        }

        private void buttonMVWMPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVWMPublishingLocation, lbMVWMPublishingLocation);
            UpdatePublishingLocationSelector(lbMVWMPublishingLocation, lbMVWMPublishingLocationSelect);
        }

        private void buttonMVWMPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbMVWMPublisher,
                lbMVWMPublisher,
                cbMVWMPublisher.Checked,
                lbMVWMPublishingLocationSelect,
                groupedPublishersMVWholeMultivolume
            );
        }

        private void cbMVWMPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbMVWMPublisher.Checked,
                lbMVWMPublisher,
                lbMVWMPublishingLocationSelect,
                groupedPublishersMVWholeMultivolume
            );
        }

        private void lbMVWMPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbMVWMPublisher,
                lbMVWMPublishingLocationSelect,
                groupedPublishersMVWholeMultivolume
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonMVWMEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVWMEditor, lbMVWMEditor);
        }

        private void ProcessWholeMultivolume()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbMVWMAuthors);
            List<string> places = GetStringsList(lbMVWMPublishingLocation);
            List<string> publishers = GetStringsList(lbMVWMPublisher);
            List<string> editors = GetStringsList(lbMVWMEditor);

            string title = tbMVWMTitle.Text.Trim();
            string parallelTitle = tbMVWMParallelTitle.Text.Trim();
            string volumesCount = tbMVWMVolumesCount.Text.Trim();
            string year = tbMVWMPublishYear.Text.Trim();
            string docType = tbMVWMDocumentType.Text.Trim();
            string editionNumber = tbMVWMEditionNumber.Text.Trim();
            string translator = tbMVWMTranslator.Text.Trim();
            string organization = tbMVWMOrganization.Text.Trim();
            string series = tbMVWMSeries.Text.Trim();
            string isbn = tbMVWMISBN.Text.Trim();
            string contentType = tbMVWMContentType.Text.Trim();
            string pages = tbMVWMPagesCount.Text.Trim();
            string editorType = cbMVWMEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrEmpty(volumesCount)) errors.Add("Не заполнено поле «Количество томов»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbMVWMPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbMVWMPublisher.Checked && groupedPublishersMVWholeMultivolume.Values.Sum(l => l.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullTitle = string.IsNullOrEmpty(parallelTitle)
                ? title
                : $"{title} = {parallelTitle}";

            string volumeBlock = $"в {volumesCount} т.";
            if (!string.IsNullOrEmpty(docType)) volumeBlock += $" : {docType}";

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string titleAndAuthors;
            if (cbMVWMAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = $"{fullTitle} : {volumeBlock} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                titleAndAuthors = $"{authorsWithComma[0]} {fullTitle} : {volumeBlock} / {reversedAuthors[0]}";
            }
            else if (countA == 2 || countA == 3)
            {
                string all = string.Join(", ", reversedAuthors);
                titleAndAuthors = $"{authorsWithComma[0]} {fullTitle} : {volumeBlock} / {all}";
            }
            else if (countA == 4)
            {
                string all = string.Join(", ", reversedAuthors);
                titleAndAuthors = $"{fullTitle} : {volumeBlock} / {all}";
            }
            else if (countA >= 5)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = $"{fullTitle} : {volumeBlock} / {firstThree} [и другие]";
            }
            else
            {
                titleAndAuthors = $"{fullTitle} : {volumeBlock}";
            }

            string editorsJoined = string.Join(", ", editors);
            string responsibilityBlock = "";

            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
            {
                responsibilityBlock = string.IsNullOrEmpty(responsibilityBlock)
                    ? organization
                    : $"{responsibilityBlock} ; {organization}";
            }

            if (!string.IsNullOrEmpty(responsibilityBlock))
                titleAndAuthors += " ; " + responsibilityBlock;

            if (!string.IsNullOrEmpty(editionNumber) && !string.IsNullOrEmpty(translator))
                titleAndAuthors += ". – " + editionNumber + " ; перевод с " + translator;
            else if (!string.IsNullOrEmpty(editionNumber))
                titleAndAuthors += ". – " + editionNumber;
            else if (!string.IsNullOrEmpty(translator))
                titleAndAuthors += ". – перевод с " + translator;

            string imprint;
            if (cbMVWMPublisher.Checked)
                imprint = $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersMVWholeMultivolume)}, {year}";
            else
                imprint = $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string contBlock = string.IsNullOrEmpty(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleAndAuthors.TrimEnd('.'));
            blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbMVWMAuthors.Items.Clear();
                tbMVWMTitle.Clear();
                tbMVWMParallelTitle.Clear();
                tbMVWMVolumesCount.Clear();
                lbMVWMPublishingLocation.Items.Clear();
                tbMVWMPublishYear.Clear();
                tbMVWMDocumentType.Clear();
                tbMVWMEditionNumber.Clear();
                tbMVWMTranslator.Clear();
                tbMVWMOrganization.Clear();
                tbMVWMSeries.Clear();
                tbMVWMISBN.Clear();
                tbMVWMContentType.Clear();
                tbMVWMPagesCount.Clear();
                lbMVWMEditor.Items.Clear();
                groupedPublishersMVWholeMultivolume.Clear();
                lbMVWMPublisher.Items.Clear();
                lbMVWMPublishingLocationSelect.Items.Clear();
                cbMVWMPublisher.Checked = false;
                UpdateListCheckBox(lbMVWMAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "ОТДЕЛЬНЫЙ ТОМ" ----------------------------

        private void buttonMVSVAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVSVAuthors, lbMVSVAuthors);
        }

        private void buttonMVSVPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVSVPublishingLocation, lbMVSVPublishingLocation);
            UpdatePublishingLocationSelector(lbMVSVPublishingLocation, lbMVSVPublishingLocationSelect);
        }

        private void buttonMVSVPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbMVSVPublisher,
                lbMVSVPublisher,
                cbMVSVPublisher.Checked,
                lbMVSVPublishingLocationSelect,
                groupedPublishersMVSeparateVolume
            );
        }

        private void cbMVSVPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbMVSVPublisher.Checked,
                lbMVSVPublisher,
                lbMVSVPublishingLocationSelect,
                groupedPublishersMVSeparateVolume
            );
        }

        private void lbMVSVPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbMVSVPublisher,
                lbMVSVPublishingLocationSelect,
                groupedPublishersMVSeparateVolume
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonMVSVEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbMVSVEditor, lbMVSVEditor);
        }

        private void ProcessSeparateVolume()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbMVSVAuthors);
            List<string> places = GetStringsList(lbMVSVPublishingLocation);
            List<string> publishers = GetStringsList(lbMVSVPublisher);
            List<string> editors = GetStringsList(lbMVSVEditor);

            string title = tbMVSVTitle.Text.Trim();
            string parallelTitle = tbMVSVParallelTitle.Text.Trim();
            string volumesCount = tbMVSVVolumesCount.Text.Trim();
            string volumeNumber = tbMVSVVolumeNumber.Text.Trim();
            string volumeTitle = tbMVSVVolumeTitle.Text.Trim();
            string year = tbMVSVPublishYear.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrEmpty(volumesCount)) errors.Add("Не заполнено поле «Количество томов»");
            if (string.IsNullOrEmpty(volumeNumber)) errors.Add("Не заполнено поле «Номер тома»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!cbMVSVPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbMVSVPublisher.Checked && groupedPublishersMVSeparateVolume.Values.Sum(x => x.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string docType = tbMVSVDocumentType.Text.Trim();
            string editionNumber = tbMVSVEditionNumber.Text.Trim();
            string translator = tbMVSVTranslator.Text.Trim();
            string organization = tbMVSVOrganization.Text.Trim();
            string series = tbMVSVSeries.Text.Trim();
            string isbn = tbMVSVISBN.Text.Trim();
            string contentType = tbMVSVContentType.Text.Trim();
            string editorType = cbMVSVEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";
            string pages = tbMVSVPagesCount.Text.Trim();

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string fullTitle = string.IsNullOrEmpty(parallelTitle) ? title : $"{title} = {parallelTitle}";
            string volumeInfo = $"в {volumesCount} т.";
            string volBlock = $"Т. {volumeNumber}" + (string.IsNullOrEmpty(volumeTitle) ? "" : $" : {volumeTitle}");
            string docBlock = string.IsNullOrEmpty(docType) ? "" : $" : {docType}";

            string mainTitleBlock = $"{fullTitle} : {volumeInfo} {volBlock}{docBlock}";

            string titleAndAuthorsBlock;
            if (cbMVSVAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthorsBlock = $"{mainTitleBlock} / {firstThree} [и другие]";
            }
            else
            {
                if (countA == 1)
                    titleAndAuthorsBlock = $"{authorsWithComma[0]} {mainTitleBlock} / {reversedAuthors[0]}";
                else if (countA <= 3)
                    titleAndAuthorsBlock = $"{authorsWithComma[0]} {mainTitleBlock} / {string.Join(", ", reversedAuthors)}";
                else if (countA == 4)
                    titleAndAuthorsBlock = $"{mainTitleBlock} / {string.Join(", ", reversedAuthors)}";
                else if (countA >= 5)
                    titleAndAuthorsBlock = $"{mainTitleBlock} / {string.Join(", ", reversedAuthors.Take(3))} [и другие]";
                else
                    titleAndAuthorsBlock = mainTitleBlock;
            }

            string editorsJoined = string.Join(", ", editors);
            string responsibilityBlock = "";

            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
                responsibilityBlock = string.IsNullOrEmpty(responsibilityBlock)
                    ? organization
                    : $"{responsibilityBlock} ; {organization}";

            string firstBlock = string.IsNullOrEmpty(responsibilityBlock)
                ? titleAndAuthorsBlock
                : $"{titleAndAuthorsBlock} ; {responsibilityBlock}";

            if (!string.IsNullOrEmpty(editionNumber))
                firstBlock += $". – {editionNumber}";
            if (!string.IsNullOrEmpty(translator))
                firstBlock += string.IsNullOrEmpty(editionNumber) ? ". – перевод с " + translator : "; перевод с " + translator;

            string imprintBlock = cbMVSVPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersMVSeparateVolume)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string contBlock = string.IsNullOrEmpty(contentType) ? "Текст : непосредственный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(firstBlock.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbMVSVAuthors.Items.Clear();
                tbMVSVTitle.Clear();
                tbMVSVParallelTitle.Clear();
                tbMVSVVolumesCount.Clear();
                tbMVSVVolumeNumber.Clear();
                tbMVSVVolumeTitle.Clear();
                lbMVSVPublishingLocation.Items.Clear();
                lbMVSVPublisher.Items.Clear();
                tbMVSVPublishYear.Clear();
                tbMVSVPagesCount.Clear();
                tbMVSVDocumentType.Clear();
                tbMVSVEditionNumber.Clear();
                tbMVSVTranslator.Clear();
                tbMVSVOrganization.Clear();
                tbMVSVSeries.Clear();
                tbMVSVISBN.Clear();
                tbMVSVContentType.Clear();
                lbMVSVEditor.Items.Clear();
                lbMVSVPublishingLocationSelect.Items.Clear();
                cbMVSVPublisher.Checked = false;
                groupedPublishersMVSeparateVolume.Clear();
                UpdateListCheckBox(lbMVSVAuthors, 1, 5);
            }
        }

        //
        // ------------------------- КАТЕГОРИЯ "ЭЛЕКТРОННЫЕ РЕСУРСЫ" ----------------------------
        //

        // ------------------------- ТИП "ЭЛЕКТРОННАЯ КНИГА" ----------------------------

        private void labelEREbAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbAuthors, lbEREbAuthors);
        }

        private void buttonEREbPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbPublishingLocation, lbEREbPublishingLocation);
            UpdatePublishingLocationSelector(lbEREbPublishingLocation, lbEREbPublishingLocationSelect);
        }

        private void buttonEREbPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbEREbPublisher,
                lbEREbPublisher,
                cbEREbPublisher.Checked,
                lbEREbPublishingLocationSelect,
                groupedPublishersEREbook
            );
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

        private void buttonEREbEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREbEditor, lbEREbEditor);
        }


        private void ProcessEbook()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbEREbAuthors);
            List<string> places = GetStringsList(lbEREbPublishingLocation);
            List<string> publishers = GetStringsList(lbEREbPublisher);
            List<string> editors = GetStringsList(lbEREbEditor);

            string title = tbEREbTitle.Text.Trim();
            string parallelTitle = tbEREbParallelTitle.Text.Trim();
            string year = tbEREbPublishYear.Text.Trim();
            string url = tbEREbURL.Text.Trim();
            string accessDate = tbEREbAccessDate.Text.Trim();
            string accessMode = tbEREbAccessMode.Text.Trim();
            string docType = tbEREbDocumentType.Text.Trim();
            string editionNumber = tbEREbEditionNumber.Text.Trim();
            string pages = tbEREbPagesCount.Text.Trim();
            string series = tbEREbSeries.Text.Trim();
            string isbn = tbEREbISBN.Text.Trim();
            string editorType = cbEREbEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";
            string organization = tbEREbOrganization.Text.Trim();
            string translator = tbEREbTranslator.Text.Trim();
            string contentType = tbEREbContentType.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbEREbPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbEREbPublisher.Checked && groupedPublishersEREbook.Values.Sum(x => x.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode)) errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string fullTitle = string.IsNullOrEmpty(parallelTitle)
                ? title
                : $"{title} = {parallelTitle}";

            string titleAndAuthors;
            if (cbEREbAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = string.IsNullOrEmpty(docType)
                    ? $"{fullTitle} / {firstThree} [и другие]"
                    : $"{fullTitle} : {docType} / {firstThree} [и другие]";
            }
            else
            {
                if (countA == 0)
                {
                    titleAndAuthors = fullTitle;
                }
                else if (countA == 1)
                {
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{authorsWithComma[0]} {fullTitle} / {reversedAuthors[0]}"
                        : $"{authorsWithComma[0]} {fullTitle} : {docType} / {reversedAuthors[0]}";
                }
                else if (countA == 2 || countA == 3)
                {
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{authorsWithComma[0]} {fullTitle} / {allRev}"
                        : $"{authorsWithComma[0]} {fullTitle} : {docType} / {allRev}";
                }
                else if (countA == 4)
                {
                    string allRev = string.Join(", ", reversedAuthors);
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} / {allRev}"
                        : $"{fullTitle} : {docType} / {allRev}";
                }
                else
                {
                    string firstThree = string.Join(", ", reversedAuthors.Take(3));
                    titleAndAuthors = string.IsNullOrEmpty(docType)
                        ? $"{fullTitle} / {firstThree} [и другие]"
                        : $"{fullTitle} : {docType} / {firstThree} [и другие]";
                }
            }

            string editorsJoined = string.Join(", ", editors);
            string responsibilityBlock = "";

            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
            {
                responsibilityBlock = !string.IsNullOrEmpty(responsibilityBlock)
                    ? $"{responsibilityBlock} ; {organization}"
                    : organization;
            }

            if (!string.IsNullOrEmpty(responsibilityBlock))
                titleAndAuthors += " ; " + responsibilityBlock;

            if (!string.IsNullOrEmpty(editionNumber) && !string.IsNullOrEmpty(translator))
                titleAndAuthors += ". – " + editionNumber + " ; перевод с " + translator;
            else if (!string.IsNullOrEmpty(editionNumber))
                titleAndAuthors += ". – " + editionNumber;
            else if (!string.IsNullOrEmpty(translator))
                titleAndAuthors += ". – перевод с " + translator;

            string imprintBlock = cbEREbPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersEREbook)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";
            string contBlock = string.IsNullOrEmpty(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleAndAuthors.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(urlBlock.TrimEnd('.'));
            blocks.Add(accessBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbEREbTitle.Clear();
                tbEREbParallelTitle.Clear();
                lbEREbPublishingLocation.Items.Clear();
                lbEREbPublisher.Items.Clear();
                tbEREbPublishYear.Clear();
                tbEREbURL.Clear();
                tbEREbAccessDate.Clear();
                tbEREbAccessMode.Clear();
                tbEREbDocumentType.Clear();
                tbEREbEditionNumber.Clear();
                tbEREbPagesCount.Clear();
                tbEREbSeries.Clear();
                tbEREbISBN.Clear();
                tbEREbOrganization.Clear();
                tbEREbTranslator.Clear();
                tbEREbContentType.Clear();
                lbEREbEditor.Items.Clear();
                groupedPublishersEREbook.Clear();
                lbEREbPublishingLocationSelect.Items.Clear();
                cbEREbPublisher.Checked = false;
                UpdateListCheckBox(lbEREbAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "МНОГОТОМНОЕ ЭЛЕКТРОННОЕ ИЗДАНИЕ В ЦЕЛОМ" ----------------------------

        private void buttonERWEEAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERWEEAuthors, lbERWEEAuthors);
        }

        private void buttonERWEEPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERWEEPublishingLocation, lbERWEEPublishingLocation);
            UpdatePublishingLocationSelector(lbERWEEPublishingLocation, lbERWEEPublishingLocationSelect);
        }

        private void buttonERWEEPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERWEEPublisher,
                lbERWEEPublisher,
                cbERWEEPublisher.Checked,
                lbERWEEPublishingLocationSelect,
                groupedPublishersERWholeElectronicEdition
            );
        }

        private void cbERWEEPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbERWEEPublisher.Checked,
                lbERWEEPublisher,
                lbERWEEPublishingLocationSelect,
                groupedPublishersERWholeElectronicEdition
            );
        }

        private void lbERWEEPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbERWEEPublisher,
                lbERWEEPublishingLocationSelect,
                groupedPublishersERWholeElectronicEdition
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonERWEEEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERWEEEditor, lbERWEEEditor);
        }

        private void ProcessWholeElectronicEdition()
        {
            List<string> errors = new List<string>();

            List<string> authorsList = GetStringsList(lbERWEEAuthors);
            List<string> places = GetStringsList(lbERWEEPublishingLocation);
            List<string> publishers = GetStringsList(lbERWEEPublisher);
            List<string> editorsList = GetStringsList(lbERWEEEditor);

            string title = tbERWEETitle.Text.Trim();
            string parallelTitle = tbERWEEParallelTitle.Text.Trim();
            string volumesCount = tbERWEEVolumesCount.Text.Trim();
            string year = tbERWEEPublishYear.Text.Trim();
            string pages = tbERWEEPagesCount.Text.Trim();
            string docType = tbERWEEDocumentType.Text.Trim();
            string editionNumber = tbERWEEEditionNumber.Text.Trim();
            string series = tbERWEESeries.Text.Trim();
            string isbn = tbERWEEISBN.Text.Trim();
            string contentType = tbERWEEContentType.Text.Trim();
            string organization = tbERWEEOrganization.Text.Trim();
            string translator = tbERWEETranslator.Text.Trim();
            string url = tbERWEEURL.Text.Trim();
            string accessDate = tbERWEEAccessDate.Text.Trim();
            string accessMode = tbERWEEAccessMode.Text.Trim();
            string editorType = cbERWEEEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";
            string editorsJoined = string.Join(", ", editorsList);

            if (authorsList.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrEmpty(volumesCount)) errors.Add("Не заполнено поле «Количество томов»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbERWEEPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbERWEEPublisher.Checked && groupedPublishersERWholeElectronicEdition.Values.Sum(x => x.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode)) errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authorsList.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();

            string fullTitle = string.IsNullOrEmpty(parallelTitle)
                ? title
                : $"{title} = {parallelTitle}";

            string volumeAndType = $"в {volumesCount} т.";
            if (!string.IsNullOrEmpty(docType)) volumeAndType += $" : {docType}";

            string titleAndAuthors;
            int countA = reversedAuthors.Count;

            if (cbERWEEAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = $"{fullTitle} : {volumeAndType} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                titleAndAuthors = $"{authorsWithComma[0]} {fullTitle} : {volumeAndType} / {reversedAuthors[0]}";
            }
            else if (countA <= 3)
            {
                string all = string.Join(", ", reversedAuthors);
                titleAndAuthors = $"{authorsWithComma[0]} {fullTitle} : {volumeAndType} / {all}";
            }
            else if (countA >= 4)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = $"{fullTitle} : {volumeAndType} / {firstThree} [и другие]";
            }
            else
            {
                titleAndAuthors = $"{fullTitle} : {volumeAndType}";
            }

            string responsibilityBlock = "";

            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
            {
                responsibilityBlock = string.IsNullOrEmpty(responsibilityBlock)
                    ? organization
                    : $"{responsibilityBlock} ; {organization}";
            }

            string firstBlock = string.IsNullOrEmpty(responsibilityBlock)
                ? titleAndAuthors
                : $"{titleAndAuthors} ; {responsibilityBlock}";

            if (!string.IsNullOrEmpty(editionNumber))
                firstBlock += ". – " + editionNumber;

            if (!string.IsNullOrEmpty(translator))
                firstBlock += (string.IsNullOrEmpty(editionNumber) ? ". –" : ";") + $" перевод с {translator}";

            string imprintBlock = cbERWEEPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERWholeElectronicEdition)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";
            string contentBlock = string.IsNullOrEmpty(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(firstBlock.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(urlBlock.TrimEnd('.'));
            blocks.Add(accessBlock.TrimEnd('.'));
            blocks.Add(contentBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbERWEEAuthors.Items.Clear();
                tbERWEETitle.Clear();
                tbERWEEParallelTitle.Clear();
                tbERWEEVolumesCount.Clear();
                lbERWEEPublishingLocation.Items.Clear();
                lbERWEEPublisher.Items.Clear();
                tbERWEEPublishYear.Clear();
                tbERWEEDocumentType.Clear();
                tbERWEEEditionNumber.Clear();
                tbERWEEPagesCount.Clear();
                tbERWEESeries.Clear();
                tbERWEEISBN.Clear();
                tbERWEEURL.Clear();
                tbERWEEAccessDate.Clear();
                tbERWEEAccessMode.Clear();
                tbERWEEContentType.Clear();
                tbERWEETranslator.Clear();
                tbERWEEOrganization.Clear();
                lbERWEEEditor.Items.Clear();
                lbERWEEPublishingLocationSelect.Items.Clear();
                groupedPublishersERWholeElectronicEdition.Clear();
                cbERWEEPublisher.Checked = false;
                UpdateListCheckBox(lbERWEEAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "ОТДЕЛЬНЫЙ ТОМ ЭЛЕКТРОННОГО ИЗДАНИЯ" ----------------------------

        private void buttonEREESVAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREESVAuthors, lbEREESVAuthors);
        }

        private void buttonEREESVPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREESVPublishingLocation, lbEREESVPublishingLocation);
            UpdatePublishingLocationSelector(lbEREESVPublishingLocation, lbEREESVPublishingLocationSelect);
        }

        private void buttonEREESVPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbEREESVPublisher,
                lbEREESVPublisher,
                cbEREESVPublisher.Checked,
                lbEREESVPublishingLocationSelect,
                groupedPublishersERElectronicEditionSeparateVolume
            );
        }

        private void cbEREESVPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbEREESVPublisher.Checked,
                lbEREESVPublisher,
                lbEREESVPublishingLocationSelect,
                groupedPublishersERElectronicEditionSeparateVolume
            );
        }

        private void lbEREESVPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbEREESVPublisher,
                lbEREESVPublishingLocationSelect,
                groupedPublishersERElectronicEditionSeparateVolume
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonEREESVEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREESVEditor, lbEREESVEditor);
        }

        private void ProcessElectronicEditionSeparateVolume()
        {
            List<string> errors = new();

            List<string> authorsList = GetStringsList(lbEREESVAuthors);
            List<string> places = GetStringsList(lbEREESVPublishingLocation);
            List<string> publishers = GetStringsList(lbEREESVPublisher);

            string title = tbEREESVTitle.Text.Trim();
            string parallelTitle = tbEREESVParallelTitle.Text.Trim();
            string volumesCount = tbEREESVVolumesCount.Text.Trim();
            string volumeNumber = tbEREESVVolumeNumber.Text.Trim();
            string volumeTitle = tbEREESVVolumeTitle.Text.Trim();
            string year = tbEREESVPublishYear.Text.Trim();
            string docType = tbEREESVDocumentType.Text.Trim();
            string editionNumber = tbEREESVEditionNumber.Text.Trim();
            string pages = tbEREESVPagesCount.Text.Trim();
            string series = tbEREESVSeries.Text.Trim();
            string isbn = tbEREESVISBN.Text.Trim();
            string contentType = tbEREESVContentType.Text.Trim();
            string url = tbEREESVURL.Text.Trim();
            string accessDate = tbEREESVAccessDate.Text.Trim();
            string accessMode = tbEREESVAccessMode.Text.Trim();
            string organization = tbEREESVOrganization.Text.Trim();
            string translator = tbEREESVTranslator.Text.Trim();

            List<string> editorsList = GetStringsList(lbEREESVEditor);
            string editorType = cbEREESVEditorType.SelectedItem?.ToString().Trim('"').Trim() ?? "";
            string editorsJoined = string.Join(", ", editorsList);

            if (authorsList.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (string.IsNullOrEmpty(volumesCount)) errors.Add("Не заполнено поле «Количество томов»");
            if (string.IsNullOrEmpty(volumeNumber)) errors.Add("Не заполнено поле «Номер тома»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");

            if (!cbEREESVPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbEREESVPublisher.Checked && groupedPublishersERElectronicEditionSeparateVolume.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode)) errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authorsList.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string fullTitle = string.IsNullOrEmpty(parallelTitle) ? title : $"{title} = {parallelTitle}";
            string volumesInfo = $"в {volumesCount} т.";
            string volumeInfo = $"Т. {volumeNumber}";
            if (!string.IsNullOrEmpty(volumeTitle)) volumeInfo += $" : {volumeTitle}";
            string docBlock = !string.IsNullOrEmpty(docType) ? $" : {docType}" : "";

            string fullTitleBlock = $"{fullTitle} : {volumesInfo} {volumeInfo} {docBlock}";
            string titleAndAuthorsBlock = "";

            if (cbEREESVAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthorsBlock = $"{fullTitleBlock} / {firstThree} [и другие]";
            }
            else
            {
                titleAndAuthorsBlock = countA switch
                {
                    1 => $"{authorsWithComma[0]} {fullTitleBlock} / {reversedAuthors[0]}",
                    2 or 3 => $"{authorsWithComma[0]} {fullTitleBlock} / {string.Join(", ", reversedAuthors)}",
                    4 => $"{fullTitleBlock} / {string.Join(", ", reversedAuthors)}",
                    >= 5 => $"{fullTitleBlock} / {string.Join(", ", reversedAuthors.Take(3))} [и другие]",
                    _ => fullTitleBlock
                };
            }

            string responsibilityBlock = "";
            if (!string.IsNullOrEmpty(editorsJoined))
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под редакцией {editorsJoined}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"под общей редакцией {editorsJoined}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    responsibilityBlock = $"ответственный редактор {editorsJoined}";
                else
                    responsibilityBlock = $"под редакцией {editorsJoined}";
            }

            if (!string.IsNullOrEmpty(organization))
            {
                responsibilityBlock = !string.IsNullOrEmpty(responsibilityBlock)
                    ? $"{responsibilityBlock} ; {organization}"
                    : organization;
            }

            string firstBlock = string.IsNullOrEmpty(responsibilityBlock)
                ? titleAndAuthorsBlock
                : $"{titleAndAuthorsBlock} ; {responsibilityBlock}";

            if (!string.IsNullOrEmpty(editionNumber))
                firstBlock += ". – " + editionNumber;

            if (!string.IsNullOrEmpty(translator))
                firstBlock += (string.IsNullOrEmpty(editionNumber) ? ". –" : ";") + $" перевод с {translator}";

            string imprintBlock = cbEREESVPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERElectronicEditionSeparateVolume)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrEmpty(pages) ? "" : $"{pages} с.";
            string seriesBlock = string.IsNullOrEmpty(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrEmpty(isbn) ? "" : $"ISBN {isbn}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";
            string contentBlock = string.IsNullOrEmpty(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new()
            {
                firstBlock.TrimEnd('.'),
                imprintBlock.TrimEnd('.')
            };
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(urlBlock.TrimEnd('.'));
            blocks.Add(accessBlock.TrimEnd('.'));
            blocks.Add(contentBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbEREESVAuthors.Items.Clear();
                tbEREESVTitle.Clear();
                tbEREESVParallelTitle.Clear();
                tbEREESVVolumesCount.Clear();
                tbEREESVVolumeNumber.Clear();
                tbEREESVVolumeTitle.Clear();
                lbEREESVPublishingLocation.Items.Clear();
                tbEREESVPublishYear.Clear();
                tbEREESVDocumentType.Clear();
                tbEREESVEditionNumber.Clear();
                tbEREESVPagesCount.Clear();
                tbEREESVSeries.Clear();
                tbEREESVISBN.Clear();
                tbEREESVURL.Clear();
                tbEREESVAccessDate.Clear();
                tbEREESVAccessMode.Clear();
                tbEREESVContentType.Clear();
                tbEREESVTranslator.Clear();
                tbEREESVOrganization.Clear();
                lbEREESVEditor.Items.Clear();
                groupedPublishersERElectronicEditionSeparateVolume.Clear();
                lbEREESVPublisher.Items.Clear();
                lbEREESVPublishingLocationSelect.Items.Clear();
                cbEREESVPublisher.Checked = false;
                UpdateListCheckBox(lbEREESVAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "ЭЛЕКТРОННЫЕ МАТЕРИАЛЫ КОНФЕРЕНЦИЙ" ----------------------------

        private void buttonERECMPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECMPublishingLocation, lbERECMPublishingLocation);
            UpdatePublishingLocationSelector(lbERECMPublishingLocation, lbERECMPublishingLocationSelect);
        }

        private void buttonERECMPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERECMPublisher,
                lbERECMPublisher,
                cbERECMPublisher.Checked,
                lbERECMPublishingLocationSelect,
                groupedPublishersERElectronicConferenceMaterials
            );
        }

        private void cbERECMPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbERECMPublisher.Checked,
                lbERECMPublisher,
                lbERECMPublishingLocationSelect,
                groupedPublishersERElectronicConferenceMaterials
            );
        }

        private void lbERECMPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbERECMPublisher,
                lbERECMPublishingLocationSelect,
                groupedPublishersERElectronicConferenceMaterials
            );
            HandlePublishingLocationSelection(sender);
        }

        private void buttonERECMEditorialBoardAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECMEditorialBoard, lbERECMEditorialBoard);
        }

        private void buttonERECMEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECMEditor, lbERECMEditor);
        }

        private void ProcessElectronicConferenceMaterials()
        {
            List<string> errors = new List<string>();

            List<string> editorialBoard = GetStringsList(lbERECMEditorialBoard);
            List<string> editors = GetStringsList(lbERECMEditor);
            List<string> places = GetStringsList(lbERECMPublishingLocation);
            List<string> publishers = GetStringsList(lbERECMPublisher);

            string eventTitle = tbERECMEventTitle.Text.Trim();
            string publicationType = tbERECMPublicationType.Text.Trim();
            string eventPlace = tbERECMEventPlace.Text.Trim();
            string eventDate = tbERECMEventDate.Text.Trim();
            string year = tbERECMPublishYear.Text.Trim();
            string pages = tbERECMPagesCount.Text.Trim();
            string isbn = tbERECMISBN.Text.Trim();
            string contentType = tbERECMContentType.Text.Trim();
            string url = tbERECMURL.Text.Trim();
            string accessDate = tbERECMAccessDate.Text.Trim();
            string accessMode = tbERECMAccessMode.Text.Trim();
            string accessNote = tbERECMAccessNote.Text.Trim();
            string editorType = cbERECMEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            if (string.IsNullOrEmpty(eventTitle))
                errors.Add("Не заполнено поле «Название мероприятия»");
            if (string.IsNullOrEmpty(publicationType))
                errors.Add("Не заполнено поле «Вид издания»");
            if (string.IsNullOrEmpty(eventPlace))
                errors.Add("Не заполнено поле «Город проведения»");
            if (string.IsNullOrEmpty(eventDate))
                errors.Add("Не заполнено поле «Дата проведения»");
            if (places.Count == 0)
                errors.Add("Не указано ни одно место издания");

            if (!cbERECMPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbERECMPublisher.Checked && groupedPublishersERElectronicConferenceMaterials.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year))
                errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url))
                errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate))
                errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode))
                errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedBoard = editorialBoard.Select(NameFormatting).ToList();
            List<string> reversedBoard = formattedBoard.Select(ReverseAuthorName).ToList();
            string boardBlock = reversedBoard.Count > 0 ? $"редакционная коллегия : {string.Join(", ", reversedBoard)}" : "";

            string editorsBlock = "";
            if (editors.Count > 0)
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под общей редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"ответственный редактор {string.Join(", ", editors)}";
                else
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
            }

            string responsibilityBlock = "";
            if (!string.IsNullOrEmpty(boardBlock) && !string.IsNullOrEmpty(editorsBlock))
                responsibilityBlock = $"{boardBlock}, {editorsBlock}";
            else if (!string.IsNullOrEmpty(boardBlock))
                responsibilityBlock = boardBlock;
            else if (!string.IsNullOrEmpty(editorsBlock))
                responsibilityBlock = editorsBlock;

            string eventInfo = $"({eventPlace}, {eventDate})";
            string titleBlock = $"{eventTitle} : {publicationType} {eventInfo}";
            if (!string.IsNullOrEmpty(responsibilityBlock))
                titleBlock += $" / {responsibilityBlock}";

            string imprintBlock;
            if (cbERECMPublisher.Checked)
                imprintBlock = $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERElectronicConferenceMaterials)}, {year}";
            else
                imprintBlock = $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string isbnBlock = string.IsNullOrWhiteSpace(isbn) ? "" : $"ISBN {isbn}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";
            if (!string.IsNullOrEmpty(accessNote))
                accessBlock += $" ; {accessNote}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleBlock.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock)) blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(urlBlock.TrimEnd('.'));
            blocks.Add(accessBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbERECMEventTitle.Clear();
                tbERECMPublicationType.Clear();
                tbERECMEventPlace.Clear();
                tbERECMEventDate.Clear();
                tbERECMPublishYear.Clear();
                tbERECMPagesCount.Clear();
                tbERECMISBN.Clear();
                tbERECMContentType.Clear();
                tbERECMURL.Clear();
                tbERECMAccessDate.Clear();
                tbERECMAccessMode.Clear();
                tbERECMAccessNote.Clear();
                lbERECMEditorialBoard.Items.Clear();
                lbERECMEditor.Items.Clear();
                lbERECMPublishingLocation.Items.Clear();
                groupedPublishersERElectronicConferenceMaterials.Clear();
                lbERECMPublisher.Items.Clear();
                lbERECMPublishingLocationSelect.Items.Clear();
                cbERECMPublisher.Checked = false;
            }
        }

        // ------------------------- ТИП "ЭЛЕКТРОННЫЕ СБОРНИКИ" ----------------------------

        private void buttonERECPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECPublishingLocation, lbERECPublishingLocation);
            UpdatePublishingLocationSelector(lbERECPublishingLocation, lbERECPublishingLocationSelect);
        }

        private void buttonERECPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERECPublisher,         // TextBox с издательством
                lbERECPublisher,         // ListBox, где показываются издательства
                cbERECPublisher.Checked, // Чекбокс, включён ли умный режим
                lbERECPublishingLocationSelect,  // ListBox выбора места
                groupedPublishersERElectronicCollections // Наш словарь для этой вкладки
            );
        }

        private void cbERECPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(cbERECPublisher.Checked, lbERECPublisher, lbERECPublishingLocationSelect, groupedPublishersERElectronicCollections);
        }


        private void lbERECPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(lbERECPublisher, lbERECPublishingLocationSelect, groupedPublishersERElectronicCollections);
            HandlePublishingLocationSelection(sender);
        }

        private void buttonERECEditorialBoardAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECEditorialBoard, lbERECEditorialBoard);
        }

        private void buttonERECEditor_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERECEditor, lbERECEditor);
        }

        private void ProcessElectronicCollections()
        {
            List<string> errors = new List<string>();

            List<string> editorialBoard = GetStringsList(lbERECEditorialBoard);
            List<string> editors = GetStringsList(lbERECEditor);
            List<string> places = GetStringsList(lbERECPublishingLocation);
            List<string> publishers = GetStringsList(lbERECPublisher);

            string collectionTitle = tbERECCollectionTitle.Text.Trim();
            string publicationType = tbERECPublicationType.Text.Trim();
            string year = tbERECPublishYear.Text.Trim();
            string pages = tbERECPagesCount.Text.Trim();
            string isbn = tbERECISBN.Text.Trim();
            string url = tbERECURL.Text.Trim();
            string accessDate = tbERECAccessDate.Text.Trim();
            string accessMode = tbERECAccessMode.Text.Trim();
            string accessNote = tbERECAccessNote.Text.Trim();
            string contentType = tbERECContentType.Text.Trim();
            string editorType = cbERECEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            if (string.IsNullOrEmpty(collectionTitle))
                errors.Add("Не заполнено поле «Название сборника»");
            if (string.IsNullOrEmpty(publicationType))
                errors.Add("Не заполнено поле «Вид издания»");
            if (places.Count == 0)
                errors.Add("Не указано ни одно место издания");
            if (!cbERECPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbERECPublisher.Checked && groupedPublishersERElectronicCollections.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year))
                errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(url))
                errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate))
                errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode))
                errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedBoard = editorialBoard.Select(NameFormatting).ToList();
            List<string> reversedBoard = formattedBoard.Select(ReverseAuthorName).ToList();
            string boardBlock = reversedBoard.Count > 0 ? $"редакционная коллегия : {string.Join(", ", reversedBoard)}" : "";

            string editorsBlock = "";
            if (editors.Count > 0)
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под общей редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"ответственный редактор {string.Join(", ", editors)}";
                else
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
            }

            string responsibilityBlock = "";
            if (!string.IsNullOrEmpty(boardBlock) && !string.IsNullOrEmpty(editorsBlock))
                responsibilityBlock = $"{boardBlock}, {editorsBlock}";
            else if (!string.IsNullOrEmpty(boardBlock))
                responsibilityBlock = boardBlock;
            else if (!string.IsNullOrEmpty(editorsBlock))
                responsibilityBlock = editorsBlock;

            string titleBlock = $"{collectionTitle} : {publicationType}";
            if (!string.IsNullOrEmpty(responsibilityBlock))
                titleBlock += $" / {responsibilityBlock}";

            string imprintBlock;
            if (cbERECPublisher.Checked)
            {
                imprintBlock = $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERElectronicCollections)}, {year}";
            }
            else
            {
                imprintBlock = $"{CombinePlacesAndPublishers(places, publishers)}, {year}";
            }

            string pagesBlock = string.IsNullOrWhiteSpace(pages) ? "" : $"{pages} с.";
            string isbnBlock = string.IsNullOrWhiteSpace(isbn) ? "" : $"ISBN {isbn}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";
            if (!string.IsNullOrEmpty(accessNote))
                accessBlock += $" ; {accessNote}";
            string contBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(titleBlock.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(pagesBlock))
                blocks.Add(pagesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock))
                blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(urlBlock.TrimEnd('.'));
            blocks.Add(accessBlock.TrimEnd('.'));
            blocks.Add(contBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbERECCollectionTitle.Clear();
                tbERECPublicationType.Clear();
                tbERECPublishYear.Clear();
                tbERECPagesCount.Clear();
                tbERECISBN.Clear();
                tbERECURL.Clear();
                tbERECAccessDate.Clear();
                tbERECAccessMode.Clear();
                tbERECAccessNote.Clear();
                tbERECContentType.Clear();
                lbERECEditorialBoard.Items.Clear();
                lbERECEditor.Items.Clear();
                lbERECPublishingLocation.Items.Clear();
                groupedPublishersERElectronicCollections.Clear();
                lbERECPublisher.Items.Clear();
                lbERECPublishingLocationSelect.Items.Clear();
                cbERECPublisher.Checked = false;
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ЖУРНАЛА" ----------------------------

        private void tbEREjAAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbEREjAAuthors, lbEREjAAuthors);
        }

        private void ProcessEjournalArticle()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbEREjAAuthors);

            string articleTitle = tbEREjATitle.Text.Trim();
            string journalTitle = tbEREjAJournalName.Text.Trim();
            string year = tbEREjAYear.Text.Trim();
            string issueNumber = tbEREjAJournalNumber.Text.Trim();
            string pages = tbEREjAPages.Text.Trim();
            string url = tbEREjAURL.Text.Trim();
            string accessDate = tbEREjAAccessDate.Text.Trim();
            string accessMode = tbEREjAAccessMode.Text.Trim();
            string contentType = tbEREjAContentType.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(articleTitle)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(journalTitle)) errors.Add("Не заполнено поле «Название журнала»");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год»");
            if (string.IsNullOrEmpty(issueNumber)) errors.Add("Не заполнено поле «Номер»");
            if (string.IsNullOrEmpty(pages)) errors.Add("Не заполнено поле «Страницы»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");
            if (string.IsNullOrEmpty(accessMode)) errors.Add("Не заполнено поле «Режим доступа»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            int countA = reversedAuthors.Count;

            string titleAndAuthors;
            if (cbEREjAAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                titleAndAuthors = $"{articleTitle} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                titleAndAuthors = $"{authorsWithComma[0]} {articleTitle} / {reversedAuthors[0]}";
            }
            else if (countA >= 2 && countA <= 3)
            {
                titleAndAuthors = $"{authorsWithComma[0]} {articleTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA == 4)
            {
                titleAndAuthors = $"{articleTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA >= 5)
            {
                titleAndAuthors = $"{articleTitle} / {string.Join(", ", reversedAuthors.Take(3))} [и другие]";
            }
            else
            {
                titleAndAuthors = articleTitle;
            }

            string contentTypeBlock = string.IsNullOrEmpty(contentType)
                ? "Текст : электронный"
                : contentType;

            string journalBlock = $"{journalTitle}. – {year}. – № {issueNumber}. – С. {pages}";
            string contentJournalBlock = $"{contentTypeBlock} // {journalBlock}";

            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = $"Режим доступа: {accessMode}";

            List<string> blocks = new List<string>();
            blocks.Add($"{titleAndAuthors}. – {contentJournalBlock}");
            blocks.Add(urlBlock);
            blocks.Add(accessBlock);

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbEREjAAuthors.Items.Clear();
                tbEREjATitle.Clear();
                tbEREjAJournalName.Clear();
                tbEREjAYear.Clear();
                tbEREjAJournalNumber.Clear();
                tbEREjAPages.Clear();
                tbEREjAURL.Clear();
                tbEREjAAccessDate.Clear();
                tbEREjAAccessMode.Clear();
                tbEREjAContentType.Clear();
                UpdateListCheckBox(lbEREjAAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "МУЛЬТИМЕДИЙНОЕ ИЗДАНИЕ (НА ДИСКЕ)" ----------------------------

        private void buttonERMEAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERMEAuthors, lbERMEAuthors);
        }

        private void buttonERMEPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERMEPublishingLocation, lbERMEPublishingLocation);
            UpdatePublishingLocationSelector(lbERMEPublishingLocation, lbERMEPublishingLocationSelect);
        }

        private void buttonERMEPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERMEPublisher,
                lbERMEPublisher,
                cbERMEPublisher.Checked,
                lbERMEPublishingLocationSelect,
                groupedPublishersERMultimediaEdition
            );
        }

        private void cbERMEPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbERMEPublisher.Checked,
                lbERMEPublisher,
                lbERMEPublishingLocationSelect,
                groupedPublishersERMultimediaEdition
            );
        }

        private void lbERMEPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbERMEPublisher,
                lbERMEPublishingLocationSelect,
                groupedPublishersERMultimediaEdition
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessMultimediaEdition()
        {
            List<string> errors = new List<string>();

            List<string> authors = GetStringsList(lbERMEAuthors);
            List<string> places = GetStringsList(lbERMEPublishingLocation);
            List<string> publishers = GetStringsList(lbERMEPublisher);

            string title = tbERMETitle.Text.Trim();
            string docType = tbERMEDocumentType.Text.Trim();
            string year = tbERMEPublishYear.Text.Trim();
            string carrier = tbERMEDataCarrier.Text.Trim();
            string notation = tbERMENotation.Text.Trim();
            string isbn = tbERMEISBN.Text.Trim();
            string contentType = tbERMEContentType.Text.Trim();
            string organization = tbERMEOrganization.Text.Trim();
            string series = tbERMESeries.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указан ни один автор");
            if (string.IsNullOrEmpty(title)) errors.Add("Не заполнено поле «Заглавие»");
            if (places.Count == 0) errors.Add("Не указано ни одно место издания");
            if (!cbERMEPublisher.Checked && publishers.Count == 0) errors.Add("Не указано ни одно издательство");
            if (cbERMEPublisher.Checked && groupedPublishersERMultimediaEdition.Values.Sum(list => list.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(carrier)) errors.Add("Не заполнено поле «Носитель»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();

            string fullTitle = string.IsNullOrEmpty(docType)
                ? title
                : $"{title} : {docType}";

            string authorBlock;
            int countA = reversedAuthors.Count;

            if (cbERMEAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                authorBlock = $"{fullTitle} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                authorBlock = $"{authorsWithComma[0]} {fullTitle} / {reversedAuthors[0]}";
            }
            else if (countA >= 2 && countA <= 3)
            {
                authorBlock = $"{authorsWithComma[0]} {fullTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA == 4)
            {
                authorBlock = $"{fullTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA >= 5)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                authorBlock = $"{fullTitle} / {firstThree} [и другие]";
            }
            else
            {
                authorBlock = fullTitle;
            }

            if (!string.IsNullOrEmpty(organization))
            {
                authorBlock += $" ; {organization}";
            }

            string imprintBlock = cbERMEPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERMultimediaEdition)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string carrierBlock = $"{carrier}";
            string notationBlock = string.IsNullOrWhiteSpace(notation) ? "" : notation.Trim();
            string seriesBlock = string.IsNullOrWhiteSpace(series) ? "" : $"({series})";
            string isbnBlock = string.IsNullOrWhiteSpace(isbn) ? "" : $"ISBN {isbn}";
            string contentBlock = string.IsNullOrWhiteSpace(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new List<string>();
            blocks.Add(authorBlock.TrimEnd('.'));
            blocks.Add(imprintBlock.TrimEnd('.'));
            blocks.Add($"{carrierBlock}".TrimEnd('.'));
            if (!string.IsNullOrEmpty(notationBlock)) blocks.Add(notationBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(seriesBlock)) blocks.Add(seriesBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(isbnBlock)) blocks.Add(isbnBlock.TrimEnd('.'));
            blocks.Add(contentBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbERMETitle.Clear();
                tbERMEDocumentType.Clear();
                tbERMEPublishYear.Clear();
                tbERMEDataCarrier.Clear();
                tbERMENotation.Clear();
                tbERMESeries.Clear();
                tbERMEISBN.Clear();
                tbERMEContentType.Clear();
                tbERMEOrganization.Clear();
                lbERMEAuthors.Items.Clear();
                lbERMEPublishingLocation.Items.Clear();
                lbERMEPublisher.Items.Clear();
                lbERMEPublishingLocationSelect.Items.Clear();
                groupedPublishersERMultimediaEdition.Clear();
                cbERMEPublisher.Checked = false;
                UpdateListCheckBox(lbERMEAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "САЙТ" ----------------------------

        private void buttonERWPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbERWPublishingLocation, lbERWPublishingLocation);
            UpdatePublishingLocationSelector(lbERWPublishingLocation, lbERWPublishingLocationSelect);
        }

        private void buttonERWPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbERWPublisher,
                lbERWPublisher,
                cbERWPublisher.Checked,
                lbERWPublishingLocationSelect,
                groupedPublishersERWebsite
            );
        }

        private void cbERWPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbERWPublisher.Checked,
                lbERWPublisher,
                lbERWPublishingLocationSelect,
                groupedPublishersERWebsite
            );
        }

        private void lbERWPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbERWPublisher,
                lbERWPublishingLocationSelect,
                groupedPublishersERWebsite
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessWebsite()
        {
            List<string> errors = new();

            string websiteName = tbERWWebsiteName.Text.Trim();
            string resourceDescription = tbERWResourceDescription.Text.Trim();
            string resourceType = tbERWResourceType.Text.Trim();
            string year = tbERWCreationYear.Text.Trim();
            string details = tbERWDetails.Text.Trim();
            string organization = tbERWOrganization.Text.Trim();
            string url = tbERWURL.Text.Trim();
            string accessDate = tbERWAccessDate.Text.Trim();
            string accessMode = tbERWAccessMode.Text.Trim();
            string contentType = tbERWContentType.Text.Trim();
            string publicationDate = tbERWPublicationDate.Text.Trim();

            List<string> places = GetStringsList(lbERWPublishingLocation);
            List<string> publishers = GetStringsList(lbERWPublisher);

            if (string.IsNullOrEmpty(websiteName)) errors.Add("Не заполнено поле «Название сайта»");
            if (string.IsNullOrEmpty(url)) errors.Add("Не заполнено поле «URL»");
            if (string.IsNullOrEmpty(accessDate)) errors.Add("Не заполнено поле «Дата обращения»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstLine = websiteName;
            if (!string.IsNullOrEmpty(resourceDescription))
                firstLine += $" : {resourceDescription}";
            if (!string.IsNullOrEmpty(resourceType))
                firstLine += $" : {resourceType}";

            if (!string.IsNullOrEmpty(organization))
                firstLine += $" / {organization}";

            string imprint = "";
            if (cbERWPublisher.Checked)
                imprint = $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersERWebsite)}";
            else if (places.Count > 0 && publishers.Count > 0)
                imprint = $"{CombinePlacesAndPublishers(places, publishers)}";
            else if (places.Count > 0)
                imprint = string.Join(" ; ", places);
            else if (publishers.Count > 0)
                imprint = string.Join(" ; ", publishers);

            if (!string.IsNullOrEmpty(year))
            {
                imprint = string.IsNullOrEmpty(imprint) ? year : $"{imprint}, {year}";
            }

            string detailsBlock = string.IsNullOrEmpty(details) ? "" : details.TrimEnd('.');
            string publishDateBlock = string.IsNullOrEmpty(publicationDate) ? "" : $"Дата публикации: {publicationDate}";
            string urlBlock = $"URL: {url} (дата обращения: {accessDate})";
            string accessBlock = string.IsNullOrEmpty(accessMode) ? "" : $"Режим доступа: {accessMode}";
            string contentBlock = string.IsNullOrEmpty(contentType) ? "Текст : электронный" : contentType;

            List<string> blocks = new();
            blocks.Add(firstLine.TrimEnd('.'));
            if (!string.IsNullOrEmpty(imprint)) blocks.Add(imprint.TrimEnd('.'));
            if (!string.IsNullOrEmpty(detailsBlock)) blocks.Add(detailsBlock);
            if (!string.IsNullOrEmpty(publishDateBlock)) blocks.Add(publishDateBlock);
            blocks.Add(urlBlock.TrimEnd('.'));
            if (!string.IsNullOrEmpty(accessBlock)) blocks.Add(accessBlock);
            blocks.Add(contentBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                tbERWWebsiteName.Clear();
                tbERWResourceDescription.Clear();
                tbERWResourceType.Clear();
                tbERWCreationYear.Clear();
                tbERWDetails.Clear();
                tbERWOrganization.Clear();
                tbERWURL.Clear();
                tbERWAccessDate.Clear();
                tbERWAccessMode.Clear();
                tbERWContentType.Clear();
                tbERWPublicationDate.Clear();
                lbERWPublishingLocation.Items.Clear();
                lbERWPublisher.Items.Clear();
                lbERWPublishingLocationSelect.Items.Clear();
                groupedPublishersERWebsite.Clear();
                cbERWPublisher.Checked = false;
            }
        }

        //
        // ------------------------- КАТЕГОРИЯ "СОСТАВНЫЕ ЧАСТИ (СТАТЬИ, ГЛАВЫ) РЕСУРСОВ" ----------------------------
        //

        // ------------------------- ТИП "СТАТЬЯ ИЗ КНИГИ" ----------------------------

        private void buttonCPBAArticleAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPBAArticleAuthors, lbCPBAArticleAuthors);
        }

        private void buttonCPBABookAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPBABookAuthors, lbCPBABookAuthors);
        }

        private void buttonCPBAPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPBAPublishingLocation, lbCPBAPublishingLocation);
            UpdatePublishingLocationSelector(lbCPBAPublishingLocation, lbCPBAPublishingLocationSelect);
        }

        private void buttonCPBAPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbCPBAPublisher,
                lbCPBAPublisher,
                cbCPBAPublisher.Checked,
                lbCPBAPublishingLocationSelect,
                groupedPublishersCPBookArticle
            );
        }

        private void cbCPBAPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbCPBAPublisher.Checked,
                lbCPBAPublisher,
                lbCPBAPublishingLocationSelect,
                groupedPublishersCPBookArticle
            );
        }

        private void lbCPBAPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbCPBAPublisher,
                lbCPBAPublishingLocationSelect,
                groupedPublishersCPBookArticle
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessBookArticle()
        {
            List<string> errors = new();

            List<string> articleAuthors = GetStringsList(lbCPBAArticleAuthors);
            List<string> bookAuthors = GetStringsList(lbCPBABookAuthors);
            List<string> places = GetStringsList(lbCPBAPublishingLocation);
            List<string> publishers = GetStringsList(lbCPBAPublisher);

            string articleTitle = tbCPBAArticleTitle.Text.Trim();
            string bookTitle = tbCPBABookTitle.Text.Trim();
            string year = tbCPBAPublishYear.Text.Trim();
            string pages = tbCPBAPages.Text.Trim();
            string bookDocType = tbCPBABookDocumentType.Text.Trim();
            string organization = tbCPBAOrganization.Text.Trim();
            string contentType = tbCPBAContentType.Text.Trim();

            if (articleAuthors.Count == 0) errors.Add("Не указан ни один автор статьи");
            if (string.IsNullOrEmpty(articleTitle)) errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(bookTitle)) errors.Add("Не заполнено поле «Заглавие книги»");
            if (bookAuthors.Count == 0) errors.Add("Не указаны авторы или редакторы книги");
            if (places.Count == 0) errors.Add("Не указано место издания");

            if (!cbCPBAPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbCPBAPublisher.Checked && groupedPublishersCPBookArticle.Values.Sum(x => x.Count) == 0)
                errors.Add("Не указано ни одно издательство");

            if (string.IsNullOrEmpty(year)) errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(pages)) errors.Add("Не указан диапазон страниц");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedArticleAuthors = articleAuthors.Select(NameFormatting).ToList();
            List<string> reversedArticleAuthors = formattedArticleAuthors.Select(ReverseAuthorName).ToList();
            List<string> authorsWithComma = formattedArticleAuthors.Select(EnsureComma).ToList();

            string articleBlock;
            int countArticle = reversedArticleAuthors.Count;

            if (cbCPBAArticleAuthors.Checked && countArticle >= 1)
            {
                string firstThree = string.Join(", ", reversedArticleAuthors.Take(3));
                articleBlock = $"{articleTitle} / {firstThree} [и другие]";
            }
            else if (countArticle == 1)
            {
                articleBlock = $"{EnsureComma(formattedArticleAuthors[0])} {articleTitle} / {reversedArticleAuthors[0]}";
            }
            else if (countArticle is 2 or 3)
            {
                articleBlock = $"{EnsureComma(formattedArticleAuthors[0])} {articleTitle} / {string.Join(", ", reversedArticleAuthors)}";
            }
            else if (countArticle == 4)
            {
                articleBlock = $"{articleTitle} / {string.Join(", ", reversedArticleAuthors)}";
            }
            else if (countArticle >= 5)
            {
                string firstThree = string.Join(", ", reversedArticleAuthors.Take(3));
                articleBlock = $"{articleTitle} / {firstThree} [и другие]";
            }
            else
            {
                articleBlock = articleTitle;
            }

            string contentBlock = string.IsNullOrWhiteSpace(contentType)
                ? "Текст : непосредственный"
                : contentType;

            List<string> formattedBookAuthors = bookAuthors.Select(NameFormatting).ToList();
            List<string> reversedBookAuthors = formattedBookAuthors.Select(ReverseAuthorName).ToList();
            int countBook = reversedBookAuthors.Count;

            string bookResponsibility = "";
            if (cbCPBABookAuthors.Checked && countBook >= 1)
            {
                bookResponsibility = $"{string.Join(", ", reversedBookAuthors.Take(3))} [и другие]";
            }
            else
            {
                bookResponsibility = string.Join(", ", reversedBookAuthors);
            }

            string bookDocBlock = string.IsNullOrEmpty(bookDocType) ? "" : $" : {bookDocType}";

            string bookTitleBlock = "";
            if (countBook == 1)
            {
                bookTitleBlock = $"{bookTitle}{bookDocBlock} / {bookResponsibility}";
            }
            else if (countBook is 2 or 3)
            {
                bookTitleBlock = $"{EnsureComma(formattedBookAuthors[0])} {bookTitle}{bookDocBlock} / {bookResponsibility}";
            }
            else if (countBook >= 4)
            {
                bookTitleBlock = $"{bookTitle}{bookDocBlock} / {bookResponsibility}";
            }

            if (!string.IsNullOrEmpty(organization))
                bookTitleBlock += $" ; {organization}";

            string imprintBlock = cbCPBAPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersCPBookArticle)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pageBlock = $"С. {pages}";

            List<string> blocks = new();
            blocks.Add(articleBlock.TrimEnd('.'));
            blocks.Add($"{contentBlock.TrimEnd('.')} // {bookTitleBlock.TrimEnd('.')}");
            blocks.Add(imprintBlock.TrimEnd('.'));
            blocks.Add(pageBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbCPBAArticleAuthors.Items.Clear();
                lbCPBABookAuthors.Items.Clear();
                lbCPBAPublishingLocation.Items.Clear();
                lbCPBAPublisher.Items.Clear();
                lbCPBAPublishingLocationSelect.Items.Clear();
                groupedPublishersCPBookArticle.Clear();
                tbCPBAArticleTitle.Clear();
                tbCPBABookTitle.Clear();
                tbCPBAPublishYear.Clear();
                tbCPBAPages.Clear();
                tbCPBABookDocumentType.Clear();
                tbCPBAOrganization.Clear();
                tbCPBAContentType.Clear();
                cbCPBAPublisher.Checked = false;
                UpdateListCheckBox(lbCPBAArticleAuthors, 1, 5);
                UpdateListCheckBox(lbCPBABookAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ МАТЕРИАЛОВ КОНФЕРЕНЦИИ" ----------------------------

        private void buttonCPCAArticleAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPCAArticleAuthors, lbCPCAArticleAuthors);
        }

        private void buttonCPCAConferenceAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPCAConferenceAuthors, lbCPCAConferenceAuthors);
        }

        private void buttonCPCAEditorAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPCAEditor, lbCPCAEditor);
        }

        private void buttonCPCAPublishingLocationAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPCAPublishingLocation, lbCPCAPublishingLocation);
            UpdatePublishingLocationSelector(lbCPCAPublishingLocation, lbCPCAPublishingLocationSelect);
        }

        private void buttonCPCAPublisherAdd_Click(object sender, EventArgs e)
        {
            AddStringToPublisherListBox(
                tbCPCAPublisher,
                lbCPCAPublisher,
                cbCPCAPublisher.Checked,
                lbCPCAPublishingLocationSelect,
                groupedPublishersCPConferenceArticle
            );
        }

        private void cbCPCAPublisher_CheckedChanged(object sender, EventArgs e)
        {
            TogglePublisherSmartMode(
                cbCPCAPublisher.Checked,
                lbCPCAPublisher,
                lbCPCAPublishingLocationSelect,
                groupedPublishersCPConferenceArticle
            );
        }

        private void lbCPCAPublishingLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePublishersForSelectedPlace(
                lbCPCAPublisher,
                lbCPCAPublishingLocationSelect,
                groupedPublishersCPConferenceArticle
            );
            HandlePublishingLocationSelection(sender);
        }

        private void ProcessConferenceArticle()
        {
            List<string> errors = new List<string>();

            List<string> articleAuthors = GetStringsList(lbCPCAArticleAuthors);
            List<string> materialsAuthors = GetStringsList(lbCPCAConferenceAuthors);
            List<string> editors = GetStringsList(lbCPCAEditor);
            List<string> places = GetStringsList(lbCPCAPublishingLocation);
            List<string> publishers = GetStringsList(lbCPCAPublisher);

            string articleTitle = tbCPCAArticleTitle.Text.Trim();
            string materialsTitle = tbCPCAEventTitle.Text.Trim();
            string publicationType = tbCPCAPublicationType.Text.Trim();
            string eventPlace = tbCPCAEventPlace.Text.Trim();
            string eventDate = tbCPCAEventDate.Text.Trim();
            string partCount = tbCPCAPartCount.Text.Trim();
            string partNumberAndTitle = tbCPCAPartNumberAndTitle.Text.Trim();
            string year = tbCPCAPublishYear.Text.Trim();
            string pages = tbCPCAPages.Text.Trim();
            string organization = tbCPCAOrganization.Text.Trim();
            string contentType = tbCPCAContentType.Text.Trim();
            string editorType = cbCPCAEditorType.SelectedItem?.ToString()?.Trim('"').Trim() ?? "";

            if (articleAuthors.Count == 0)
                errors.Add("Не указан ни один автор статьи");
            if (string.IsNullOrEmpty(articleTitle))
                errors.Add("Не заполнено поле «Заглавие статьи»");
            if (string.IsNullOrEmpty(materialsTitle))
                errors.Add("Не заполнено поле «Название мероприятия»");
            if (places.Count == 0)
                errors.Add("Не указано место издания");
            if (!cbCPCAPublisher.Checked && publishers.Count == 0)
                errors.Add("Не указано ни одно издательство");
            if (cbCPCAPublisher.Checked && groupedPublishersCPConferenceArticle.Values.Sum(x => x.Count) == 0)
                errors.Add("Не указано ни одно издательство");
            if (string.IsNullOrEmpty(year))
                errors.Add("Не заполнено поле «Год издания»");
            if (string.IsNullOrEmpty(pages))
                errors.Add("Не заполнено поле «Диапазон страниц»");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedArticleAuthors = articleAuthors.Select(NameFormatting).ToList();
            List<string> reversedArticleAuthors = formattedArticleAuthors.Select(ReverseAuthorName).ToList();
            List<string> authorsWithComma = formattedArticleAuthors.Select(EnsureComma).ToList();
            int countA = reversedArticleAuthors.Count;

            string articleBlock = articleTitle;

            if (cbCPCAArticleAuthors.Checked && countA >= 1)
            {
                string firstThree = string.Join(", ", reversedArticleAuthors.Take(3));
                articleBlock = $"{articleTitle} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                articleBlock = $"{authorsWithComma[0]} {articleTitle} / {reversedArticleAuthors[0]}";
            }
            else if (countA >= 2 && countA <= 4)
            {
                articleBlock = $"{authorsWithComma[0]} {articleTitle} / {string.Join(", ", reversedArticleAuthors)}";
            }

            string contentBlock = string.IsNullOrEmpty(contentType)
                ? "Текст : непосредственный"
                : contentType;

            string materialsBlock = materialsTitle;

            if (!string.IsNullOrEmpty(publicationType))
                materialsBlock += $" : {publicationType}";

            if (!string.IsNullOrEmpty(eventPlace) && !string.IsNullOrEmpty(eventDate))
                materialsBlock += $", {eventPlace}, {eventDate}";
            else if (!string.IsNullOrEmpty(eventPlace))
                materialsBlock += $", {eventPlace}";
            else if (!string.IsNullOrEmpty(eventDate))
                materialsBlock += $", {eventDate}";

            if (!string.IsNullOrEmpty(partCount))
                materialsBlock += $" : в {partCount} ч.";

            if (!string.IsNullOrEmpty(partNumberAndTitle))
                materialsBlock += $" {partNumberAndTitle}";

            List<string> fmtMaterialsAuthors = materialsAuthors.Select(NameFormatting).ToList();
            List<string> revMaterialsAuthors = fmtMaterialsAuthors.Select(ReverseAuthorName).ToList();
            int countMatAuthors = revMaterialsAuthors.Count;

            string editorsBlock = "";
            if (editors.Count > 0)
            {
                if (editorType.Equals("Под редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Под общей редакцией", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"под общей редакцией {string.Join(", ", editors)}";
                else if (editorType.Equals("Ответственный редактор", StringComparison.OrdinalIgnoreCase))
                    editorsBlock = $"ответственный редактор {string.Join(", ", editors)}";
                else
                    editorsBlock = $"под редакцией {string.Join(", ", editors)}";
            }

            string materialsRespBlock = "";

            if (countMatAuthors >= 5 && cbCPCAConferenceAuthors.Checked)
            {
                string firstThree = string.Join(", ", revMaterialsAuthors.Take(3));
                materialsRespBlock = $"{firstThree} [и другие]";
            }
            else if (countMatAuthors > 0)
            {
                materialsRespBlock = string.Join(", ", revMaterialsAuthors);
            }

            List<string> respParts = new List<string>();
            if (!string.IsNullOrEmpty(materialsRespBlock))
                respParts.Add(materialsRespBlock);
            if (!string.IsNullOrEmpty(organization))
                respParts.Add(organization);
            if (!string.IsNullOrEmpty(editorsBlock))
                respParts.Add(editorsBlock);

            if (respParts.Count > 0)
                materialsBlock += $" / {string.Join(" ; ", respParts)}";

            string imprint = cbCPCAPublisher.Checked
                ? $"{CombinePlacesAndGroupedPublishers(places, groupedPublishersCPConferenceArticle)}, {year}"
                : $"{CombinePlacesAndPublishers(places, publishers)}, {year}";

            string pagesBlock = $"С. {pages}";

            List<string> blocks = new List<string>();
            blocks.Add(articleBlock.TrimEnd('.'));
            blocks.Add($"{contentBlock.TrimEnd('.')} // {materialsBlock.TrimEnd('.')}");
            blocks.Add(imprint.TrimEnd('.'));
            blocks.Add(pagesBlock.TrimEnd('.'));

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbCPCAArticleAuthors.Items.Clear();
                lbCPCAConferenceAuthors.Items.Clear();
                lbCPCAEditor.Items.Clear();
                lbCPCAPublishingLocation.Items.Clear();
                lbCPCAPublisher.Items.Clear();
                lbCPCAPublishingLocationSelect.Items.Clear();
                groupedPublishersCPConferenceArticle.Clear();
                tbCPCAArticleTitle.Clear();
                tbCPCAEventTitle.Clear();
                tbCPCAPublicationType.Clear();
                tbCPCAEventPlace.Clear();
                tbCPCAEventDate.Clear();
                tbCPCAPartCount.Clear();
                tbCPCAPartNumberAndTitle.Clear();
                tbCPCAPublishYear.Clear();
                tbCPCAPages.Clear();
                tbCPCAContentType.Clear();
                tbCPCAOrganization.Clear();
                cbCPCAPublisher.Checked = false;
                UpdateListCheckBox(lbCPCAArticleAuthors, 1, 5);
                UpdateListCheckBox(lbCPCAConferenceAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ЖУРНАЛА" ----------------------------

        private void buttonCPJAArticleAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPJAArticleAuthors, lbCPJAArticleAuthors);
        }

        private void ProcessJournalArticle()
        {
            List<string> errors = new();

            List<string> authors = GetStringsList(lbCPJAArticleAuthors);
            string articleTitle = tbCPJAArticleTitle.Text.Trim();
            string journalName = tbCPJAJournalName.Text.Trim();
            string year = tbCPJAPublishYear.Text.Trim();
            string combinedNumber = tbCPJANumberOrVolume.Text.Trim();
            string issue = tbCPJAIssue.Text.Trim();
            string pages = tbCPJAPages.Text.Trim();
            string series = tbCPJAJournalSeries.Text.Trim();
            string doi = tbCPJADOI.Text.Trim();
            string url = tbCPJAURL.Text.Trim();
            string accessDate = tbCPJAAccessDate.Text.Trim();
            string accessMode = tbCPJAAccessMode.Text.Trim();
            string contentType = tbCPJAContentType.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указаны авторы статьи");
            if (string.IsNullOrWhiteSpace(articleTitle)) errors.Add("Не указано заглавие статьи");
            if (string.IsNullOrWhiteSpace(journalName)) errors.Add("Не указано название журнала");
            if (string.IsNullOrWhiteSpace(year)) errors.Add("Не указан год");
            if (string.IsNullOrWhiteSpace(pages)) errors.Add("Не указан диапазон страниц");

            bool isElectronic = !string.IsNullOrWhiteSpace(url) || !string.IsNullOrWhiteSpace(doi);
            if (isElectronic && string.IsNullOrWhiteSpace(accessDate))
                errors.Add("Укажите дату обращения (для электронных статей)");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            int countA = reversedAuthors.Count;

            string authorBlock;

            if (cbCPJAArticleAuthors.Checked || countA >= 5)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                authorBlock = $"{articleTitle} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                authorBlock = $"{authorsWithComma[0]} {articleTitle} / {reversedAuthors[0]}";
            }
            else if (countA is 2 or 3)
            {
                authorBlock = $"{authorsWithComma[0]} {articleTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA == 4)
            {
                authorBlock = $"{articleTitle} / {string.Join(", ", reversedAuthors)}";
            }
            else
            {
                authorBlock = articleTitle;
            }

            string doiBlock = string.IsNullOrWhiteSpace(doi) ? "" : $"DOI {doi}";
            string contentBlock = string.IsNullOrWhiteSpace(contentType)
                ? "Текст : непосредственный"
                : contentType;

            string journalBlock = journalName;
            if (!string.IsNullOrWhiteSpace(series))
                journalBlock += $". Серия: {series}";

            journalBlock += ". – " + year;

            List<string> numberParts = new();
            if (!string.IsNullOrWhiteSpace(combinedNumber))
            {
                string prefix = rbCPJAVolume.Checked ? "Т." : "№";
                numberParts.Add($"{prefix} {combinedNumber}");
            }
            if (!string.IsNullOrWhiteSpace(issue))
            {
                numberParts.Add($"вып. {issue}");
            }

            if (numberParts.Count > 0)
                journalBlock += $". – {string.Join(", ", numberParts)}";

            journalBlock += $". – С. {pages}";

            List<string> blocks = new();
            blocks.Add(authorBlock.TrimEnd('.'));
            if (!string.IsNullOrWhiteSpace(doiBlock))
                blocks.Add(doiBlock);
            blocks.Add($"{contentBlock} // {journalBlock.TrimEnd('.')}");

            if (!string.IsNullOrWhiteSpace(url))
                blocks.Add($"URL: {url} (дата обращения: {accessDate})");

            if (!string.IsNullOrWhiteSpace(accessMode))
                blocks.Add($"Режим доступа: {accessMode}");

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

            var kindOpt = GetCurrentKind();
            if (!kindOpt.HasValue)
            {
                MessageBox.Show(
                    "Невозможно добавить: сначала выберите вкладку «Составные части → Статья из журнала».",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

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
                lbCPJAArticleAuthors.Items.Clear();
                tbCPJAArticleTitle.Clear();
                tbCPJAJournalName.Clear();
                tbCPJAPublishYear.Clear();
                tbCPJANumberOrVolume.Clear();
                tbCPJAIssue.Clear();
                tbCPJAJournalSeries.Clear();
                tbCPJAPages.Clear();
                tbCPJADOI.Clear();
                tbCPJAURL.Clear();
                tbCPJAAccessDate.Clear();
                tbCPJAAccessMode.Clear();
                tbCPJAContentType.Clear();
                cbCPJAArticleAuthors.Checked = false;
                UpdateListCheckBox(lbCPJAArticleAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ ИЗ ГАЗЕТЫ" ----------------------------

        private void buttonCPNAArticleAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPNAArticleAuthors, lbCPNAArticleAuthors);
        }

        private void ProcessNewspaperArticle()
        {
            List<string> errors = new();

            List<string> authors = GetStringsList(lbCPNAArticleAuthors);
            string articleTitle = tbCPNAArticleTitle.Text.Trim();
            string note = tbCPNAArticleNote.Text.Trim();
            string interviewer = tbCPNAInterviewer.Text.Trim();
            string contentType = tbCPNAContentType.Text.Trim();
            string newspaperName = tbCPNANewspaperName.Text.Trim();
            string year = tbCPNAPublishYear.Text.Trim();
            string date = tbCPNAReleaseDate.Text.Trim();
            string number = tbCPNANumber.Text.Trim();
            string pages = tbCPNAPages.Text.Trim();

            if (authors.Count == 0) errors.Add("Не указаны авторы статьи");
            if (string.IsNullOrWhiteSpace(articleTitle)) errors.Add("Не указано заглавие статьи");
            if (string.IsNullOrWhiteSpace(newspaperName)) errors.Add("Не указано название газеты");
            if (string.IsNullOrWhiteSpace(year)) errors.Add("Не указан год");
            if (string.IsNullOrWhiteSpace(date)) errors.Add("Не указана дата выпуска");
            if (string.IsNullOrWhiteSpace(number)) errors.Add("Не указан номер выпуска");
            if (string.IsNullOrWhiteSpace(pages)) errors.Add("Не указан диапазон страниц");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();

            string authorBlock = $"{authorsWithComma[0]} {articleTitle}";

            if (!string.IsNullOrWhiteSpace(note))
            {
                string noteBlock = note.Trim();

                if (!string.IsNullOrWhiteSpace(interviewer))
                {
                    noteBlock += $" / [записал {interviewer}";
                }

                authorBlock += $" : [{noteBlock}]";
            }

            string contentBlock = string.IsNullOrWhiteSpace(contentType)
                ? "Текст : непосредственный"
                : contentType;

            string newspaperBlock = $"{newspaperName}. – {year}. – {date} (№ {number}). – С. {pages}";

            List<string> blocks = new();
            blocks.Add($"{authorBlock}. – {contentBlock} // {newspaperBlock}");

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbCPNAArticleAuthors.Items.Clear();
                tbCPNAArticleTitle.Clear();
                tbCPNAArticleNote.Clear();
                tbCPNAInterviewer.Clear();
                tbCPNAContentType.Clear();
                tbCPNANewspaperName.Clear();
                tbCPNAPublishYear.Clear();
                tbCPNAReleaseDate.Clear();
                tbCPNANumber.Clear();
                tbCPNAPages.Clear();
                UpdateListCheckBox(lbCPNAArticleAuthors, 1, 5);
            }
        }

        // ------------------------- ТИП "СТАТЬЯ С САЙТА" ----------------------------

        private void buttonCPWAArticleAuthorsAdd_Click(object sender, EventArgs e)
        {
            AddStringToListBox(tbCPWAArticleAuthors, lbCPWAArticleAuthors);
        }

        private void ProcessWebsiteArticle()
        {
            List<string> authors = GetStringsList(lbCPWAArticleAuthors);
            string articleTitle = tbCPWAArticleTitle.Text.Trim();
            string materialType = tbCPWAMaterialType.Text.Trim();
            string publicationType = tbCPWAPublicationType.Text.Trim();
            string eventLocation = tbCPWAEventPlace.Text.Trim();
            string eventDate = tbCPWAEventDate.Text.Trim();
            string contentType = tbCPWAContentType.Text.Trim();
            string websiteName = tbCPWAWebsiteName.Text.Trim();
            string resourceDescription = tbCPWAResourceDescription.Text.Trim();
            string resourceType = tbCPWAResourceType.Text.Trim();
            string url = tbCPWAURL.Text.Trim();
            string publishDate = tbCPWAPublishDate.Text.Trim();
            string publishYear = tbCPWAPublishYear.Text.Trim();
            string accessDate = tbCPWAAccessDate.Text.Trim();

            List<string> errors = new();
            if (string.IsNullOrWhiteSpace(articleTitle)) errors.Add("Не указано заглавие статьи");
            if (string.IsNullOrWhiteSpace(websiteName)) errors.Add("Не указано название сайта");
            if (string.IsNullOrWhiteSpace(url)) errors.Add("Не указан URL");

            if (errors.Count > 0)
            {
                MessageBox.Show("Пожалуйста, заполните:\n" + string.Join("\n", errors),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> formattedAuthors = authors.Select(NameFormatting).ToList();
            List<string> reversedAuthors = formattedAuthors.Select(ReverseAuthorName).ToList();
            List<string> authorsWithComma = formattedAuthors.Select(EnsureComma).ToList();
            int countA = reversedAuthors.Count;

            List<string> preParts = new();
            if (!string.IsNullOrWhiteSpace(materialType))
                preParts.Add(materialType);
            if (!string.IsNullOrWhiteSpace(publicationType))
            {
                string pub = publicationType;
                if (!string.IsNullOrWhiteSpace(eventLocation))
                    pub += $", {eventLocation}";
                if (!string.IsNullOrWhiteSpace(eventDate))
                    pub += $", {eventDate}";
                preParts.Add(pub);
            }

            string articleWithTypes = preParts.Count == 0
                ? articleTitle
                : $"{articleTitle} : {string.Join(" : ", preParts)}";

            string authorBlock;
            if (cbCPWAArticleAuthors.Checked || countA >= 5)
            {
                string firstThree = string.Join(", ", reversedAuthors.Take(3));
                authorBlock = $"{articleWithTypes} / {firstThree} [и другие]";
            }
            else if (countA == 1)
            {
                authorBlock = $"{authorsWithComma[0]} {articleWithTypes} / {reversedAuthors[0]}";
            }
            else if (countA is 2 or 3)
            {
                authorBlock = $"{authorsWithComma[0]} {articleWithTypes} / {string.Join(", ", reversedAuthors)}";
            }
            else if (countA == 4)
            {
                authorBlock = $"{articleWithTypes} / {string.Join(", ", reversedAuthors)}";
            }
            else
            {
                authorBlock = articleWithTypes;
            }

            string contentBlock = string.IsNullOrWhiteSpace(contentType)
                ? "Текст : электронный"
                : contentType;

            string siteBlock = $"// {websiteName}";
            if (!string.IsNullOrWhiteSpace(resourceDescription))
                siteBlock += $" : {resourceDescription}";
            if (!string.IsNullOrWhiteSpace(resourceType))
                siteBlock += $" : {resourceType}";

            string urlBlock = $"URL: {url}";
            if (!string.IsNullOrWhiteSpace(accessDate))
                urlBlock += $" (дата обращения: {accessDate})";

            List<string> blocks = new();
            blocks.Add($"{authorBlock.TrimEnd('.')}. – {contentBlock.TrimEnd('.')} {siteBlock.TrimEnd('.')}");

            if (!string.IsNullOrWhiteSpace(publishYear))
            {
                blocks.Add(publishYear.TrimEnd('.'));
                if (!string.IsNullOrWhiteSpace(publishDate))
                    blocks.Add(publishDate.TrimEnd('.'));
            }

            blocks.Add(urlBlock.TrimEnd('.'));

            if (string.IsNullOrWhiteSpace(publishYear) && !string.IsNullOrWhiteSpace(publishDate))
                blocks.Add($"Дата публикации: {publishDate.TrimEnd('.')}");

            string result = string.Join(". – ", blocks) + ".";
            result = ApplyAbbreviations(result);

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
                lbCPWAArticleAuthors.Items.Clear();
                tbCPWAArticleTitle.Clear();
                tbCPWAMaterialType.Clear();
                tbCPWAPublicationType.Clear();
                tbCPWAEventPlace.Clear();
                tbCPWAEventDate.Clear();
                tbCPWAContentType.Clear();
                tbCPWAWebsiteName.Clear();
                tbCPWAResourceDescription.Clear();
                tbCPWAResourceType.Clear();
                tbCPWAURL.Clear();
                tbCPWAPublishDate.Clear();
                tbCPWAPublishYear.Clear();
                tbCPWAAccessDate.Clear();
                cbCPWAArticleAuthors.Checked = false;
                UpdateListCheckBox(lbCPWAArticleAuthors, 1, 5);
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
                    RegexOptions.Singleline);

                var rgMLA = new Regex(
                    @"^(?<mlaAuthors>[^""“”«»]+?)\s*[\""“”«»](?<mlaTitle>[^""“”«»]+)[\""“”«»]" +
                    @"(?=.*\bpp\.?\s*(?<pages>\d{1,4}(?:\s*[-–—-]\s*\d{1,4})?))" +
                    @"(?:(?=.*\bvol\.\s*(?<vol>\d{1,4})))?" +
                    @"(?:(?=.*\bno\.\s*(?<no>\d{1,4})))?" +
                    @"(?:(?=.*doi:(?<doi>10\.\d{4,9}/[-._;()/:A-Z0-9]+)))?.*$",
                    RegexOptions.Singleline | RegexOptions.IgnoreCase);

                var mG = rgGOST.Match(gostRaw);
                if (!mG.Success)
                {
                    MessageBox.Show("Строка ГОСТ не распознана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string journal = mG.Groups["journal"].Value.Trim();
                string year = mG.Groups["year"].Value;
                string gostNo = mG.Groups["issue"].Value.Trim();
                string url = mG.Groups["url"].Value.Trim();
                string accDate = mG.Groups["access"].Value;

                var mM = rgMLA.Match(mlaRaw);
                if (!mM.Success)
                {
                    MessageBox.Show("Строка MLA не распознана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rawAuth = mM.Groups["mlaAuthors"].Value
                    .TrimEnd('.', ' ')
                    .Replace(" and ", ",", StringComparison.OrdinalIgnoreCase);
                var authors = rawAuth
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => NameFormatting(a.Trim()))
                    .ToArray();
                string title = mM.Groups["mlaTitle"].Value.Trim();
                string pages = mM.Groups["pages"].Value;
                string vol = mM.Groups["vol"].Value;
                string noMla = mM.Groups["no"].Value;
                string doi = mM.Groups["doi"].Value;

                string res;
                int n = authors.Length;
                if (n <= 3)
                {
                    res = EnsureComma(authors[0]) + " " + title + " / " +
                          string.Join(", ", authors.Select(ReverseAuthorName)) + ". – ";
                }
                else
                {
                    res = title + " / ";
                    if (n == 4)
                        res += string.Join(", ", authors.Select(ReverseAuthorName)) + ". – ";
                    else
                        res += string.Join(", ", authors.Take(3).Select(ReverseAuthorName)) + " [и др.]. – ";
                }
                if (!string.IsNullOrEmpty(doi))
                    res += "DOI " + doi + ". – ";
                res += "Текст : электронный // " + journal + ". – " + year;
                if (!string.IsNullOrEmpty(vol))
                {
                    res += ". – Т. " + vol;
                    if (!string.IsNullOrEmpty(noMla))
                        res += ", вып. " + noMla;
                    res += ".";
                }
                else if (!string.IsNullOrEmpty(noMla))
                {
                    res += ". – № " + noMla + ".";
                }
                else if (!string.IsNullOrEmpty(gostNo))
                {
                    res += ". – № " + gostNo + ".";
                }
                if (!string.IsNullOrEmpty(pages))
                    res += " – С. " + pages + ".";
                res += " – URL: " + url + " (дата обращения: " + accDate + ").";

                if (!tsmiUnableClearingRichTextBox1.Checked)
                    rtbGOST.Clear();
                if (!tsmiUnableClearingRichTextBox2.Checked)
                    rtbMLA.Clear();

                RememberCurrentState(out var snap, out int catIx, out int typeIx);

                // для конвертации это просто пустой словарь и false
                var kind = GetCurrentKind() ?? SourceKind.SVDissertation;
                var (pubSnap, smartOn) = GetPublisherSnapshot(kind);

                // собираем SavedEntry, но запрещаем восстановления
                var saved = new SavedEntry(
                    res,
                    catIx,
                    typeIx,
                    snap,
                    kind,
                    pubSnap,
                    smartOn,
                    false
                );

                _lastSavedResult = new ResultItem<SavedEntry>(res, saved);
                _undoManager.AddItem(lbResult, _lastSavedResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неожиданная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFillForm_Click(object sender, EventArgs e)
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
                    RegexOptions.Singleline);

                var rgMLA = new Regex(
                  @"^(?<mlaAuthors>[^""“”«»]+?)\s*[\""“”«»](?<mlaTitle>[^""“”«»]+)[\""“”«»]" +
                  @"(?=.*\bpp\.?\s*(?<pages>\d{1,4}(?:\s*[-–—-]\s*\d{1,4})?))" +
                  @"(?:(?=.*\bvol\.\s*(?<vol>\d{1,4})))?" +
                  @"(?:(?=.*\bno\.\s*(?<no>\d{1,4}(?:\s*\([^)]*\))?)))?" +
                  @"(?:(?=.*doi:(?<doi>10\.\d{4,9}\/[-._;()\/:A-Z0-9]+)))?.*$",
                  RegexOptions.Singleline | RegexOptions.IgnoreCase);

                var mG = rgGOST.Match(gostRaw);
                if (!mG.Success)
                {
                    MessageBox.Show("Строка ГОСТ не распознана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string journal = mG.Groups["journal"].Value.Trim();
                string year = mG.Groups["year"].Value;
                string gostNo = mG.Groups["issue"].Value.Trim();
                string url = mG.Groups["url"].Value.Trim();
                string accDate = mG.Groups["access"].Value;

                var mM = rgMLA.Match(mlaRaw);
                if (!mM.Success)
                {
                    MessageBox.Show("Строка MLA не распознана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string rawAuth = mM.Groups["mlaAuthors"].Value
                    .TrimEnd('.', ' ')
                    .Replace(" and ", ",", StringComparison.OrdinalIgnoreCase);
                var authors = rawAuth
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => NameFormatting(a.Trim()))
                    .ToArray();

                string title = mM.Groups["mlaTitle"].Value.Trim();
                string pages = mM.Groups["pages"].Value;
                string vol = mM.Groups["vol"].Value;
                string noMla = mM.Groups["no"].Value;
                string doi = mM.Groups["doi"].Value;

                lbCPJAArticleAuthors.Items.Clear();
                foreach (var a in authors.Select(ReverseAuthorName))
                {
                    lbCPJAArticleAuthors.Items.Add(a);
                    UpdateListCheckBox(lbCPJAArticleAuthors, 1, 5);
                }

                tbCPJAArticleTitle.Text = title;
                tbCPJAJournalName.Text = journal;
                tbCPJAPublishYear.Text = year;
                tbCPJAPages.Text = pages;
                tbCPJADOI.Text = doi;
                tbCPJAURL.Text = url;
                tbCPJAAccessDate.Text = accDate;

                if (!string.IsNullOrEmpty(vol))
                {
                    tbCPJANumberOrVolume.Text = vol;
                    rbCPJAVolume.Checked = true;
                    if (!string.IsNullOrEmpty(noMla))
                        tbCPJAIssue.Text = noMla;
                }
                else if (!string.IsNullOrEmpty(noMla))
                {
                    tbCPJANumberOrVolume.Text = noMla;
                    rbCPJANumber.Checked = true;
                }
                else if (!string.IsNullOrEmpty(gostNo))
                {
                    tbCPJANumberOrVolume.Text = gostNo;
                    rbCPJANumber.Checked = true;
                }

                if (tcCategories.SelectedTab != tpConstituentParts ||
                    tcCPTypes.SelectedTab != tpCPJournalArticle)
                {
                    tcCategories.SelectedTab = tpConstituentParts;
                    tcCPTypes.SelectedTab = tpCPJournalArticle;
                }

                if (!tsmiUnableClearingRichTextBox1.Checked)
                    rtbGOST.Clear();
                if (!tsmiUnableClearingRichTextBox2.Checked)
                    rtbMLA.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неожиданная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Единая функция для кнопки "Добавить", которая определяет активные вкладки
        // и вызывает функцию формирования записи для соответствующего типа источника.
        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (tcCategories.SelectedTab == tpSingleVolume)
            {
                if (tcSVTypes.SelectedTab == tpSVBook)
                {
                    ProcessBook();
                }
                else if (tcSVTypes.SelectedTab == tpSVConferenceMaterials)
                {
                    ProcessConferenceMaterials();
                }
                else if (tcSVTypes.SelectedTab == tpSVGOST)
                {
                    ProcessGOST();
                }
                else if (tcSVTypes.SelectedTab == tpSVLegislativeMaterial)
                {
                    ProcessLegislativeMaterial();
                }
                else if (tcSVTypes.SelectedTab == tpSVDissertationAbstract)
                {
                    ProcessDissertationAbstract();
                }
                else if (tcSVTypes.SelectedTab == tpSVDissertation)
                {
                    ProcessDissertation();
                }
            }
            else if (tcCategories.SelectedTab == tpMultiVolume)
            {
                if (tcMVTypes.SelectedTab == tpMVWholeMultivolume)
                {
                    ProcessWholeMultivolume();
                }
                else if (tcMVTypes.SelectedTab == tpMVSeparateVolume)
                {
                    ProcessSeparateVolume();
                }
            }
            else if (tcCategories.SelectedTab == tpElectronicResources)
            {
                if (tcERTypes.SelectedTab == tpEREbook)
                {
                    ProcessEbook();
                }
                else if (tcERTypes.SelectedTab == tpERWholeElectronicEdition)
                {
                    ProcessWholeElectronicEdition();
                }
                else if (tcERTypes.SelectedTab == tpERElectronicEditionSeparateVolume)
                {
                    ProcessElectronicEditionSeparateVolume();
                }
                else if (tcERTypes.SelectedTab == tpERElectronicConferenceMaterials)
                {
                    ProcessElectronicConferenceMaterials();
                }
                else if (tcERTypes.SelectedTab == tpERElectronicCollections)
                {
                    ProcessElectronicCollections();
                }
                else if (tcERTypes.SelectedTab == tpEREjournalArticle)
                {
                    ProcessEjournalArticle();
                }
                else if (tcERTypes.SelectedTab == tpERMultimediaEdition)
                {
                    ProcessMultimediaEdition();
                }
                else if (tcERTypes.SelectedTab == tpERWebsite)
                {
                    ProcessWebsite();
                }
            }
            else if (tcCategories.SelectedTab == tpConstituentParts)
            {
                if (tcCPTypes.SelectedTab == tpCPBookArticle)
                {
                    ProcessBookArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPConferenceArticle)
                {
                    ProcessConferenceArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPJournalArticle)
                {
                    ProcessJournalArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPNewspaperArticle)
                {
                    ProcessNewspaperArticle();
                }
                else if (tcCPTypes.SelectedTab == tpCPWebsiteArticle)
                {
                    ProcessWebsiteArticle();
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

        private void buttonToGOST2008_Click(object sender, EventArgs e)
        {
            this.Hide();
            GOST2008 gost2008 = new GOST2008(this);
            gost2008.Show();
        }

        private void GOST2018_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}