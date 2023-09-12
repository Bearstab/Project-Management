namespace ProjeYonetimi
{
    partial class ProjeOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeOlustur));
            this.geriTusu = new System.Windows.Forms.Button();
            this.btnprojeOlustur = new System.Windows.Forms.Button();
            this.projeGetir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.projeOlusturPanel = new System.Windows.Forms.Panel();
            this.projeKaydetbtn = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtButce = new System.Windows.Forms.TextBox();
            this.txtHedefler = new System.Windows.Forms.TextBox();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.txtProjeSuresi = new System.Windows.Forms.TextBox();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.projeGosterPanel = new System.Windows.Forms.Panel();
            this.projeDataview = new System.Windows.Forms.DataGridView();
            this.projeGetirbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.projeOlusturPanel.SuspendLayout();
            this.projeGosterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 31;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // btnprojeOlustur
            // 
            this.btnprojeOlustur.BackColor = System.Drawing.Color.Silver;
            this.btnprojeOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnprojeOlustur.Image")));
            this.btnprojeOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprojeOlustur.Location = new System.Drawing.Point(25, 89);
            this.btnprojeOlustur.Name = "btnprojeOlustur";
            this.btnprojeOlustur.Size = new System.Drawing.Size(141, 121);
            this.btnprojeOlustur.TabIndex = 32;
            this.btnprojeOlustur.Text = "Yeni Proje";
            this.btnprojeOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprojeOlustur.UseVisualStyleBackColor = false;
            this.btnprojeOlustur.Click += new System.EventHandler(this.btnprojeOlustur_Click);
            // 
            // projeGetir
            // 
            this.projeGetir.BackColor = System.Drawing.Color.Silver;
            this.projeGetir.Image = ((System.Drawing.Image)(resources.GetObject("projeGetir.Image")));
            this.projeGetir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.projeGetir.Location = new System.Drawing.Point(25, 273);
            this.projeGetir.Name = "projeGetir";
            this.projeGetir.Size = new System.Drawing.Size(141, 121);
            this.projeGetir.TabIndex = 33;
            this.projeGetir.Text = "Projelerim";
            this.projeGetir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.projeGetir.UseVisualStyleBackColor = false;
            this.projeGetir.Click += new System.EventHandler(this.projeGetir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(167, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Proje Oluşturma Formuna Hoşgeldiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // projeOlusturPanel
            // 
            this.projeOlusturPanel.Controls.Add(this.projeKaydetbtn);
            this.projeOlusturPanel.Controls.Add(this.cmbDurum);
            this.projeOlusturPanel.Controls.Add(this.label8);
            this.projeOlusturPanel.Controls.Add(this.label7);
            this.projeOlusturPanel.Controls.Add(this.label6);
            this.projeOlusturPanel.Controls.Add(this.label5);
            this.projeOlusturPanel.Controls.Add(this.label4);
            this.projeOlusturPanel.Controls.Add(this.label2);
            this.projeOlusturPanel.Controls.Add(this.label1);
            this.projeOlusturPanel.Controls.Add(this.txtButce);
            this.projeOlusturPanel.Controls.Add(this.txtHedefler);
            this.projeOlusturPanel.Controls.Add(this.txtProjeAdi);
            this.projeOlusturPanel.Controls.Add(this.txtProjeSuresi);
            this.projeOlusturPanel.Controls.Add(this.dateTimePickerBitis);
            this.projeOlusturPanel.Controls.Add(this.dateTimePickerBaslangic);
            this.projeOlusturPanel.Location = new System.Drawing.Point(193, 89);
            this.projeOlusturPanel.Name = "projeOlusturPanel";
            this.projeOlusturPanel.Size = new System.Drawing.Size(595, 305);
            this.projeOlusturPanel.TabIndex = 35;
            // 
            // projeKaydetbtn
            // 
            this.projeKaydetbtn.Location = new System.Drawing.Point(382, 243);
            this.projeKaydetbtn.Name = "projeKaydetbtn";
            this.projeKaydetbtn.Size = new System.Drawing.Size(145, 34);
            this.projeKaydetbtn.TabIndex = 15;
            this.projeKaydetbtn.Text = "Proje Kaydet";
            this.projeKaydetbtn.UseVisualStyleBackColor = true;
            this.projeKaydetbtn.Click += new System.EventHandler(this.projeKaydetbtn_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Planlama",
            "Başlangıç",
            "Analiz",
            "Tasarım",
            "Geliştirme",
            "Test ve Kalite Kontrol",
            "Dağıtım ve Uygulama",
            "Bakım ve Destek"});
            this.cmbDurum.Location = new System.Drawing.Point(410, 24);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(182, 33);
            this.cmbDurum.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bütçe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Durumu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bitiş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hedefler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proje Süresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proje Adı :";
            // 
            // txtButce
            // 
            this.txtButce.Location = new System.Drawing.Point(155, 243);
            this.txtButce.Name = "txtButce";
            this.txtButce.Size = new System.Drawing.Size(150, 31);
            this.txtButce.TabIndex = 6;
            // 
            // txtHedefler
            // 
            this.txtHedefler.Location = new System.Drawing.Point(155, 108);
            this.txtHedefler.Name = "txtHedefler";
            this.txtHedefler.Size = new System.Drawing.Size(150, 31);
            this.txtHedefler.TabIndex = 4;
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(155, 24);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(150, 31);
            this.txtProjeAdi.TabIndex = 3;
            // 
            // txtProjeSuresi
            // 
            this.txtProjeSuresi.Location = new System.Drawing.Point(155, 68);
            this.txtProjeSuresi.Name = "txtProjeSuresi";
            this.txtProjeSuresi.Size = new System.Drawing.Size(150, 31);
            this.txtProjeSuresi.TabIndex = 2;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Location = new System.Drawing.Point(155, 194);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerBitis.TabIndex = 1;
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(155, 156);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(300, 31);
            this.dateTimePickerBaslangic.TabIndex = 0;
            // 
            // projeGosterPanel
            // 
            this.projeGosterPanel.Controls.Add(this.projeDataview);
            this.projeGosterPanel.Controls.Add(this.projeGetirbtn);
            this.projeGosterPanel.Location = new System.Drawing.Point(186, 89);
            this.projeGosterPanel.Name = "projeGosterPanel";
            this.projeGosterPanel.Size = new System.Drawing.Size(602, 308);
            this.projeGosterPanel.TabIndex = 37;
            // 
            // projeDataview
            // 
            this.projeDataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projeDataview.Location = new System.Drawing.Point(133, 0);
            this.projeDataview.Name = "projeDataview";
            this.projeDataview.RowHeadersWidth = 62;
            this.projeDataview.RowTemplate.Height = 33;
            this.projeDataview.Size = new System.Drawing.Size(469, 308);
            this.projeDataview.TabIndex = 39;
            // 
            // projeGetirbtn
            // 
            this.projeGetirbtn.Location = new System.Drawing.Point(10, 18);
            this.projeGetirbtn.Name = "projeGetirbtn";
            this.projeGetirbtn.Size = new System.Drawing.Size(112, 34);
            this.projeGetirbtn.TabIndex = 38;
            this.projeGetirbtn.Text = "Proje Getir :";
            this.projeGetirbtn.UseVisualStyleBackColor = true;
            this.projeGetirbtn.Click += new System.EventHandler(this.projeGetirbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 305);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // ProjeOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projeGosterPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projeGetir);
            this.Controls.Add(this.btnprojeOlustur);
            this.Controls.Add(this.geriTusu);
            this.Controls.Add(this.projeOlusturPanel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ProjeOlustur";
            this.Text = "ProjeOlustur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjeOlustur_FormClosed);
            this.projeOlusturPanel.ResumeLayout(false);
            this.projeOlusturPanel.PerformLayout();
            this.projeGosterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projeDataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button geriTusu;
        private Button btnprojeOlustur;
        private Button projeGetir;
        private Label label3;
        private Panel projeOlusturPanel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtButce;
        private TextBox txtHedefler;
        private TextBox txtProjeAdi;
        private TextBox txtProjeSuresi;
        private DateTimePicker dateTimePickerBitis;
        private DateTimePicker dateTimePickerBaslangic;
        private Button projeKaydetbtn;
        private ComboBox cmbDurum;
        private PictureBox pictureBox2;
        private Panel projeGosterPanel;
        private Button projeGetirbtn;
        private DataGridView projeDataview;
    }
}