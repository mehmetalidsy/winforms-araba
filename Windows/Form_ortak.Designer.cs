namespace WinFormsApp_Araba.Windows
{
    partial class Form_ortak
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
            button_kaydet = new Button();
            textBox_ortak = new TextBox();
            label_input = new Label();
            dataGridView1 = new DataGridView();
            Column_id = new DataGridViewTextBoxColumn();
            Column_adi = new DataGridViewTextBoxColumn();
            Column_duzenle = new DataGridViewButtonColumn();
            Column_sil = new DataGridViewButtonColumn();
            label_ortak = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_kaydet
            // 
            button_kaydet.Location = new Point(649, 127);
            button_kaydet.Name = "button_kaydet";
            button_kaydet.Size = new Size(328, 57);
            button_kaydet.TabIndex = 1;
            button_kaydet.Text = "Kaydet";
            button_kaydet.UseVisualStyleBackColor = true;
            button_kaydet.Click += button_kaydet_Click;
            // 
            // textBox_ortak
            // 
            textBox_ortak.Location = new Point(763, 80);
            textBox_ortak.Name = "textBox_ortak";
            textBox_ortak.Size = new Size(214, 27);
            textBox_ortak.TabIndex = 2;
            // 
            // label_input
            // 
            label_input.AutoSize = true;
            label_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_input.ForeColor = SystemColors.ControlLightLight;
            label_input.Location = new Point(649, 76);
            label_input.Name = "label_input";
            label_input.Size = new Size(102, 28);
            label_input.TabIndex = 3;
            label_input.Text = "Marka Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_id, Column_adi, Column_duzenle, Column_sil });
            dataGridView1.GridColor = SystemColors.Highlight;
            dataGridView1.Location = new Point(-1, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 628);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_id
            // 
            Column_id.HeaderText = "ID";
            Column_id.MinimumWidth = 6;
            Column_id.Name = "Column_id";
            Column_id.ReadOnly = true;
            Column_id.Width = 125;
            // 
            // Column_adi
            // 
            Column_adi.HeaderText = "Adı";
            Column_adi.MinimumWidth = 6;
            Column_adi.Name = "Column_adi";
            Column_adi.ReadOnly = true;
            Column_adi.Width = 200;
            // 
            // Column_duzenle
            // 
            Column_duzenle.HeaderText = "Düzenle";
            Column_duzenle.MinimumWidth = 6;
            Column_duzenle.Name = "Column_duzenle";
            Column_duzenle.ReadOnly = true;
            Column_duzenle.Text = "Düzenle";
            Column_duzenle.ToolTipText = "Düzenle";
            Column_duzenle.UseColumnTextForButtonValue = true;
            Column_duzenle.Width = 125;
            // 
            // Column_sil
            // 
            Column_sil.HeaderText = "Sil";
            Column_sil.MinimumWidth = 6;
            Column_sil.Name = "Column_sil";
            Column_sil.ReadOnly = true;
            Column_sil.Text = "Sil";
            Column_sil.ToolTipText = "Sil";
            Column_sil.UseColumnTextForButtonValue = true;
            Column_sil.Width = 120;
            // 
            // label_ortak
            // 
            label_ortak.AutoSize = true;
            label_ortak.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_ortak.ForeColor = SystemColors.ControlLightLight;
            label_ortak.Location = new Point(649, 19);
            label_ortak.Name = "label_ortak";
            label_ortak.Size = new Size(335, 46);
            label_ortak.TabIndex = 4;
            label_ortak.Text = "Marka Ekle / Düzenle";
            // 
            // Form_ortak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1002, 638);
            Controls.Add(label_ortak);
            Controls.Add(label_input);
            Controls.Add(textBox_ortak);
            Controls.Add(button_kaydet);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form_ortak";
            Text = "Markalar";
            Load += Form_markalar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_kaydet;
        private TextBox textBox_ortak;
        private Label label_input;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_id;
        private DataGridViewTextBoxColumn Column_adi;
        private DataGridViewButtonColumn Column_duzenle;
        private DataGridViewButtonColumn Column_sil;
        private Label label_ortak;
    }
}