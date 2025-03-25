using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Araba
{
    public class YardimciFonksiyonlar
    {
        public static DialogResult mesajKutusu(string text, MessageBoxIcon durum = MessageBoxIcon.None, MessageBoxButtons buttonlar = MessageBoxButtons.OK)
        {
            return MessageBox.Show(text, "Uyarı", buttonlar, durum);
        }
    }
}
