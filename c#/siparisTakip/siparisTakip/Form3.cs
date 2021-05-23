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

    public partial class Form3 : Form
    {
        public static string sqlbaglanti = "Server=127.0.0.1;Port=3307;Database=sirket;Uid=root;Pwd='123456789b';";
        public MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);

        public Form3()
        {
            InitializeComponent();
        }
        public void verilerigoster(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView1.DataSource = data;

        }
        public void verilerigoster3(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView3.DataSource = data;

        }
        public void verilerigoster2(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView2.DataSource = data;
        }

        public void verilerigoster4(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView4.DataSource = data;
        }
        public void verilerigoster5(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView5.DataSource = data;

        }
        public void verilerigoster6(string veriler)
        {
            MySqlDataAdapter komut = new MySqlDataAdapter(veriler, baglanti);
            DataTable data = new DataTable();
            komut.Fill(data);

            dataGridView6.DataSource = data;

        }


        void kayitsil(int urunID)
        {
            MySqlCommand sil = new MySqlCommand("DELETE FROM urun_table WHERE urunID=@urunID", baglanti);
            sil.Parameters.AddWithValue("@urunID", urunID);
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
        void kayitsil2(int musteriID)
        {
            MySqlCommand sil = new MySqlCommand("DELETE FROM musteri_table WHERE musteriID=@musteriID", baglanti);
            sil.Parameters.AddWithValue("@musteriID", musteriID);
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
        void kayitsil3(int siparisID)
        {
            MySqlCommand sil = new MySqlCommand("DELETE FROM siparis_table WHERE siparisID=@siparisID", baglanti);
            sil.Parameters.AddWithValue("@siparisID", siparisID);
            baglanti.Open();
            sil.ExecuteNonQuery();
            baglanti.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "SELECT *FROM kdv_table";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            MySqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kdv"]);
            }
            baglanti.Close();
            baglanti.Open();

            verilerigoster2("SELECT *FROM musteri_table");
            this.dataGridView2.Columns[0].Visible = false;
            baglanti.Close();


            baglanti.Open();

            verilerigoster("SELECT*FROM urun_table");

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns["satisfiyati"].HeaderText = "Alış Fiyatı";

            baglanti.Close();

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

            verilerigoster4("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'pasif'   ");
            this.dataGridView4.Columns["musteriID"].Visible = false;
            this.dataGridView4.Columns["urunID"].Visible = false;
            this.dataGridView4.Columns["cilaciID"].Visible = false;
            this.dataGridView4.Columns["iskeletciID"].Visible = false;
            this.dataGridView4.Columns["kumasID"].Visible = false;
            this.dataGridView4.Columns["productID"].Visible = false;
            this.dataGridView3.Columns["satisfiyati"].Visible = false;

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


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into musteri_table(musteri_adi,musteri_soyadi,musteri_tel,musteri_adres) values (@m_adi,@m_soyadi,@m_tel,@m_adres)";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@m_adi", madiBox.Text);
                komut.Parameters.AddWithValue("@m_soyadi", msoyadiBox.Text);
                komut.Parameters.AddWithValue("@m_tel", mtelBox.Text);
                komut.Parameters.AddWithValue("@m_adres", madresBox.Text);
                komut.ExecuteNonQuery();
                verilerigoster2("SELECT*FROM musteri_table");
                this.dataGridView2.Columns[0].Visible = false;
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void yeniUrunEkle_Click(object sender, EventArgs e)
        {
            //yeni urun ekleme
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand(" INSERT INTO urun_table (stokkodu,urunadi,satisfiyati) VALUES (@stokkod,@urunad,@satisfiyat)", baglanti);
            ekle.Parameters.AddWithValue("@stokkod", stokBox.Text);
            ekle.Parameters.AddWithValue("@urunad", urunadiBox.Text);
            ekle.Parameters.AddWithValue("@satisfiyat", urunsatisf.Text);
            ekle.ExecuteNonQuery();
            verilerigoster("SELECT*FROM urun_table");
            this.dataGridView1.Columns[0].Visible = false;
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" )
            {
                int alinan = Convert.ToInt32(textBox5.Text);
                int kargo = Convert.ToInt32(textBox8.Text);
                int adet = Convert.ToInt32(textBox6.Text);
                int satisf = Convert.ToInt32(textBox7.Text);

                int satistoplam = (satisf * adet) + kargo;

                textBox9.Text = satistoplam.ToString();
                int kalan = (satistoplam - alinan);
                textBox10.Text = kalan.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Değer Bırakmayınız, Boş Girmek İstediklerinize 0 veriniz.");
            }
            
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                MySqlCommand komut = new MySqlCommand("INSERT INTO cilaci_table(cilaci_adi,cilaci_siparis) VALUES(@cilaci_adi,@cilaci_siparis)", baglanti);
                komut.Parameters.AddWithValue("@cilaci_adi", textBox1.Text);
                komut.Parameters.AddWithValue("@cilaci_siparis", dateTimePicker1.Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MySqlCommand komut2 = new MySqlCommand("INSERT INTO iskeletci_table(iskeletci_adi,iskeletci_siparis) VALUES(@iskeletci_adi,@iskeletci_siparis)", baglanti);
                komut2.Parameters.AddWithValue("@iskeletci_adi", textBox2.Text);
                komut2.Parameters.AddWithValue("@iskeletci_siparis", dateTimePicker2.Value);
                komut2.ExecuteNonQuery();
                MySqlCommand komut3 = new MySqlCommand("INSERT INTO kumas_table(kumas_adi,kumas_metresi,kumas_siparis) VALUES(@kumas_adi,@kumas_metresi,@kumas_siparis)", baglanti);
                komut3.Parameters.AddWithValue("@kumas_adi", textBox3.Text);
                komut3.Parameters.Add("@kumas_metresi", MySqlDbType.Int32).Value = textBox4.Text;
                komut3.Parameters.AddWithValue("@kumas_siparis", dateTimePicker3.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                tabControl1.SelectTab(tabPage5);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && comboBox1.Text != "")
            {
                string message = "Tüm bilgileri doğru girdiğinizden emin misiniz?";
                string title = "Kayıt Bitir";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    MySqlCommand komut5 = new MySqlCommand("INSERT INTO product_table(product_alinan,product_adet,product_satisf,product_kalan,product_nakliye,product_siparis,product_teslimat) VALUES(@product_alinan,@product_adet,@product_satisf,@product_kalan,@product_nakliye,@product_siparis,'2020-12-20')", baglanti);
                    komut5.Parameters.Add("@product_alinan", MySqlDbType.Int32).Value = textBox5.Text;
                    komut5.Parameters.Add("@product_adet", MySqlDbType.Int32).Value = textBox6.Text;
                    komut5.Parameters.Add("@product_satisf", MySqlDbType.Int32).Value = textBox9.Text;
                    komut5.Parameters.Add("@product_kalan", MySqlDbType.Int32).Value = textBox10.Text;
                    komut5.Parameters.Add("@product_nakliye", MySqlDbType.Int32).Value = textBox8.Text;
                    komut5.Parameters.AddWithValue("@product_siparis", dateTimePicker4.Value);
                    komut5.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Bilgiler Başarıyla Kaydedildi");

                    int kdv = comboBox1.SelectedIndex + 1;
                    baglanti.Open();
                    MySqlCommand komut4 = new MySqlCommand("INSERT INTO siparis_table (cilaciID,iskeletciID,kumasID,productID,musteriID,urunID,kdvID,uyeID,aktiflik) Values((Select MAX(cilaciID) From cilaci_table),(Select MAX(iskeletciID) From iskeletci_table),(Select MAX(kumasID) From kumas_table),(Select MAX(productID) From product_table),@musteriID,@urunID,@kdvID,@uyeID,'aktif')", baglanti);
                    komut4.Parameters.AddWithValue("@uyeID", Form1.uye);
                    komut4.Parameters.Add("@musteriID", MySqlDbType.Int32).Value = label22.Text;
                    komut4.Parameters.Add("@urunID", MySqlDbType.Int32).Value = label23.Text;
                    komut4.Parameters.Add("@kdvID", MySqlDbType.Int32).Value = kdv;
                    komut4.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();

                    verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'   ");
                    this.dataGridView3.Columns["musteriID"].Visible = false;
                    this.dataGridView3.Columns["urunID"].Visible = false;
                    this.dataGridView3.Columns["cilaciID"].Visible = false;
                    this.dataGridView3.Columns["iskeletciID"].Visible = false;
                    this.dataGridView3.Columns["kumasID"].Visible = false;
                    this.dataGridView3.Columns["productID"].Visible = false;



                    baglanti.Close();


                }
                else
                {
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Değerleri Doldurun, Boş Girmek İstediklerinize 0 Girin.");
            }
           

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //secilen urunu siler
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int urunID = Convert.ToInt32(drow.Cells[0].Value);
                kayitsil(urunID);
            }
            verilerigoster("SELECT * FROM urun_table");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int musteriID = Convert.ToInt32(drow.Cells[0].Value);
                kayitsil2(musteriID);
            }
            verilerigoster2("SELECT * FROM musteri_table");


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int a = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[a];
                label22.Text = Convert.ToString(selectedRow.Cells["musteriID"].Value);
                secilenMusteriBox.Text = Convert.ToString(selectedRow.Cells["musteri_adi"].Value);
                tabControl1.SelectTab(tabPage4);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int a = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[a];
                label23.Text= Convert.ToString(selectedRow.Cells["urunID"].Value);
                if (label23.Text != "label23")
                {
                    tabControl1.SelectTab(tabPage3);

                }
                else {
                    MessageBox.Show("Lütfen Bir Ürün Seçiniz!");
                }              
            }

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int a = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[a];
                secilenUrunBox.Text = Convert.ToString(selectedRow.Cells["urunadi"].Value);
               
                tabControl1.SelectTab(tabPage3);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //secilen urunu günceller
            string urunID, stokkodu, urunadi, satisfiyati;
            urunID = dataGridView1.CurrentRow.Cells["urunID"].Value.ToString();
            stokkodu = dataGridView1.CurrentRow.Cells["stokkodu"].Value.ToString();
            urunadi = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            satisfiyati = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

            baglanti.Open();
            MySqlCommand guncelle = new MySqlCommand("UPDATE urun_table SET stokkodu= '" + stokkodu + "' ,urunadi= '" + urunadi + "' ,satisfiyati= '" + satisfiyati + "' WHERE urunID='" + urunID + "'", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("SELECT * FROM urun_table");
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string musteriID, musteri_adi, musteri_soyadi, musteri_tel, musteri_adres;
            musteriID = dataGridView2.CurrentRow.Cells["musteriID"].Value.ToString();
            musteri_adi = dataGridView2.CurrentRow.Cells["musteri_adi"].Value.ToString();
            musteri_soyadi = dataGridView2.CurrentRow.Cells["musteri_soyadi"].Value.ToString();
            musteri_tel = dataGridView2.CurrentRow.Cells["musteri_tel"].Value.ToString();
            musteri_adres = dataGridView2.CurrentRow.Cells["musteri_adres"].Value.ToString();
            baglanti.Open();
            MySqlCommand guncelle = new MySqlCommand("UPDATE musteri_table SET musteri_adi= '" + musteri_adi + "' ,musteri_soyadi= '" + musteri_soyadi + "' ,musteri_tel= '" + musteri_tel + "',musteri_adres= '" + musteri_adres + "'  WHERE musteriID='" + musteriID + "'", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster2("SELECT * FROM musteri_table");
        }

      

       

        private void button15_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string musteriID, musteri_adi, musteri_soyadi, musteri_tel, musteri_adres, cilaciID, cilaci_adi, cilaci_siparis,
              iskeletciID, iskeletci_adi, iskeletci_siparis, kumasID, kumas_adi, kumas_siparis, kumas_metresi, productID, product_teslimat;

            musteriID = dataGridView3.CurrentRow.Cells["musteriID"].Value.ToString();
            musteri_adi = dataGridView3.CurrentRow.Cells["musteri_adi"].Value.ToString();
            musteri_soyadi = dataGridView3.CurrentRow.Cells["musteri_soyadi"].Value.ToString();
            musteri_tel = dataGridView3.CurrentRow.Cells["musteri_tel"].Value.ToString();
            musteri_adres = dataGridView3.CurrentRow.Cells["musteri_adres"].Value.ToString();

            cilaciID = dataGridView3.CurrentRow.Cells["cilaciID"].Value.ToString();
            cilaci_adi = dataGridView3.CurrentRow.Cells["cilaci_adi"].Value.ToString();
            cilaci_siparis = dataGridView3.CurrentRow.Cells["cilaci_siparis"].Value.ToString();

            iskeletciID = dataGridView3.CurrentRow.Cells["iskeletciID"].Value.ToString();
            iskeletci_adi = dataGridView3.CurrentRow.Cells["iskeletci_adi"].Value.ToString();
            iskeletci_siparis = dataGridView3.CurrentRow.Cells["iskeletci_siparis"].Value.ToString();

            kumasID = dataGridView3.CurrentRow.Cells["kumasID"].Value.ToString();
            kumas_adi = dataGridView3.CurrentRow.Cells["kumas_adi"].Value.ToString();
            kumas_siparis = dataGridView3.CurrentRow.Cells["kumas_siparis"].Value.ToString();
            kumas_metresi = dataGridView3.CurrentRow.Cells["kumas_metresi"].Value.ToString();

            productID = dataGridView3.CurrentRow.Cells["productID"].Value.ToString();
            product_teslimat = dataGridView3.CurrentRow.Cells["product_teslimat"].Value.ToString();

            MySqlCommand guncelle = new MySqlCommand("UPDATE siparis_table inner join musteri_table on siparis_table.musteriID=musteri_table.musteriID  inner join cilaci_table on siparis_table.cilaciID=cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID=iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID=kumas_table.kumasID  inner join product_table on siparis_table.productID = product_table.productID SET  musteri_adi= '" + musteri_adi + "' ,musteri_soyadi= '" + musteri_soyadi + "', musteri_tel= '" + musteri_tel + "', musteri_adres= '" + musteri_adres + "', cilaci_adi= '" + cilaci_adi + "', cilaci_siparis= '" + cilaci_siparis + "', iskeletci_adi ='" + iskeletci_adi + "', iskeletci_siparis='" + iskeletci_siparis + "', kumas_adi ='" + kumas_adi + "', kumas_siparis='" + kumas_siparis + "',  kumas_metresi = '" + kumas_metresi + "', product_teslimat='" + product_teslimat + "' where musteri_table.musteriID='" + musteriID + "' and cilaci_table.cilaciID='" + cilaciID + "'  and iskeletci_table.iskeletciID = '" + iskeletciID + "' and kumas_table.kumasID='" + kumasID + "' and product_table.productID ='" + productID + "' ", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'  ");
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
             this.dataGridView3.Columns["iskeletciID"].Visible = false;
             this.dataGridView3.Columns["kumasID"].Visible = false;
             this.dataGridView3.Columns["productID"].Visible = false;
            this.dataGridView3.Columns["satisfiyati"].Visible = false;
            verilerigoster2("SELECT * FROM musteri_table");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string message = "Seçilen Kaydı Silmek İstediğinizden Emin Misiniz?";
            string title = "Siparişi Sil";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView3.SelectedRows)
                {
                    int siparisID = Convert.ToInt32(drow.Cells[0].Value);
                    kayitsil3(siparisID);
                }

                verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'  ");
                this.dataGridView3.Columns["musteriID"].Visible = false;
                this.dataGridView3.Columns["urunID"].Visible = false;
                this.dataGridView3.Columns["cilaciID"].Visible = false;
                this.dataGridView3.Columns["iskeletciID"].Visible = false;
                this.dataGridView3.Columns["kumasID"].Visible = false;
                this.dataGridView3.Columns["productID"].Visible = false;

            }
            else this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
      
        }

        private void button18_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string siparisID;
            siparisID = dataGridView3.CurrentRow.Cells["siparisID"].Value.ToString();
            MySqlCommand bitir = new MySqlCommand("Update siparis_table set aktiflik='pasif' where siparisID='"+siparisID+"'",baglanti);
            bitir.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'  ");
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
            this.dataGridView3.Columns["iskeletciID"].Visible = false;
            this.dataGridView3.Columns["kumasID"].Visible = false;
            this.dataGridView3.Columns["productID"].Visible = false;
            verilerigoster4("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'pasif'  ");
            this.dataGridView4.Columns["musteriID"].Visible = false;
            this.dataGridView4.Columns["urunID"].Visible = false;
            this.dataGridView4.Columns["cilaciID"].Visible = false;
            this.dataGridView4.Columns["iskeletciID"].Visible = false;
            this.dataGridView4.Columns["kumasID"].Visible = false;
            this.dataGridView4.Columns["productID"].Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string siparisID;
            siparisID = dataGridView4.CurrentRow.Cells["siparisID"].Value.ToString();
            MySqlCommand bitir = new MySqlCommand("Update siparis_table set aktiflik='aktif' where siparisID='" + siparisID + "'", baglanti);
            bitir.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster4("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'pasif'  ");
            this.dataGridView4.Columns["musteriID"].Visible = false;
            this.dataGridView4.Columns["urunID"].Visible = false;
            this.dataGridView4.Columns["cilaciID"].Visible = false;
            this.dataGridView4.Columns["iskeletciID"].Visible = false;
            this.dataGridView4.Columns["kumasID"].Visible = false;
            this.dataGridView4.Columns["productID"].Visible = false;
            verilerigoster3("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID where aktiflik like 'aktif'  ");
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
            this.dataGridView3.Columns["iskeletciID"].Visible = false;
            this.dataGridView3.Columns["kumasID"].Visible = false;
            this.dataGridView3.Columns["productID"].Visible = false;
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

       

        private void urunAraBox_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("SELECT * FROM urun_table where urunadi like '%" + urunAraBox.Text + "%'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView1.DataSource = komut.Tables[0];
            baglanti.Close();
        }

        private void musteriAraBox_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();

            MySqlCommand ekle = new MySqlCommand("SELECT * FROM musteri_table where musteri_adi like '%" + musteriAraBox.Text + "%'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView2.DataSource = komut.Tables[0];
            baglanti.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID   where musteri_adi like '%" + textBox12.Text + "%' and urunadi like '%" + textBox11.Text + "%' and aktiflik like 'aktif'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView3.DataSource = komut.Tables[0];
            baglanti.Close();
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
            this.dataGridView3.Columns["iskeletciID"].Visible = false;
            this.dataGridView3.Columns["kumasID"].Visible = false;
            this.dataGridView3.Columns["productID"].Visible = false;
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID   where musteri_adi like '%" + textBox12.Text + "%' and urunadi like '%" + textBox11.Text + "%' and aktiflik like 'aktif'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView3.DataSource = komut.Tables[0];
            baglanti.Close();
            this.dataGridView3.Columns["musteriID"].Visible = false;
            this.dataGridView3.Columns["urunID"].Visible = false;
            this.dataGridView3.Columns["cilaciID"].Visible = false;
            this.dataGridView3.Columns["iskeletciID"].Visible = false;
            this.dataGridView3.Columns["kumasID"].Visible = false;
            this.dataGridView3.Columns["productID"].Visible = false;
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID   where musteri_adi like '%" + textBox12.Text + "%' and urunadi like '%" + textBox11.Text + "%' and aktiflik like 'pasif'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView4.DataSource = komut.Tables[0];
            baglanti.Close();
            this.dataGridView4.Columns["musteriID"].Visible = false;
            this.dataGridView4.Columns["urunID"].Visible = false;
            this.dataGridView4.Columns["cilaciID"].Visible = false;
            this.dataGridView4.Columns["iskeletciID"].Visible = false;
            this.dataGridView4.Columns["kumasID"].Visible = false;
            this.dataGridView4.Columns["productID"].Visible = false;
            this.dataGridView4.Columns["satisfiyati"].Visible = false;
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("Select siparis_table.siparisID,musteri_table.musteriID,musteri_table.musteri_adi,musteri_table.musteri_soyadi,musteri_table.musteri_tel,musteri_table.musteri_adres,urun_table.urunID,urun_table.stokkodu,urun_table.urunadi,urun_table.satisfiyati,cilaci_table.cilaciID,cilaci_table.cilaci_adi,cilaci_table.cilaci_siparis,iskeletci_table.iskeletciID,iskeletci_table.iskeletci_adi,iskeletci_table.iskeletci_siparis,kumas_table.kumasID,kumas_table.kumas_adi,kumas_table.kumas_metresi,kumas_table.kumas_siparis,product_table.productID,product_table.product_alinan,product_table.product_adet,product_table.product_satisf,product_table.product_kalan,product_table.product_nakliye,product_table.product_siparis,product_table.product_teslimat,kdv_table.kdv,uye_table.u_adi,siparis_table.aktiflik from siparis_table inner join musteri_table on siparis_table.musteriID = musteri_table.musteriID inner join urun_table on siparis_table.urunID = urun_table.urunID inner join cilaci_table on siparis_table.cilaciID = cilaci_table.cilaciID inner join iskeletci_table on siparis_table.iskeletciID = iskeletci_table.iskeletciID inner join kumas_table on siparis_table.kumasID = kumas_table.kumasID inner join product_table on siparis_table.productID = product_table.productID inner join kdv_table on siparis_table.kdvID = kdv_table.kdvID inner join uye_table on siparis_table.uyeID = uye_table.uyeID   where musteri_adi like '%" + textBox12.Text + "%' and urunadi like '%" + textBox11.Text + "%' and aktiflik like 'pasif'", baglanti);
            MySqlDataAdapter data = new MySqlDataAdapter(ekle);
            DataSet komut = new DataSet();
            data.Fill(komut);
            dataGridView4.DataSource = komut.Tables[0];
            baglanti.Close();
            this.dataGridView4.Columns["musteriID"].Visible = false;
            this.dataGridView4.Columns["urunID"].Visible = false;
            this.dataGridView4.Columns["cilaciID"].Visible = false;
            this.dataGridView4.Columns["iskeletciID"].Visible = false;
            this.dataGridView4.Columns["kumasID"].Visible = false;
            this.dataGridView4.Columns["productID"].Visible = false;
            this.dataGridView4.Columns["satisfiyati"].Visible = false;
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
