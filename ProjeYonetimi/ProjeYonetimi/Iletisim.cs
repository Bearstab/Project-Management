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
    public partial class Iletisim : Form
    {
        private AnaMenu oldform;
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";
        public Iletisim(AnaMenu anaMenu)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            oldform = anaMenu;
            mesajGonderPanel.Visible = false;
            mesajPanel.Visible = false;
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
                return;
            }
        }

        private void btnraporOlustur_Click(object sender, EventArgs e)
        {
            if (mesajPanel.Visible == true)
            {
                mesajPanel.Visible = false;
            }
            mesajGonderPanel.Visible = true;
        }

        private void KullaniciAdlariniDoldur()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT user_id, kullanici_adi FROM kullanicilar";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Her bir kullanıcı adını ComboBox'lara ekleyin
                            comboBoxGonderen.Items.Add(new KullaniciItem(reader["kullanici_adi"].ToString(), int.Parse(reader["user_id"].ToString())));
                            comboBoxAlici.Items.Add(new KullaniciItem(reader["kullanici_adi"].ToString(), int.Parse(reader["user_id"].ToString())));
                            comboBoxKullanici.Items.Add(new KullaniciItem(reader["kullanici_adi"].ToString(), int.Parse(reader["user_id"].ToString())));
                        }
                    }
                }
            }
        }
        public class KullaniciItem
        {
            public string KullaniciAdi { get; set; }
            public int KullaniciId { get; set; }

            public KullaniciItem(string kullaniciAdi, int kullaniciId)
            {
                KullaniciAdi = kullaniciAdi;
                KullaniciId = kullaniciId;
            }

            public override string ToString()
            {
                return KullaniciAdi;
            }
        }

        private void gonderbtn_Click(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen gönderen ve alıcı Id'lerini alın
            int gonderenId = ((KullaniciItem)comboBoxGonderen.SelectedItem).KullaniciId;
            int aliciId = ((KullaniciItem)comboBoxAlici.SelectedItem).KullaniciId;

            // Diğer verileri alın
            string mesajIcerik = richTextBoxMesajIcerik.Text;
            DateTime mesajTarihi = dateTimePickerMesajTarihi.Value;

            // Mesajı veritabanına ekle
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO iletisim (gonderen_kullanici_id, alici_kullanici_id, mesaj_icerigi, mesaj_tarihi) " +
                                          "VALUES (@GonderenId, @AliciId, @MesajIcerik, @MesajTarihi)";
                    command.Parameters.AddWithValue("@GonderenId", gonderenId);
                    command.Parameters.AddWithValue("@AliciId", aliciId);
                    command.Parameters.AddWithValue("@MesajIcerik", mesajIcerik);
                    command.Parameters.AddWithValue("@MesajTarihi", mesajTarihi);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Mesaj Başarıyla Gönderildi");
        }

        private void Iletisim_Load(object sender, EventArgs e)
        {
            KullaniciAdlariniDoldur();
        }

        private void Iletisim_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void mesajbtn_Click(object sender, EventArgs e)
        {
            if (mesajGonderPanel.Visible == true)
            {
                mesajGonderPanel.Visible = false;
            }
            mesajPanel.Visible = true;
        }

        private void mesajGetirbtn_Click(object sender, EventArgs e)
        {
            // Seçilen kullanıcının Id'sini alın
            int kullaniciId = ((KullaniciItem)comboBoxKullanici.SelectedItem).KullaniciId;

            // Mesajları veritabanından getir
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT mesaj_icerigi FROM iletisim WHERE alici_kullanici_id = @KullaniciId";
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                    using (var reader = command.ExecuteReader())
                    {
                        // RichTextBox'ı temizle
                        richTextBoxMesajlar.Clear();

                        while (reader.Read())
                        {
                            // Mesajları RichTextBox'a ekle
                            richTextBoxMesajlar.AppendText(reader["mesaj_icerigi"].ToString());
                            richTextBoxMesajlar.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }
    }
}
