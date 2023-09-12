namespace ProjeYonetimi
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.label3 = new System.Windows.Forms.Label();
            this.raporGetir = new System.Windows.Forms.Button();
            this.btnraporOlustur = new System.Windows.Forms.Button();
            this.geriTusu = new System.Windows.Forms.Button();
            this.yeniRaporPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.projelerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raporOlustur = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.raporlarPanel = new System.Windows.Forms.Panel();
            this.dataGridViewRaporlar = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.comboBoxProjeAdi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yeniRaporPanel.SuspendLayout();
            this.raporlarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Raporlar Formuna Hoşgeldiniz";
            // 
            // raporGetir
            // 
            this.raporGetir.BackColor = System.Drawing.Color.Silver;
            this.raporGetir.Image = ((System.Drawing.Image)(resources.GetObject("raporGetir.Image")));
            this.raporGetir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.raporGetir.Location = new System.Drawing.Point(31, 267);
            this.raporGetir.Name = "raporGetir";
            this.raporGetir.Size = new System.Drawing.Size(141, 121);
            this.raporGetir.TabIndex = 37;
            this.raporGetir.Text = "Raporlarım";
            this.raporGetir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.raporGetir.UseVisualStyleBackColor = false;
            this.raporGetir.Click += new System.EventHandler(this.raporGetir_Click);
            // 
            // btnraporOlustur
            // 
            this.btnraporOlustur.BackColor = System.Drawing.Color.Silver;
            this.btnraporOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnraporOlustur.Image")));
            this.btnraporOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnraporOlustur.Location = new System.Drawing.Point(31, 74);
            this.btnraporOlustur.Name = "btnraporOlustur";
            this.btnraporOlustur.Size = new System.Drawing.Size(141, 121);
            this.btnraporOlustur.TabIndex = 36;
            this.btnraporOlustur.Text = "Yeni Rapor";
            this.btnraporOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnraporOlustur.UseVisualStyleBackColor = false;
            this.btnraporOlustur.Click += new System.EventHandler(this.btnraporOlustur_Click);
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(18, 11);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 35;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // yeniRaporPanel
            // 
            this.yeniRaporPanel.Controls.Add(this.comboBox2);
            this.yeniRaporPanel.Controls.Add(this.label5);
            this.yeniRaporPanel.Controls.Add(this.label4);
            this.yeniRaporPanel.Controls.Add(this.label2);
            this.yeniRaporPanel.Controls.Add(this.richTextBox1);
            this.yeniRaporPanel.Controls.Add(this.projelerComboBox);
            this.yeniRaporPanel.Controls.Add(this.label1);
            this.yeniRaporPanel.Controls.Add(this.raporOlustur);
            this.yeniRaporPanel.Controls.Add(this.dateTimePicker1);
            this.yeniRaporPanel.Location = new System.Drawing.Point(178, 74);
            this.yeniRaporPanel.Name = "yeniRaporPanel";
            this.yeniRaporPanel.Size = new System.Drawing.Size(610, 352);
            this.yeniRaporPanel.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Durum Raporu",
            "İlerleme Raporu",
            "Performans Raporu",
            "Finansal Rapor",
            "Proje Değerlendirme Raporu",
            "Risk Raporu"});
            this.comboBox2.Location = new System.Drawing.Point(126, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rapor İçeriği";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rapor Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rapor tipi :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 144);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // projelerComboBox
            // 
            this.projelerComboBox.FormattingEnabled = true;
            this.projelerComboBox.Location = new System.Drawing.Point(126, 54);
            this.projelerComboBox.Name = "projelerComboBox";
            this.projelerComboBox.Size = new System.Drawing.Size(182, 33);
            this.projelerComboBox.TabIndex = 3;
            this.projelerComboBox.SelectedValueChanged += new System.EventHandler(this.projelerComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proje :";
            // 
            // raporOlustur
            // 
            this.raporOlustur.Location = new System.Drawing.Point(463, 270);
            this.raporOlustur.Name = "raporOlustur";
            this.raporOlustur.Size = new System.Drawing.Size(112, 34);
            this.raporOlustur.TabIndex = 1;
            this.raporOlustur.Text = "Oluştur";
            this.raporOlustur.UseVisualStyleBackColor = true;
            this.raporOlustur.Click += new System.EventHandler(this.raporOlustur_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // raporlarPanel
            // 
            this.raporlarPanel.Controls.Add(this.label6);
            this.raporlarPanel.Controls.Add(this.comboBoxProjeAdi);
            this.raporlarPanel.Controls.Add(this.btnGoster);
            this.raporlarPanel.Controls.Add(this.dataGridViewRaporlar);
            this.raporlarPanel.Location = new System.Drawing.Point(178, 74);
            this.raporlarPanel.Name = "raporlarPanel";
            this.raporlarPanel.Size = new System.Drawing.Size(607, 352);
            this.raporlarPanel.TabIndex = 40;
            // 
            // dataGridViewRaporlar
            // 
            this.dataGridViewRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaporlar.Location = new System.Drawing.Point(194, 3);
            this.dataGridViewRaporlar.Name = "dataGridViewRaporlar";
            this.dataGridViewRaporlar.RowHeadersWidth = 62;
            this.dataGridViewRaporlar.RowTemplate.Height = 33;
            this.dataGridViewRaporlar.Size = new System.Drawing.Size(410, 346);
            this.dataGridViewRaporlar.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(21, 20);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(153, 34);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Raporları Getir";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // comboBoxProjeAdi
            // 
            this.comboBoxProjeAdi.FormattingEnabled = true;
            this.comboBoxProjeAdi.Location = new System.Drawing.Point(6, 155);
            this.comboBoxProjeAdi.Name = "comboBoxProjeAdi";
            this.comboBoxProjeAdi.Size = new System.Drawing.Size(182, 33);
            this.comboBoxProjeAdi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Proje Seçin";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.raporlarPanel);
            this.Controls.Add(this.yeniRaporPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.raporGetir);
            this.Controls.Add(this.btnraporOlustur);
            this.Controls.Add(this.geriTusu);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raporlar_FormClosed);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.yeniRaporPanel.ResumeLayout(false);
            this.yeniRaporPanel.PerformLayout();
            this.raporlarPanel.ResumeLayout(false);
            this.raporlarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button raporGetir;
        private Button btnraporOlustur;
        private Button geriTusu;
        private Panel yeniRaporPanel;
        private ComboBox comboBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private RichTextBox richTextBox1;
        private ComboBox projelerComboBox;
        private Label label1;
        private Button raporOlustur;
        private DateTimePicker dateTimePicker1;
        private Panel raporlarPanel;
        private Label label6;
        private ComboBox comboBoxProjeAdi;
        private Button btnGoster;
        private DataGridView dataGridViewRaporlar;
    }
}