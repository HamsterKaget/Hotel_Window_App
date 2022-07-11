using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LatihanLKS
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmPassword = textBox3.Text;

            if ( string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Semua Field Harus Diisi !");
            }
            else if (oldPassword != Form1.loginData[3].ToString())
            {
                MessageBox.Show("Harap masukan password lama anda dengan benar !");
            }
            else if ( newPassword != confirmPassword )
            {
                MessageBox.Show("Harap konfirmasi password anda dengan benar !");
            }
            else
            {
                string sql = "UPDATE Karyawan SET Password='" + newPassword +"' WHERE IDKaryawan='" + Form1.loginData[0] + "'";
                SqlConnection db = new SqlConnection(Form1.sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sql, db);
                db.Open();
                sda.SelectCommand.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("Password anda berhasil diubah silahkan login kembali !");

                
                Form1 form = new Form1();
                this.Hide();
                form.Show();
                this.Close();
                
            }

        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
