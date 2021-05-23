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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        public static string sqlbaglanti = "Server=127.0.0.1;Port=3307;Database=sirket;Uid=root;Pwd='123456789b';";
        public MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);


        public void verilerigoster6(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView6.DataSource = data;

        }
        public void verilerigoster3(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView3.DataSource = data;

        }
        public void verilerigoster5(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView5.DataSource = data;

        }
        private void button15_Click(object sender, EventArgs e)
            {
                
            }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'   ");
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
            this.dataGridView3.Columns["iskeletciID"].Visible = false;
            this.dataGridView3.Columns["kumasID"].Visible = false;
            this.dataGridView3.Columns["productID"].Visible = false;
            this.dataGridView3.Columns["satisfiyati"].Visible = false;
            this.dataGridView3.Columns["siparisID"].HeaderText = "Sipariş Numarası";
            this.dataGridView3.Columns["cilaci_adi"].HeaderText = "Cilacı Adı";
            this.dataGridView3.Columns["cilaci_siparis"].HeaderText = "Cila Sipariş Tarihi";
            this.dataGridView3.Columns["iskeletci_adi"].HeaderText = "İskeletçi Adı";
            this.dataGridView3.Columns["iskeletci_siparis"].HeaderText = "İskelet Sipariş Tarihi";
            this.dataGridView3.Columns["kumas_adi"].HeaderText = "Kumaş Adı";
            this.dataGridView3.Columns["kumas_siparis"].HeaderText = "Kumaş Sipariş Tarihi";
            this.dataGridView3.Columns["product_alinan"].HeaderText = "Alınan Ödeme";
            this.dataGridView3.Columns["product_adet"].HeaderText = "Satış Adedi";
            this.dataGridView3.Columns["product_satisf"].HeaderText = "Satış Fiyatı";
            this.dataGridView3.Columns["product_kalan"].HeaderText = "Kalan Ödeme";
            this.dataGridView3.Columns["product_nakliye"].HeaderText = "Nakliye Ücreti";
            this.dataGridView3.Columns["product_siparis"].HeaderText = "Sipariş Tarihi";
            this.dataGridView3.Columns["product_teslimat"].HeaderText = "Teslimat Tarihi";
            this.dataGridView3.Columns["u_adi"].HeaderText = "Siparişi Alan";




            baglanti.Close();

            baglanti.Open();
            verilerigoster5("SELECT*FROM uye_table");
            this.dataGridView5.Columns["uyeID"].Visible = false;
            baglanti.Close();


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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            string uyeID;
            uyeID = dataGridView5.CurrentRow.Cells["uyeID"].Value.ToString();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("UPDATE uye_table SET rol=@rol WHERE uyeID='" + uyeID + "'", baglanti);
            komut.Parameters.AddWithValue("@rol", comboBox2.SelectedItem);
            komut.ExecuteNonQuery();
            verilerigoster5("SELECT*FROM uye_table");
            this.dataGridView5.Columns["uyeID"].Visible = false;
            baglanti.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where product_siparis BETWEEN @muhasebe_tarih AND @muhasebe_tarihi  ", baglanti);
            komut3.Parameters.AddWithValue("@muhasebe_tarih", dateTimePicker5.Value);
            komut3.Parameters.AddWithValue("@muhasebe_tarihi", dateTimePicker6.Value);
            MySqlDataAdapter data = new MySqlDataAdapter(komut3);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView6.DataSource = komut.Tables[0];
            this.dataGridView6.Columns["musteriID"].Visible = false;
            this.dataGridView6.Columns["urunID"].Visible = false;
            this.dataGridView6.Columns["productID"].Visible = false;
            baglanti.Close();
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
    }
    }

