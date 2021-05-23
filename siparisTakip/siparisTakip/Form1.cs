using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace siparisTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;" +
                "pwd='';database=sirket";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
