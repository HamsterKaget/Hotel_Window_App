using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LatihanLKS
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static string[] loginData;
        public static string sqlconn = @"Data Source=DESKTOP-93DH9HT\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pw = textBox2.Text;
            string sql = "SELECT * FROM Karyawan WHERE Email='" + email + "' AND Password='" + pw + "'";

            if ( string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) )
            {
                MessageBox.Show("Email & Password harus diisi terlebih dahulu");
            } 
            else
            {
                loginData = login(sql);

                if ( loginData == null )
                {
                    MessageBox.Show("Email atau Password anda salah !");
                }
                else if (loginData[2].ToString() == email && loginData[3].ToString() == pw )
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
            }            

        }

        private string[] login(string sql)
        {
            SqlConnection db = new SqlConnection(sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sql, db);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string[] Arr = null;

            try
            {
                Arr = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            } catch ( Exception )
            {
                return Arr;
            }

            return Arr;
        }

    }
}