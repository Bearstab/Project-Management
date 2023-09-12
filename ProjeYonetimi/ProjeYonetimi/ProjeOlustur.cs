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

    public partial class ProjeOlustur : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";
        private AnaMenu oldform;
        public ProjeOlustur(AnaMenu anaMenu)
        {
            InitializeComponent();
            oldform = anaMenu;
            projeOlusturPanel.Visible = false;
            projeGosterPanel.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void btnprojeOlustur_Click(object sender, EventArgs e)
        {
            if (projeGosterPanel.Visible == true)
            {              
                 projeGosterPanel.Visible = false;
            }
            projeOlusturPanel.Visible = true;
        }

        private void ProjeOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void projeGetirbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Veritabanı bağlantısını oluştur
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıları getirmek için sorguyu hazırla
                    string query = "SELECT * FROM projeler";

                    // NpgsqlDataAdapter kullanarak verileri al
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri ata
                    projeDataview.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda işleme devam edilemez
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }

        }

        private void projeGetir_Click(object sender, EventArgs e)
        {
            if (projeOlusturPanel.Visible == true)
            {
                projeOlusturPanel.Visible = false;
            }
            projeGosterPanel.Visible = true;
            
        }

        private void projeKaydetbtn_Click(object sender, EventArgs e)
        {
            // TextBox, ComboBox ve DateTimePicker'lardan verileri al
            string projeAdi = txtProjeAdi.Text;
            string projeSuresi = txtProjeSuresi.Text;
            string hedefler = txtHedefler.Text;
            DateTime baslangicTarihi = dateTimePickerBaslangic.Value;
            DateTime bitisTarihi = dateTimePickerBitis.Value;
            string butce = txtButce.Text;
            string durum = cmbDurum.SelectedItem.ToString();

            // Veritabanına veriyi ekle
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Projeler (proje_adi, proje_suresi, hedefler, baslangic_tarihi, bitis_tarihi, butce, durum) " +
                                          "VALUES (@projeAdi, @projeSuresi, @hedefler, @baslangicTarihi, @bitisTarihi, @butce, @durum)";
                    command.Parameters.AddWithValue("@projeAdi", projeAdi);
                    command.Parameters.AddWithValue("@projeSuresi", projeSuresi);
                    command.Parameters.AddWithValue("@hedefler", hedefler);
                    command.Parameters.AddWithValue("@baslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                    command.Parameters.AddWithValue("@butce", butce);
                    command.Parameters.AddWithValue("@durum", durum);
                    command.ExecuteNonQuery();
                }
            }

            // Başarılı bir şekilde kaydedildi mesajını göster
            MessageBox.Show("Proje başarıyla kaydedildi.");

            // TextBox, ComboBox ve DateTimePicker'ları temizle
            txtProjeAdi.Clear();
            txtProjeSuresi.Clear();
            txtHedefler.Clear();
            dateTimePickerBaslangic.Value = DateTime.Now;
            dateTimePickerBitis.Value = DateTime.Now;
            txtButce.Clear();
            cmbDurum.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
