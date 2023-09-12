namespace ProjeYonetimi
{
    public partial class AnaMenu : Form
    {
        private KullaniciGirisi oldform;
        public AnaMenu(KullaniciGirisi kullaniciGirisi)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            oldform = kullaniciGirisi;
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullan�c� taraf�ndan kapat�ld���nda i�lem yap�lacak
            {
                Application.Exit(); // Uygulamay� tamamen kapat

            }
        }

        

        private void geriTusu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Geri d�nmek istiyor musunuz?", "Geri D�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Geri d�nme i�lemini ger�ekle�tirecek kodlar� burada yaz�cak               

                oldform.Show();
                this.Hide();



            }
            else if (result == DialogResult.No)
            {
                // Panelde kalmaya devam etmek istedi�iniz durumu burada ele al�n
                // �lgili kodlar� buraya yaz�n
            }

        }

        

        private void projeOlusturmabtn_Click(object sender, EventArgs e)
        {
            ProjeOlustur projeOlustur = new ProjeOlustur(this);
            projeOlustur.Show();
            this.Hide();
        }

        private void raporlarBtn_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar(this);
            raporlar.Show();
            this.Hide();
        }
        private void iletisimbtn_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim(this);
            iletisim.Show();
            this.Hide();
        }

        private void gorevlerimbtn_Click(object sender, EventArgs e)
        {
            Gorevlerim gorevlerim = new Gorevlerim(this);
            gorevlerim.Show();
            this.Hide();
        }
        private void projelerimbtn_Click(object sender, EventArgs e)
        {
            Projelerim projelerim = new Projelerim();
            projelerim.Show();
            this.Hide();
        }
        private void ayarlarbtn_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            this.Hide();
        }
    }
}