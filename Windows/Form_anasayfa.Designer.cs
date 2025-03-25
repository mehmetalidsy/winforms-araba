namespace WinFormsApp_Araba.Windows
{
    partial class Form_anasayfa
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
            l = new Button();
            label1 = new Label();
            button_yakitlar = new Button();
            button_markalar = new Button();
            button_renkler = new Button();
            SuspendLayout();
            // 
            // l
            // 
            l.Location = new Point(407, 85);
            l.Name = "l";
            l.Size = new Size(171, 58);
            l.TabIndex = 0;
            l.Text = "Arabalar";
            l.UseVisualStyleBackColor = true;
            l.Click += l_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(134, 21);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 3;
            label1.Text = "Araba Otomasyonu";
            // 
            // button_yakitlar
            // 
            button_yakitlar.Location = new Point(12, 85);
            button_yakitlar.Name = "button_yakitlar";
            button_yakitlar.Size = new Size(159, 58);
            button_yakitlar.TabIndex = 4;
            button_yakitlar.Text = "Yakıtlar";
            button_yakitlar.UseVisualStyleBackColor = true;
            button_yakitlar.Click += button_yakitlar_Click;
            // 
            // button_markalar
            // 
            button_markalar.Location = new Point(208, 85);
            button_markalar.Name = "button_markalar";
            button_markalar.Size = new Size(162, 58);
            button_markalar.TabIndex = 5;
            button_markalar.Text = "Markalar";
            button_markalar.UseVisualStyleBackColor = true;
            button_markalar.Click += button_markalar_Click;
            // 
            // button_renkler
            // 
            button_renkler.Location = new Point(12, 168);
            button_renkler.Name = "button_renkler";
            button_renkler.Size = new Size(159, 58);
            button_renkler.TabIndex = 6;
            button_renkler.Text = "Renkler";
            button_renkler.UseVisualStyleBackColor = true;
            button_renkler.Click += button_renkler_Click;
            // 
            // Form_anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 238);
            Controls.Add(button_renkler);
            Controls.Add(button_markalar);
            Controls.Add(button_yakitlar);
            Controls.Add(label1);
            Controls.Add(l);
            MaximizeBox = false;
            Name = "Form_anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button l;
        private Label label1;
        private Button button_yakitlar;
        private Button button_markalar;
        private Button button_renkler;
    }
}