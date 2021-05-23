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
    public partial class Form2 : Form
    {
        public static string sqlbaglanti = "Server=127.0.0.1;Port=3307;Database=sirket;Uid=root;Pwd='123456789b';";
        public MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        public static string uye;
        public Form2()
        {
            InitializeComponent();
        }
        public void GetId()
        {

        }
        public void verilerigoster6(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView6.DataSource = data;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            verilerigoster6("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'pasif'   ");
            this.dataGridView6.Columns["musteriID"].Visible = false;
            this.dataGridView6.Columns["urunID"].Visible = false;
            this.dataGridView6.Columns["productID"].Visible = false;
            this.dataGridView6.Columns["satisfiyati"].HeaderText = "Alış Fiyatı";
            this.dataGridView6.Columns["siparisID"].HeaderText = "Sipariş Numarası";
            this.dataGridView6.Columns["product_alinan"].HeaderText = "Alınan Ödeme";
            this.dataGridView6.Columns["product_adet"].HeaderText = "Satış Adedi";
            this.dataGridView6.Columns["product_satisf"].HeaderText = "Satış Fiyatı";
            this.dataGridView6.Columns["product_kalan"].HeaderText = "Kalan Ödeme";
            this.dataGridView6.Columns["product_nakliye"].HeaderText = "Nakliye Ücreti";
            this.dataGridView6.Columns["product_siparis"].HeaderText = "Sipariş Tarihi";
            this.dataGridView6.Columns["product_teslimat"].HeaderText = "Teslimat Tarihi";
            this.dataGridView6.Columns["u_adi"].HeaderText = "Siparişi Alan";
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            verilerigoster6("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'pasif'   ");
            this.dataGridView6.Columns["musteriID"].Visible = false;
            this.dataGridView6.Columns["urunID"].Visible = false;
            this.dataGridView6.Columns["productID"].Visible = false;
            this.dataGridView6.Columns["satisfiyati"].HeaderText = "Alış Fiyatı";
            this.dataGridView6.Columns["siparisID"].HeaderText = "Sipariş Numarası";

            this.dataGridView6.Columns["product_alinan"].HeaderText = "Alınan Ödeme";
            this.dataGridView6.Columns["product_adet"].HeaderText = "Satış Adedi";
            this.dataGridView6.Columns["product_satisf"].HeaderText = "Satış Fiyatı";
            this.dataGridView6.Columns["product_kalan"].HeaderText = "Kalan Ödeme";
            this.dataGridView6.Columns["product_nakliye"].HeaderText = "Nakliye Ücreti";
            this.dataGridView6.Columns["product_siparis"].HeaderText = "Sipariş Tarihi";
            this.dataGridView6.Columns["product_teslimat"].HeaderText = "Teslimat Tarihi";
            this.dataGridView6.Columns["u_adi"].HeaderText = "Siparişi Alan";
            baglanti.Close();
        }
    }
    }

