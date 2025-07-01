using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

internal sealed class FormSnapshot
{
    private readonly Dictionary<Control, object?> _values = new();
    public int Count => _values.Count;

    // Снять «фото» всех контролов внутри root
    public static FormSnapshot Capture(Control root)
    {
        var s = new FormSnapshot();
        foreach (var c in GetAll(root))
            s._values[c] = GetValue(c);
        return s;
    }

    // Вернуть значения обратно
    public void Restore()
    {
        foreach (var (ctrl, val) in _values)
            SetValue(ctrl, val);
    }

    // ---------- ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ----------

    public static IEnumerable<Control> GetAll(Control c)
    {
        foreach (Control child in c.Controls)
        {
            yield return child;
            foreach (var g in GetAll(child)) yield return g;
        }
    }

    private static object? GetValue(Control c) => c switch
    {
        TextBox tb => tb.Text,
        CheckBox cb => cb.Checked,
        RadioButton rb => rb.Checked,
        ComboBox cmb => cmb.SelectedIndex,
        ListBox lb => lb.Items.Cast<object>().ToList(),
        NumericUpDown nud => nud.Value,
        _ => null
    };

    private static void SetValue(Control c, object? v)
    {
        switch (c)
        {
            case TextBox tb when v is string s: tb.Text = s; break;
            case CheckBox cb when v is bool b: cb.Checked = b; break;
            case RadioButton rb when v is bool b: rb.Checked = b; break;
            case ComboBox cmb when v is int i: cmb.SelectedIndex = i; break;
            case ListBox lb when v is List<object> l:
                lb.Items.Clear(); lb.Items.AddRange(l.ToArray()); break;
            case NumericUpDown nud when v is decimal d: nud.Value = d; break;
        }
    }
}
