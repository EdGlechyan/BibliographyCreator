using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class CleanPasteHelper
    {
        private const int EM_REPLACESEL = 0xC2;             // стандартное сообщение Edit/RichEdit
                                                            // wParam = 1 → операция попадает в undo-буфер

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        /// <summary>Вставляет текст из буфера обмена без &lt;CR&gt;/&lt;LF&gt;, сохраняя штатный undo.</summary>
        public static void PasteWithoutNewlines(TextBoxBase tb)
        {
            if (!Clipboard.ContainsText()) return;

            string plain = Clipboard.GetText()
                                    .Replace("\r", string.Empty)
                                    .Replace("\n", string.Empty);

            // EM_REPLACESEL c wParam == 1 добавляет операцию в системный undo-стек контрола
            SendMessage(tb.Handle, EM_REPLACESEL, new IntPtr(1), plain);
        }
    }
}
