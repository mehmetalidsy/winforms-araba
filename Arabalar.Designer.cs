namespace WinFormsApp_Araba
{
    partial class Arabalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_arabalar = new DataGridView();
            Column_marka = new DataGridViewTextBoxColumn();
            Column_model = new DataGridViewTextBoxColumn();
            Column_fiyat = new DataGridViewTextBoxColumn();
            Column_garantiSuresi = new DataGridViewTextBoxColumn();
            Column_benzin = new DataGridViewTextBoxColumn();
            Column_yil = new DataGridViewTextBoxColumn();
            Column_kiralik = new DataGridViewCheckBoxColumn();
            Column_hasar = new DataGridViewCheckBoxColumn();
            Column_duzenle = new DataGridViewButtonColumn();
            Column_sil = new DataGridViewButtonColumn();
            label1 = new Label();
            button_arabaEkle = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            textBox_ara = new TextBox();
            button_ara = new Button();
            comboBox_islemler = new ComboBox();
            flowLayoutPanel_bilgi = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_arabalar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel_bilgi.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_arabalar
            // 
            dataGridView_arabalar.AllowUserToAddRows = false;
            dataGridView_arabalar.AllowUserToDeleteRows = false;
            dataGridView_arabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_arabalar.Columns.AddRange(new DataGridViewColumn[] { Column_marka, Column_model, Column_fiyat, Column_garantiSuresi, Column_benzin, Column_yil, Column_kiralik, Column_hasar, Column_duzenle, Column_sil });
            dataGridView_arabalar.Location = new Point(-1, 70);
            dataGridView_arabalar.Name = "dataGridView_arabalar";
            dataGridView_arabalar.RowHeadersWidth = 51;
            dataGridView_arabalar.Size = new Size(1347, 617);
            dataGridView_arabalar.TabIndex = 0;
            dataGridView_arabalar.CellContentClick += dataGridView_arabalar_CellContentClick;
            // 
            // Column_marka
            // 
            Column_marka.HeaderText = "Marka";
            Column_marka.MinimumWidth = 6;
            Column_marka.Name = "Column_marka";
            Column_marka.Width = 125;
            // 
            // Column_model
            // 
            Column_model.HeaderText = "Model";
            Column_model.MinimumWidth = 6;
            Column_model.Name = "Column_model";
            Column_model.Width = 125;
            // 
            // Column_fiyat
            // 
            Column_fiyat.HeaderText = "Fiyat";
            Column_fiyat.MinimumWidth = 6;
            Column_fiyat.Name = "Column_fiyat";
            Column_fiyat.Width = 125;
            // 
            // Column_garantiSuresi
            // 
            Column_garantiSuresi.HeaderText = "Garanti Süresi";
            Column_garantiSuresi.MinimumWidth = 6;
            Column_garantiSuresi.Name = "Column_garantiSuresi";
            Column_garantiSuresi.Width = 125;
            // 
            // Column_benzin
            // 
            Column_benzin.HeaderText = "Benzin";
            Column_benzin.MinimumWidth = 6;
            Column_benzin.Name = "Column_benzin";
            Column_benzin.Width = 125;
            // 
            // Column_yil
            // 
            Column_yil.HeaderText = "Yıl";
            Column_yil.MinimumWidth = 6;
            Column_yil.Name = "Column_yil";
            Column_yil.Width = 125;
            // 
            // Column_kiralik
            // 
            Column_kiralik.HeaderText = "Kiralık";
            Column_kiralik.MinimumWidth = 6;
            Column_kiralik.Name = "Column_kiralik";
            Column_kiralik.Width = 125;
            // 
            // Column_hasar
            // 
            Column_hasar.HeaderText = "Hasar";
            Column_hasar.MinimumWidth = 6;
            Column_hasar.Name = "Column_hasar";
            Column_hasar.Width = 125;
            // 
            // Column_duzenle
            // 
            Column_duzenle.HeaderText = "Düzenle";
            Column_duzenle.MinimumWidth = 6;
            Column_duzenle.Name = "Column_duzenle";
            Column_duzenle.Text = "Düzenle";
            Column_duzenle.UseColumnTextForButtonValue = true;
            Column_duzenle.Width = 125;
            // 
            // Column_sil
            // 
            Column_sil.HeaderText = "Sil";
            Column_sil.MinimumWidth = 6;
            Column_sil.Name = "Column_sil";
            Column_sil.Text = "Sil";
            Column_sil.UseColumnTextForButtonValue = true;
            Column_sil.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 89);
            label1.TabIndex = 1;
            label1.Text = "Bilgiler";
            // 
            // button_arabaEkle
            // 
            button_arabaEkle.Font = new Font("Segoe UI", 25F);
            button_arabaEkle.Location = new Point(1355, 589);
            button_arabaEkle.Name = "button_arabaEkle";
            button_arabaEkle.Size = new Size(327, 98);
            button_arabaEkle.TabIndex = 2;
            button_arabaEkle.Text = "Yeni Ekle";
            button_arabaEkle.UseVisualStyleBackColor = true;
            button_arabaEkle.Click += button_arabaEkle_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox_ara);
            flowLayoutPanel1.Controls.Add(button_ara);
            flowLayoutPanel1.Controls.Add(comboBox_islemler);
            flowLayoutPanel1.Location = new Point(1, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(1345, 64);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "ARA";
            // 
            // textBox_ara
            // 
            textBox_ara.Font = new Font("Segoe UI", 9F);
            textBox_ara.Location = new Point(47, 18);
            textBox_ara.Name = "textBox_ara";
            textBox_ara.Size = new Size(1002, 27);
            textBox_ara.TabIndex = 5;
            // 
            // button_ara
            // 
            button_ara.Location = new Point(1055, 18);
            button_ara.Name = "button_ara";
            button_ara.Size = new Size(94, 29);
            button_ara.TabIndex = 7;
            button_ara.Text = "Bul";
            button_ara.UseVisualStyleBackColor = true;
            button_ara.Click += button_ara_Click;
            // 
            // comboBox_islemler
            // 
            comboBox_islemler.Font = new Font("Segoe UI", 9F);
            comboBox_islemler.FormattingEnabled = true;
            comboBox_islemler.Location = new Point(1155, 18);
            comboBox_islemler.Name = "comboBox_islemler";
            comboBox_islemler.Size = new Size(184, 28);
            comboBox_islemler.TabIndex = 6;
            // 
            // flowLayoutPanel_bilgi
            // 
            flowLayoutPanel_bilgi.Controls.Add(label1);
            flowLayoutPanel_bilgi.Location = new Point(1352, 0);
            flowLayoutPanel_bilgi.Name = "flowLayoutPanel_bilgi";
            flowLayoutPanel_bilgi.Size = new Size(330, 583);
            flowLayoutPanel_bilgi.TabIndex = 4;
            // 
            // Arabalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 699);
            Controls.Add(flowLayoutPanel_bilgi);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button_arabaEkle);
            Controls.Add(dataGridView_arabalar);
            Name = "Arabalar";
            Text = "Arabalar";
            Load += Arabalar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_arabalar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel_bilgi.ResumeLayout(false);
            flowLayoutPanel_bilgi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_arabalar;
        private Label label1;
        private Button button_arabaEkle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBox_ara;
        private ComboBox comboBox_islemler;
        private Button button_ara;
        private FlowLayoutPanel flowLayoutPanel_bilgi;
        private DataGridViewTextBoxColumn Column_marka;
        private DataGridViewTextBoxColumn Column_model;
        private DataGridViewTextBoxColumn Column_fiyat;
        private DataGridViewTextBoxColumn Column_garantiSuresi;
        private DataGridViewTextBoxColumn Column_benzin;
        private DataGridViewTextBoxColumn Column_yil;
        private DataGridViewCheckBoxColumn Column_kiralik;
        private DataGridViewCheckBoxColumn Column_hasar;
        private DataGridViewButtonColumn Column_duzenle;
        private DataGridViewButtonColumn Column_sil;
    }
}