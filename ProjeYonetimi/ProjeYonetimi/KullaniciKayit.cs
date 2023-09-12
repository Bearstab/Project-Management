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



    public partial class KullaniciKayit : Form
    {

        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";

        private KullaniciGirisi oldform;

        public KullaniciKayit(KullaniciGirisi kullaniciGirisi)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            oldform = kullaniciGirisi;
            sifretxt.UseSystemPasswordChar = true;
        }      
        private void geriTusu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Geri dönmek istiyor musunuz?", "Geri Dön", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Geri dönme işlemini gerçekleştirecek kodları burada yazıcak               

                oldform.Show();
                this.Hide();



            }
            else if (result == DialogResult.No)
            {
                // Panelde kalmaya devam etmek istediğiniz durumu burada ele alın
                // İlgili kodları buraya yazın
            }
        }



        private void KullaniciKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            LoadYetkiler(); // Yetkileri yükleme işlemini form yüklenirken çağırılıyor
        }

        private void KayitEkle(string kullaniciAdi,string email, string sifre, string ad, string soyad, string yetki)
        {
            // Veritabanı bağlantısı için gerekli bilgileri sağlayın           
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                // Veritabanı bağlantısı açıldı

                // Kayıt ekleme sorgusu
                string query = "INSERT INTO kullanicilar (kullanici_adi, email, sifre, ad, soyad, yetkisi) VALUES (@kullaniciAdi, @email, @sifre, @ad, @soyad, @yetki )";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Parametrelerin değerlerini atanır
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@ad", ad);
                    command.Parameters.AddWithValue("@soyad", soyad);
                    command.Parameters.AddWithValue("@yetki", yetki);


                    // Sorguyu yürütür
                    command.ExecuteNonQuery();
                }
                connection.Close();
                // Veritabanı bağlantısı kapandı
            }
        }

        

        private void LoadYetkiler()
        {
            // Veritabanı bağlantısı için gerekli bilgileri sağlayın
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                // Veritabanı bağlantısı açıldı

                // Verileri çekmek istediğiniz sorguyu oluşturuluyor
                string query = "SELECT yetki FROM yetkiler";

                // NpgsqlCommand sınıfını kullanarak sorguyu yürütün
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string yetki = reader.GetString(0); // Sütunun indisini belirterek veriyi alın
                        yetkiComboBox.Items.Add(yetki); // ComboBox'a veriyi ekleyin
                    }
                    reader.Close();
                }
                connection.Close();
                // Veritabanı bağlantısı kapandı
            }
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAditxt.Text;
            string email = kullaniciEmailtxt.Text;
            string sifre = sifretxt.Text;
            string ad = adtxt.Text;
            string soyad = soyadtxt.Text;
            string yetki = yetkiComboBox.SelectedItem.ToString();
            // Kayıt ekleme işlemini çağır
            KayitEkle(kullaniciAdi, email, sifre, ad, soyad, yetki);
            MessageBox.Show("Kayıt başarıyla eklendi.");
        }
    }
}

