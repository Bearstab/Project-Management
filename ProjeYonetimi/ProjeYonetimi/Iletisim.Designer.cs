namespace ProjeYonetimi
{
    partial class Iletisim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iletisim));
            this.geriTusu = new System.Windows.Forms.Button();
            this.dateTimePickerMesajTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gonderbtn = new System.Windows.Forms.Button();
            this.comboBoxGonderen = new System.Windows.Forms.ComboBox();
            this.comboBoxAlici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnraporOlustur = new System.Windows.Forms.Button();
            this.mesajbtn = new System.Windows.Forms.Button();
            this.mesajGonderPanel = new System.Windows.Forms.Panel();
            this.richTextBoxMesajIcerik = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mesajPanel = new System.Windows.Forms.Panel();
            this.richTextBoxMesajlar = new System.Windows.Forms.RichTextBox();
            this.comboBoxKullanici = new System.Windows.Forms.ComboBox();
            this.mesajGetirbtn = new System.Windows.Forms.Button();
            this.mesajGonderPanel.SuspendLayout();
            this.mesajPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 32;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // dateTimePickerMesajTarihi
            // 
            this.dateTimePickerMesajTarihi.Location = new System.Drawing.Point(132, 276);
            this.dateTimePickerMesajTarihi.Name = "dateTimePickerMesajTarihi";
            this.dateTimePickerMesajTarihi.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerMesajTarihi.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Alıcı :";
            // 
            // gonderbtn
            // 
            this.gonderbtn.Location = new System.Drawing.Point(219, 227);
            this.gonderbtn.Name = "gonderbtn";
            this.gonderbtn.Size = new System.Drawing.Size(112, 34);
            this.gonderbtn.TabIndex = 37;
            this.gonderbtn.Text = "Gönder";
            this.gonderbtn.UseVisualStyleBackColor = true;
            this.gonderbtn.Click += new System.EventHandler(this.gonderbtn_Click);
            // 
            // comboBoxGonderen
            // 
            this.comboBoxGonderen.FormattingEnabled = true;
            this.comboBoxGonderen.Location = new System.Drawing.Point(108, 37);
            this.comboBoxGonderen.Name = "comboBoxGonderen";
            this.comboBoxGonderen.Size = new System.Drawing.Size(182, 33);
            this.comboBoxGonderen.TabIndex = 38;
            // 
            // comboBoxAlici
            // 
            this.comboBoxAlici.FormattingEnabled = true;
            this.comboBoxAlici.Location = new System.Drawing.Point(108, 137);
            this.comboBoxAlici.Name = "comboBoxAlici";
            this.comboBoxAlici.Size = new System.Drawing.Size(182, 33);
            this.comboBoxAlici.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(213, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Raporlar Formuna Hoşgeldiniz";
            // 
            // btnraporOlustur
            // 
            this.btnraporOlustur.BackColor = System.Drawing.Color.Silver;
            this.btnraporOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnraporOlustur.Image")));
            this.btnraporOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnraporOlustur.Location = new System.Drawing.Point(26, 98);
            this.btnraporOlustur.Name = "btnraporOlustur";
            this.btnraporOlustur.Size = new System.Drawing.Size(141, 121);
            this.btnraporOlustur.TabIndex = 40;
            this.btnraporOlustur.Text = "Mesaj Gönder";
            this.btnraporOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnraporOlustur.UseVisualStyleBackColor = false;
            this.btnraporOlustur.Click += new System.EventHandler(this.btnraporOlustur_Click);
            // 
            // mesajbtn
            // 
            this.mesajbtn.BackColor = System.Drawing.Color.Silver;
            this.mesajbtn.Image = ((System.Drawing.Image)(resources.GetObject("mesajbtn.Image")));
            this.mesajbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mesajbtn.Location = new System.Drawing.Point(26, 280);
            this.mesajbtn.Name = "mesajbtn";
            this.mesajbtn.Size = new System.Drawing.Size(141, 121);
            this.mesajbtn.TabIndex = 42;
            this.mesajbtn.Text = "Mesajlarım";
            this.mesajbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mesajbtn.UseVisualStyleBackColor = false;
            this.mesajbtn.Click += new System.EventHandler(this.mesajbtn_Click);
            // 
            // mesajGonderPanel
            // 
            this.mesajGonderPanel.Controls.Add(this.richTextBoxMesajIcerik);
            this.mesajGonderPanel.Controls.Add(this.label2);
            this.mesajGonderPanel.Controls.Add(this.label4);
            this.mesajGonderPanel.Controls.Add(this.comboBoxAlici);
            this.mesajGonderPanel.Controls.Add(this.gonderbtn);
            this.mesajGonderPanel.Controls.Add(this.label1);
            this.mesajGonderPanel.Controls.Add(this.comboBoxGonderen);
            this.mesajGonderPanel.Controls.Add(this.dateTimePickerMesajTarihi);
            this.mesajGonderPanel.Location = new System.Drawing.Point(192, 91);
            this.mesajGonderPanel.Name = "mesajGonderPanel";
            this.mesajGonderPanel.Size = new System.Drawing.Size(570, 319);
            this.mesajGonderPanel.TabIndex = 43;
            // 
            // richTextBoxMesajIcerik
            // 
            this.richTextBoxMesajIcerik.Location = new System.Drawing.Point(393, 40);
            this.richTextBoxMesajIcerik.Name = "richTextBoxMesajIcerik";
            this.richTextBoxMesajIcerik.Size = new System.Drawing.Size(150, 198);
            this.richTextBoxMesajIcerik.TabIndex = 42;
            this.richTextBoxMesajIcerik.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mesaj :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Gönderen :";
            // 
            // mesajPanel
            // 
            this.mesajPanel.Controls.Add(this.richTextBoxMesajlar);
            this.mesajPanel.Controls.Add(this.comboBoxKullanici);
            this.mesajPanel.Controls.Add(this.mesajGetirbtn);
            this.mesajPanel.Location = new System.Drawing.Point(192, 91);
            this.mesajPanel.Name = "mesajPanel";
            this.mesajPanel.Size = new System.Drawing.Size(570, 319);
            this.mesajPanel.TabIndex = 44;
            // 
            // richTextBoxMesajlar
            // 
            this.richTextBoxMesajlar.Location = new System.Drawing.Point(228, 21);
            this.richTextBoxMesajlar.Name = "richTextBoxMesajlar";
            this.richTextBoxMesajlar.Size = new System.Drawing.Size(327, 286);
            this.richTextBoxMesajlar.TabIndex = 2;
            this.richTextBoxMesajlar.Text = "";
            // 
            // comboBoxKullanici
            // 
            this.comboBoxKullanici.FormattingEnabled = true;
            this.comboBoxKullanici.Location = new System.Drawing.Point(21, 95);
            this.comboBoxKullanici.Name = "comboBoxKullanici";
            this.comboBoxKullanici.Size = new System.Drawing.Size(182, 33);
            this.comboBoxKullanici.TabIndex = 1;
            // 
            // mesajGetirbtn
            // 
            this.mesajGetirbtn.Location = new System.Drawing.Point(60, 35);
            this.mesajGetirbtn.Name = "mesajGetirbtn";
            this.mesajGetirbtn.Size = new System.Drawing.Size(112, 34);
            this.mesajGetirbtn.TabIndex = 0;
            this.mesajGetirbtn.Text = "Mesaj Getir";
            this.mesajGetirbtn.UseVisualStyleBackColor = true;
            this.mesajGetirbtn.Click += new System.EventHandler(this.mesajGetirbtn_Click);
            // 
            // Iletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mesajPanel);
            this.Controls.Add(this.mesajGonderPanel);
            this.Controls.Add(this.mesajbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnraporOlustur);
            this.Controls.Add(this.geriTusu);
            this.Name = "Iletisim";
            this.Text = "Iletisim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Iletisim_FormClosed);
            this.Load += new System.EventHandler(this.Iletisim_Load);
            this.mesajGonderPanel.ResumeLayout(false);
            this.mesajGonderPanel.PerformLayout();
            this.mesajPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button geriTusu;
        private DateTimePicker dateTimePickerMesajTarihi;
        private Label label1;
        private Button gonderbtn;
        private ComboBox comboBoxGonderen;
        private ComboBox comboBoxAlici;
        private Label label3;
        private Button btnraporOlustur;
        private Button mesajbtn;
        private Panel mesajGonderPanel;
        private RichTextBox richTextBoxMesajIcerik;
        private Label label2;
        private Label label4;
        private Panel mesajPanel;
        private RichTextBox richTextBoxMesajlar;
        private ComboBox comboBoxKullanici;
        private Button mesajGetirbtn;
    }
}