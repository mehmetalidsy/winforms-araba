using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Araba.model;

namespace WinFormsApp_Araba.Windows
{
    public partial class Form_ortak : Form
    {
        Veritabani vt = new();
        private object _ortak = null!;
        public string eklemeTuru = "marka";

        public Form_ortak()
        {
            InitializeComponent();
        }

        private void Form_markalar_Load(object sender, EventArgs e)
        {
            switch (eklemeTuru)
            {
                case "marka": kaynakAyarla(vt.tumMarkalar()); break;
                case "yakitlar": ortaklariAyarla("Yakıtlar", "Yakıt"); kaynakAyarla(vt.tumYakitlar(), "tur"); break;
                case "renkler": ortaklariAyarla("Renkler", "Renk"); kaynakAyarla(vt.tumRenkler()); break;
                default: YardimciFonksiyonlar.mesajKutusu("Böyle bir tür yok"); this.Close(); break;
            }
        }

        protected void ortaklariAyarla(string pencereAdi, string ortak)
        {
            Text = pencereAdi;
            label_input.Text = $"{ortak} Adı";
            label_ortak.Text = $"{ortak} Ekle / Düzenle";
        }

        private void kaynakAyarla(object datasource, string adi = "adi", string id = "Id")
        {
            dataGridView1.DataSource = datasource;
            Column_adi.DataPropertyName = adi;
            Column_id.DataPropertyName = id;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string ortakAdi = textBox_ortak.Text;

            if (string.IsNullOrEmpty(ortakAdi))
            {
                YardimciFonksiyonlar.mesajKutusu("Lütfen gerekli alanı doldurun!", MessageBoxIcon.Information);
            }
            else
            {
                switch (eklemeTuru) {
                    case "marka":
                        Marka ortak = new Marka(); ortak.adi = ortakAdi; 
                        if (_ortak != null) { vt.markaDuzenle((Marka)_ortak, ortak); _ortak = null;} else { vt.markaEkle(ortak); }
                    break;
                    case "yakitlar":
                        Yakit ortakY = new Yakit(); ortakY.tur = ortakAdi;
                        if (_ortak != null) { vt.yakitDuzenle((Yakit)_ortak, ortakY); _ortak = null; } else { vt.yakitEkle(ortakY); }
                    break;
                    case "renkler":
                        Renk ortakR = new Renk(); ortakR.adi = ortakAdi;
                        if (_ortak != null) { vt.renkDuzenle((Renk)_ortak, ortakR); _ortak = null;} else { vt.renkEkle(ortakR); }
                    break;
                }
                dataGridView1.Refresh();
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int ortakID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column_id"].Value.ToString());
            object ortak = new object();
            
            if (eklemeTuru == "marka") { ortak = vt.tumMarkalar().First(x => x.Id == ortakID); }
            else if (eklemeTuru == "yakitlar") { ortak = vt.tumYakitlar().First(x => x.Id == ortakID); }
            else if (eklemeTuru == "renkler")  { ortak = vt.tumYakitlar().First(x => x.Id == ortakID); }

            if(colIndex == 2) {
                if (eklemeTuru == "marka") { _ortak = (Marka)ortak; }
                else if (eklemeTuru == "yakitlar") { _ortak = (Yakit)ortak; }
                else if (eklemeTuru == "renkler") { _ortak = ortak; }
                textBox_ortakAyarla(_ortak);
            } else if (colIndex == 3) {
                DialogResult durum = YardimciFonksiyonlar.mesajKutusu($"Silmek ister misiniz?", MessageBoxIcon.Information, MessageBoxButtons.YesNo);
                if (durum == DialogResult.Yes) {
                    if (eklemeTuru == "marka") { vt.markaSil((Marka)ortak); }
                    else if (eklemeTuru == "yakitlar") { vt.yakitSil((Yakit)ortak); }
                    else if (eklemeTuru == "renkler") { vt.renkSil((Renk)ortak); }
                    dataGridView1.Refresh();
                }
            }
        }

        public void textBox_ortakAyarla(object _ortak)
        {
            if (eklemeTuru == "marka") { Marka ortak = (Marka)_ortak; textBox_ortak.Text = ortak.adi; }
            else if (eklemeTuru == "yakitlar") { Yakit ortak = (Yakit)_ortak; textBox_ortak.Text = ortak.tur; }
            else if (eklemeTuru == "renkler") { Renk ortak = (Renk)_ortak; textBox_ortak.Text = ortak.adi; }
        }
    }
}
