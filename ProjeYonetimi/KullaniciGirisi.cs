using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace ProjeYonetimi
{
    public partial class KullaniciGirisi : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";
        public KullaniciGirisi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            sifretxt.UseSystemPasswordChar = true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            KullaniciKayit kullaniciKayit = new KullaniciKayit(this);  // Formu oluşturuyoruz

            this.Hide();
            kullaniciKayit.Show();


        }
        private void KullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                e.Cancel = true; // Formun kapatılmasını iptal et
                ExitApplication(); // Uygulamadan çıkış yap
            }
        }

        private void ExitApplication()
        {
            // Tüm formları kapat
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }

            // Uygulamayı tamamen sonlandır
            Application.Exit();
        }

        private void kullaniciLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAditxt.Text;
            string sifre = sifretxt.Text;

            // Veritabanı bağlantısını oluştur
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString)) // veya NpgsqlConnection (PostgreSQL için)
            {
                try
                {
                    connection.Open();

                    // Kullanıcı girişini doğrulamak için veritabanında sorgu çalıştır
                    string query = "SELECT COUNT(*) FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int result = reader.GetInt32(0);

                                if (result > 0)
                                {
                                    MessageBox.Show("Giriş başarılı Ana Menüye yönlendiriliyorsunuz -->");
                                    AnaMenu anaMenu = new AnaMenu(this);
                                    anaMenu.Show();
                                    this.Hide();
                                }
                                
                                else
                                {
                                    // Kullanıcı doğrulanamadı, hata mesajı göster
                                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda işleme devam edilemez
                    MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void yoneticiLogin_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yonetici = new YoneticiGirisi(this);  // Formu oluşturuyoruz

            this.Hide();
            yonetici.Show();

        }
    }
}


