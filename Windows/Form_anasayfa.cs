using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Araba.Windows
{
    public partial class Form_anasayfa : Form
    {
        public Form_anasayfa()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {
            Arabalar arabalar = new Arabalar();
            arabalar.ShowDialog();
        }

        private void button_markalar_Click(object sender, EventArgs e)
        {
            Form_ortak ortak = new Form_ortak();
            ortak.ShowDialog();
        }

        private void button_yakitlar_Click(object sender, EventArgs e)
        {
            Form_ortak ortak = new Form_ortak();
            ortak.eklemeTuru = "yakitlar";
            ortak.ShowDialog();
        }

        private void button_renkler_Click(object sender, EventArgs e)
        {
            Form_ortak ortak = new Form_ortak();
            ortak.eklemeTuru = "renkler";
            ortak.ShowDialog();
        }
    }
}
