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

namespace WinFormsApp_Araba
{
    public partial class Arabalar : Form
    {
        Veritabani vt = new();

        public Arabalar()
        {
            InitializeComponent();
        }

        private void Arabalar_Load(object sender, EventArgs e)
        {
            dataGridView_Ayarla();

            comboBox_islemler.DataSource = new List<string>()
            {
                "Tüm Araçaları Listele", "Markaya Göre", "Modele Göre", "Benzin Türüne Göre"
            };
        }

        private void dataGridView_Ayarla()
        {
            dataGridView_arabalar.AutoGenerateColumns = false;
            dataGridView_arabalar.DataSource = vt.tumArabalariGetir();

            Column_marka.DataPropertyName = "marka";
            Column_model.DataPropertyName = "model";
            Column_fiyat.DataPropertyName = "fiyat";
            Column_benzin.DataPropertyName = "benzin";
            Column_hasar.DataPropertyName = "hasar";
            Column_kiralik.DataPropertyName = "kiralik";
            Column_yil.DataPropertyName = "yil";
            Column_garantiSuresi.DataPropertyName = "garantiSuresi";
        }

        private void dataGridView_arabalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            Araba araba = (Araba)dataGridView_arabalar.Rows[e.RowIndex].DataBoundItem;
            
            if(colIndex == 8 || colIndex == 9) dataGridView_Ayarla();

            if (colIndex == 8) {
                Form_ekle arabaDuzenle = new Form_ekle(vt);
                arabaDuzenle._araba = araba;
                arabaDuzenle.ShowDialog();
                dataGridView_arabalar.Refresh();
            } else if (colIndex == 9)
            {
                DialogResult durum = YardimciFonksiyonlar.mesajKutusu($"Silmek ister misiniz?", MessageBoxIcon.Information, MessageBoxButtons.YesNo);
                if (durum == DialogResult.Yes)
                {
                    vt.arabaSil(araba);
                    dataGridView_arabalar.Refresh();
                }
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            string aranacakMetin = textBox_ara.Text;

            switch (comboBox_islemler.SelectedIndex)
            {
                case 0: dataGridView_arabalar.DataSource = vt.tumArabalariGetir(); break;
            }
        }

        private void button_arabaEkle_Click(object sender, EventArgs e)
        {
            Form_ekle form = new Form_ekle(vt);
            form.ShowDialog();
            dataGridView_arabalar.Refresh();
        }
    }
}
