using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Элемент списка результатов: хранит и отображаемый текст, и «сырые» данные для восстановления состояния.
    /// </summary>
    internal class ResultItem<TEntry>
    {
        public string Text { get; }
        public TEntry Entry { get; }

        public ResultItem(string text, TEntry entry)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Entry = entry ?? throw new ArgumentNullException(nameof(entry));
        }

        // ListBox будет вызывать ToString(), чтобы отобразить элемент
        public override string ToString() => Text;
    }
}

