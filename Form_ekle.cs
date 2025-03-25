using System.Data;
using System.Security.Policy;
using WinFormsApp_Araba.model;

namespace WinFormsApp_Araba
{
    public partial class Form_ekle : Form
    {
        public Araba _araba = null!;
        Veritabani vt = new();

        public Form_ekle(Veritabani _vt)
        {
            InitializeComponent();
            vt = _vt;
        }

        private void Form_ekle_Load(object sender, EventArgs e)
        {
            label1.Text = "Araba Ekle";

            dateTimePicker_arabaYili.CustomFormat = "yyyy";
            dateTimePicker_arabaYili.MaxDate = DateTime.Now;

            comboBox_arabaMarka.DataSource = vt.tumMarkalar();
            comboBox_arabaMarka.ValueMember = "Id";
            comboBox_arabaMarka.DisplayMember = "adi";

            comboBox_arabaRenk.DataSource = vt.tumRenkler();
            comboBox_arabaRenk.ValueMember = "Id";
            comboBox_arabaRenk.DisplayMember = "adi";

            comboBox_yakit.DataSource = vt.tumYakitlar();
            comboBox_yakit.ValueMember = "Id";
            comboBox_yakit.DisplayMember = "tur";

            if (_araba != null) AlanlariDoldur();
        }

        private void AlanlariDoldur()
        {
            string model = _araba.model;
            Text = $"Araba Düzenle: {model}";
            label1.Text = $"Araba Düzenle: {model}";
            textBox_arabaModel.Text = model;

            textBox_fiyat.Text = _araba.fiyat.ToString(); 
            textBox_garantiSuresi.Text = _araba.garantiSuresi.ToString();

            checkBox_hasar.Checked = Convert.ToBoolean(_araba.hasar);
            checkBox_kiralik.Checked = Convert.ToBoolean(_araba.kiralik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_arabaModel.Text == "" || 
                textBox_garantiSuresi.Text == "" || 
                textBox_fiyat.Text == "") {
                YardimciFonksiyonlar.mesajKutusu("Lütfen Tüm Alanları Doldurun", MessageBoxIcon.Information);
            } else {
                if(kontrol()) {
                    Araba araba         = new Araba();
                    araba.hasar         = checkBox_hasar.Checked;
                    araba.model         = textBox_arabaModel.Text;
                    araba.kiralik       = checkBox_kiralik.Checked;
                    araba.fiyat         = Convert.ToInt32(textBox_fiyat.Text);
                    araba.yil           = Convert.ToInt32(dateTimePicker_arabaYili.Text);
                    araba.yakitID       = Convert.ToInt32(comboBox_yakit.SelectedValue);
                    araba.renkID        = Convert.ToInt32(comboBox_arabaRenk.SelectedValue);
                    araba.garantiSuresi = Convert.ToInt32(textBox_garantiSuresi.Text);
                    araba.markaID       = Convert.ToInt32(comboBox_arabaMarka.SelectedValue);
                    if (_araba != null) { vt.arabaDuzenle(_araba, araba); } else { vt.arabaEkle(araba); }
                }
            }
        }

        private bool kontrol()
        {
            bool devam = true;

            if(!Int32.TryParse(textBox_fiyat.Text, out int fiyat)) { YardimciFonksiyonlar.mesajKutusu("Fiyatta boyut sınırına ulaştınız", MessageBoxIcon.Information); devam = false; }
            if(!Int32.TryParse(textBox_garantiSuresi.Text, out int garantiSuresi)) { YardimciFonksiyonlar.mesajKutusu("Garanti Süresinde boyut sınırına ulaştınız", MessageBoxIcon.Information); devam = false; }
        
            return devam;
        }
    }
}
