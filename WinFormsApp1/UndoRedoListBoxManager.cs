using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

internal sealed class UndoRedoListBoxManager
{
    // Для каждого ListBox храним два стека команд: Do/Undo
    private readonly Dictionary<ListBox, Stack<(Action Do, Action Undo)>> _undoStacks
        = new();
    private readonly Dictionary<ListBox, Stack<(Action Do, Action Undo)>> _redoStacks
        = new();

    // События для подписки
    public event Action<ListBox, object, int>? ItemAdded;
    public event Action<ListBox, object, int>? ItemRemoved;
    public event Action<ListBox>? ItemsCleared;

    /// <summary>
    /// Инициализировать историю для данного ListBox.
    /// </summary>
    public void Register(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        EnsureRegistered(lb);
    }

    private void EnsureRegistered(ListBox lb)
    {
        if (!_undoStacks.ContainsKey(lb))
        {
            _undoStacks[lb] = new Stack<(Action, Action)>();
            _redoStacks[lb] = new Stack<(Action, Action)>();
        }
    }

    /// <summary>
    /// Общая обёртка для выполнения операции и записи в историю.
    /// </summary>
    public void Execute(ListBox lb, Action doAction, Action undoAction)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (doAction == null) throw new ArgumentNullException(nameof(doAction));
        if (undoAction == null) throw new ArgumentNullException(nameof(undoAction));

        EnsureRegistered(lb);
        doAction();
        _undoStacks[lb].Push((doAction, undoAction));
        _redoStacks[lb].Clear();
    }

    /// <summary>
    /// Добавить элемент с поддержкой Undo/Redo.
    /// </summary>
    public void AddItem(ListBox lb, object item)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (item == null) throw new ArgumentNullException(nameof(item));

        Execute(
            lb,
            // Do: добавить и поднять событие
            () =>
            {
                lb.Items.Add(item);
                ItemAdded?.Invoke(lb, item, lb.Items.Count - 1);
            },
            // Undo: найти и удалить, поднять событие
            () =>
            {
                int idx = lb.Items.IndexOf(item);
                if (idx >= 0)
                {
                    lb.Items.RemoveAt(idx);
                    ItemRemoved?.Invoke(lb, item, idx);
                }
            }
        );
    }

    /// <summary>
    /// Удалить выбранный элемент (Delete/Backspace) с поддержкой Undo/Redo.
    /// </summary>
    public void DeleteItem(ListBox lb)
    {
        var item = lb.SelectedItem;
        if (item == null) return;

        // Сохраняем исходный индекс ДО удаления
        int originalIndex = lb.Items.IndexOf(item);
        if (originalIndex < 0) return;

        Execute(
            lb,
            // Do: удалить и поднять событие
            () =>
            {
                lb.Items.RemoveAt(originalIndex);
                ItemRemoved?.Invoke(lb, item, originalIndex);
            },
            // Undo: вставить обратно в ту же позицию
            () =>
            {
                // если уже есть — пропускаем
                if (lb.Items.Contains(item)) return;

                int idx = Math.Clamp(originalIndex, 0, lb.Items.Count);
                lb.Items.Insert(idx, item);
                ItemAdded?.Invoke(lb, item, idx);
            }
        );
    }

    /// <summary>
    /// Очистить все элементы с поддержкой Undo/Redo.
    /// </summary>
    public void ClearItems(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        var backup = lb.Items.Cast<object>().ToList();

        Execute(
            lb,
            // Do: очистить и поднять событие
            () =>
            {
                lb.Items.Clear();
                ItemsCleared?.Invoke(lb);
            },
            // Undo: восстановить и поднять событие
            () =>
            {
                lb.Items.Clear();
                foreach (var it in backup)
                    lb.Items.Add(it);
                ItemsCleared?.Invoke(lb);
            }
        );
    }

    public void EditItem(ListBox lb, int index, object newItem)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (newItem == null) throw new ArgumentNullException(nameof(newItem));
        EnsureRegistered(lb);

        // сохраняем сам старый объект
        var oldItem = lb.Items[index];

        Execute(
            lb,
            // Do: найти и заменить старый элемент на новый
            () =>
            {
                int i = lb.Items.IndexOf(oldItem);
                if (i >= 0 && i < lb.Items.Count)
                    lb.Items[i] = newItem;
            },
            // Undo: найти и вернуть на место старый элемент
            () =>
            {
                int i = lb.Items.IndexOf(newItem);
                if (i >= 0 && i < lb.Items.Count)
                    lb.Items[i] = oldItem;
            }
        );
    }

    /// <summary>Отменить последнюю операцию для данного ListBox.</summary>
    public void Undo(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (!_undoStacks.ContainsKey(lb) || _undoStacks[lb].Count == 0) return;

        var (doAction, undoAction) = _undoStacks[lb].Pop();
        undoAction();
        _redoStacks[lb].Push((doAction, undoAction));
    }

    /// <summary>Повторить последнюю отменённую операцию.</summary>
    public void Redo(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (!_redoStacks.ContainsKey(lb) || _redoStacks[lb].Count == 0) return;

        var (doAction, undoAction) = _redoStacks[lb].Pop();
        doAction();
        _undoStacks[lb].Push((doAction, undoAction));
    }

    public bool CanUndo(ListBox lb)
        => lb != null
           && _undoStacks.ContainsKey(lb)
           && _undoStacks[lb].Count > 0;

    public bool CanRedo(ListBox lb)
        => lb != null
           && _redoStacks.ContainsKey(lb)
           && _redoStacks[lb].Count > 0;

    /// <summary>Полностью очищает историю Undo/Redo для данного ListBox.</summary>
    public void ClearHistory(ListBox lb)
    {
        if (lb == null) throw new ArgumentNullException(nameof(lb));
        if (_undoStacks.ContainsKey(lb)) _undoStacks[lb].Clear();
        if (_redoStacks.ContainsKey(lb)) _redoStacks[lb].Clear();
    }
}
