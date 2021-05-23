using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace siparisTakip
{
    public partial class Form1 : Form
    {
        public static string sqlbaglanti = "Server=127.0.0.1;Port=3307;Database=sirket;Uid=root;Pwd='123456789b';";
        public MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        public static string uye, rol;

        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            sifreBox.PasswordChar = '*';
            sifreBoxGiris.PasswordChar = '*';
        }

    


        

        private void kayitButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into uye_table(u_adi,u_soyadi,k_adi,sifre,rol) values (@u_adi,@u_soyadi,@k_adi,@sifre,'user')";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@u_adi", u_adiBox.Text);
                komut.Parameters.AddWithValue("@u_soyadi", u_soyadiBox.Text);
                komut.Parameters.AddWithValue("@k_adi", k_adiBox.Text);
                komut.Parameters.AddWithValue("@sifre", sifreBox.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti. Giriş Yapabilirsiniz");
                u_adiBox.Clear();
                u_soyadiBox.Clear();
                k_adiBox.Clear();
                sifreBox.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void girisButton_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string giris = "SELECT * FROM uye_table where k_adi=@kadi and sifre=@sifre ";
            MySqlCommand komut = new MySqlCommand(giris, baglanti);
            komut.Parameters.AddWithValue("@kadi", k_adiBoxGiris.Text);
            komut.Parameters.AddWithValue("@sifre", sifreBoxGiris.Text);
            MySqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                uye = reader.GetString(0);
                rol = reader.GetString(5);
                if (rol == "admin")
                {
                    MessageBox.Show("Admin Paneli Açılıyor");
                    Form4 a = new Form4();
                    this.Hide();
                    a.Show();

                }

                if (rol == "muhasebeci")
                {
                    MessageBox.Show("Muhasebe Paneli Açılıyor");
                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();

                }


                else
                {
                    MessageBox.Show("Sipariş Yönetim Paneli Açılıyor");
                    Form3 b = new Form3();
                    b.Show();
                    this.Hide();
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz");
                k_adiBoxGiris.Clear();
                sifreBoxGiris.Clear();
                baglanti.Close();

            }

        }
    }
}
