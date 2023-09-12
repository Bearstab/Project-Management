namespace ProjeYonetimi
{
    partial class Gorevlerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorevlerim));
            this.gorevlerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnraporOlustur = new System.Windows.Forms.Button();
            this.geriTusu = new System.Windows.Forms.Button();
            this.gorevOlusturPanel = new System.Windows.Forms.Panel();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGorevAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDurumu = new System.Windows.Forms.ComboBox();
            this.comboBoxSorumluKullanici = new System.Windows.Forms.ComboBox();
            this.comboBoxOncelik = new System.Windows.Forms.ComboBox();
            this.comboBoxProje = new System.Windows.Forms.ComboBox();
            this.gorevPanel = new System.Windows.Forms.Panel();
            this.comboBoxKullanici = new System.Windows.Forms.ComboBox();
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.gorevGetirbtn = new System.Windows.Forms.Button();
            this.gorevOlusturPanel.SuspendLayout();
            this.gorevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // gorevlerbtn
            // 
            this.gorevlerbtn.BackColor = System.Drawing.Color.Silver;
            this.gorevlerbtn.Image = ((System.Drawing.Image)(resources.GetObject("gorevlerbtn.Image")));
            this.gorevlerbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gorevlerbtn.Location = new System.Drawing.Point(26, 262);
            this.gorevlerbtn.Name = "gorevlerbtn";
            this.gorevlerbtn.Size = new System.Drawing.Size(141, 121);
            this.gorevlerbtn.TabIndex = 47;
            this.gorevlerbtn.Text = "Görevlerim";
            this.gorevlerbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gorevlerbtn.UseVisualStyleBackColor = false;
            this.gorevlerbtn.Click += new System.EventHandler(this.gorevlerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Görevler Formuna Hoşgeldiniz";
            // 
            // btnraporOlustur
            // 
            this.btnraporOlustur.BackColor = System.Drawing.Color.Silver;
            this.btnraporOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnraporOlustur.Image")));
            this.btnraporOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnraporOlustur.Location = new System.Drawing.Point(26, 98);
            this.btnraporOlustur.Name = "btnraporOlustur";
            this.btnraporOlustur.Size = new System.Drawing.Size(141, 121);
            this.btnraporOlustur.TabIndex = 45;
            this.btnraporOlustur.Text = "Görev Oluştur";
            this.btnraporOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnraporOlustur.UseVisualStyleBackColor = false;
            this.btnraporOlustur.Click += new System.EventHandler(this.btnraporOlustur_Click);
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 44;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // gorevOlusturPanel
            // 
            this.gorevOlusturPanel.Controls.Add(this.kaydetbtn);
            this.gorevOlusturPanel.Controls.Add(this.label8);
            this.gorevOlusturPanel.Controls.Add(this.label7);
            this.gorevOlusturPanel.Controls.Add(this.dateTimePickerBitisTarihi);
            this.gorevOlusturPanel.Controls.Add(this.dateTimePickerBaslangicTarihi);
            this.gorevOlusturPanel.Controls.Add(this.label6);
            this.gorevOlusturPanel.Controls.Add(this.textBoxGorevAdi);
            this.gorevOlusturPanel.Controls.Add(this.label5);
            this.gorevOlusturPanel.Controls.Add(this.label4);
            this.gorevOlusturPanel.Controls.Add(this.label2);
            this.gorevOlusturPanel.Controls.Add(this.label1);
            this.gorevOlusturPanel.Controls.Add(this.comboBoxDurumu);
            this.gorevOlusturPanel.Controls.Add(this.comboBoxSorumluKullanici);
            this.gorevOlusturPanel.Controls.Add(this.comboBoxOncelik);
            this.gorevOlusturPanel.Controls.Add(this.comboBoxProje);
            this.gorevOlusturPanel.Location = new System.Drawing.Point(196, 84);
            this.gorevOlusturPanel.Name = "gorevOlusturPanel";
            this.gorevOlusturPanel.Size = new System.Drawing.Size(570, 334);
            this.gorevOlusturPanel.TabIndex = 48;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(396, 64);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(112, 34);
            this.kaydetbtn.TabIndex = 14;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Durumu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bitiş Tarihi :";
            // 
            // dateTimePickerBitisTarihi
            // 
            this.dateTimePickerBitisTarihi.Location = new System.Drawing.Point(147, 200);
            this.dateTimePickerBitisTarihi.Name = "dateTimePickerBitisTarihi";
            this.dateTimePickerBitisTarihi.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerBitisTarihi.TabIndex = 11;
            // 
            // dateTimePickerBaslangicTarihi
            // 
            this.dateTimePickerBaslangicTarihi.Location = new System.Drawing.Point(147, 163);
            this.dateTimePickerBaslangicTarihi.Name = "dateTimePickerBaslangicTarihi";
            this.dateTimePickerBaslangicTarihi.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerBaslangicTarihi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // textBoxGorevAdi
            // 
            this.textBoxGorevAdi.Location = new System.Drawing.Point(147, 14);
            this.textBoxGorevAdi.Name = "textBoxGorevAdi";
            this.textBoxGorevAdi.Size = new System.Drawing.Size(182, 31);
            this.textBoxGorevAdi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Öncelik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sorumlu Kişi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proje :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görev Adı :";
            // 
            // comboBoxDurumu
            // 
            this.comboBoxDurumu.FormattingEnabled = true;
            this.comboBoxDurumu.Items.AddRange(new object[] {
            "Planlama",
            "Başlangıç",
            "Analiz",
            "Tasarım",
            "Geliştirme",
            "Test ve Kalite Kontrol",
            "Dağıtım ve Uygulama",
            "Bakım ve Destek"});
            this.comboBoxDurumu.Location = new System.Drawing.Point(147, 237);
            this.comboBoxDurumu.Name = "comboBoxDurumu";
            this.comboBoxDurumu.Size = new System.Drawing.Size(182, 33);
            this.comboBoxDurumu.TabIndex = 3;
            // 
            // comboBoxSorumluKullanici
            // 
            this.comboBoxSorumluKullanici.FormattingEnabled = true;
            this.comboBoxSorumluKullanici.Location = new System.Drawing.Point(147, 85);
            this.comboBoxSorumluKullanici.Name = "comboBoxSorumluKullanici";
            this.comboBoxSorumluKullanici.Size = new System.Drawing.Size(182, 33);
            this.comboBoxSorumluKullanici.TabIndex = 2;
            // 
            // comboBoxOncelik
            // 
            this.comboBoxOncelik.FormattingEnabled = true;
            this.comboBoxOncelik.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxOncelik.Location = new System.Drawing.Point(147, 124);
            this.comboBoxOncelik.Name = "comboBoxOncelik";
            this.comboBoxOncelik.Size = new System.Drawing.Size(182, 33);
            this.comboBoxOncelik.TabIndex = 1;
            // 
            // comboBoxProje
            // 
            this.comboBoxProje.FormattingEnabled = true;
            this.comboBoxProje.Location = new System.Drawing.Point(147, 48);
            this.comboBoxProje.Name = "comboBoxProje";
            this.comboBoxProje.Size = new System.Drawing.Size(182, 33);
            this.comboBoxProje.TabIndex = 0;
            // 
            // gorevPanel
            // 
            this.gorevPanel.Controls.Add(this.gorevGetirbtn);
            this.gorevPanel.Controls.Add(this.dgvGorevler);
            this.gorevPanel.Controls.Add(this.comboBoxKullanici);
            this.gorevPanel.Location = new System.Drawing.Point(196, 84);
            this.gorevPanel.Name = "gorevPanel";
            this.gorevPanel.Size = new System.Drawing.Size(570, 334);
            this.gorevPanel.TabIndex = 49;
            // 
            // comboBoxKullanici
            // 
            this.comboBoxKullanici.FormattingEnabled = true;
            this.comboBoxKullanici.Location = new System.Drawing.Point(3, 91);
            this.comboBoxKullanici.Name = "comboBoxKullanici";
            this.comboBoxKullanici.Size = new System.Drawing.Size(182, 33);
            this.comboBoxKullanici.TabIndex = 0;
            // 
            // dgvGorevler
            // 
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Location = new System.Drawing.Point(191, 0);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.RowHeadersWidth = 62;
            this.dgvGorevler.RowTemplate.Height = 33;
            this.dgvGorevler.Size = new System.Drawing.Size(379, 331);
            this.dgvGorevler.TabIndex = 1;
            // 
            // gorevGetirbtn
            // 
            this.gorevGetirbtn.Location = new System.Drawing.Point(23, 30);
            this.gorevGetirbtn.Name = "gorevGetirbtn";
            this.gorevGetirbtn.Size = new System.Drawing.Size(132, 34);
            this.gorevGetirbtn.TabIndex = 2;
            this.gorevGetirbtn.Text = "Görevleri Getir";
            this.gorevGetirbtn.UseVisualStyleBackColor = true;
            this.gorevGetirbtn.Click += new System.EventHandler(this.gorevGetirbtn_Click);
            // 
            // Gorevlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gorevlerbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnraporOlustur);
            this.Controls.Add(this.geriTusu);
            this.Controls.Add(this.gorevPanel);
            this.Controls.Add(this.gorevOlusturPanel);
            this.Name = "Gorevlerim";
            this.Text = "Gorevlerim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gorevlerim_FormClosed);
            this.Load += new System.EventHandler(this.Gorevlerim_Load);
            this.gorevOlusturPanel.ResumeLayout(false);
            this.gorevOlusturPanel.PerformLayout();
            this.gorevPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button gorevlerbtn;
        private Label label3;
        private Button btnraporOlustur;
        private Button geriTusu;
        private Panel gorevOlusturPanel;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxDurumu;
        private ComboBox comboBoxSorumluKullanici;
        private ComboBox comboBoxOncelik;
        private ComboBox comboBoxProje;
        private Button kaydetbtn;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerBitisTarihi;
        private DateTimePicker dateTimePickerBaslangicTarihi;
        private Label label6;
        private TextBox textBoxGorevAdi;
        private Panel gorevPanel;
        private Button gorevGetirbtn;
        private DataGridView dgvGorevler;
        private ComboBox comboBoxKullanici;
    }
}