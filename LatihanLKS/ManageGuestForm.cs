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
using System.Data;


namespace LatihanLKS
{
    public partial class ManageGuestForm : Form
    {
        public static string id;
        public static string idKendaraan;
        SqlConnection db = new SqlConnection(Form1.sqlconn);


        public ManageGuestForm()
        {
            InitializeComponent();
            load_data("SELECT * FROM Penghuni");
            fillCombo();
        }

        private void load_data(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, db);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void fillCombo()
        {
            string sql = "SELECT * FROM TipeKendaraan";
            SqlDataAdapter sda = new SqlDataAdapter(sql, db);
            SqlDataReader myReader;

            try
            {
                db.Open();
                myReader = sda.SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string key = myReader.GetString("NamaTipeKendaraan");
                    comboBox1.Items.Add(key);
                    
                }
                db.Close();

            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           

        }

        private void clear_data()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void ManageGuestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            if ( string.IsNullOrEmpty(search))
            {
                load_data("SELECT * FROM Penghuni");
            } else
            {
                load_data("SELECT * FROM Penghuni WHERE NamaPenghuni LIKE '%" + search + "%'");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                idKendaraan = row.Cells[6].Value.ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            string Email = textBox3.Text;
            string NomorKTP = textBox4.Text;
            string NomorTelp = textBox5.Text;
            string NomorPlat = textBox6.Text;
            string value = comboBox1.SelectedText;
            int IDKendaraan;
            MessageBox.Show(value);

            if (value == "Motor")
            {
                IDKendaraan = 1;
            } else if ( value == "Mobil" )
            {
                IDKendaraan = 2;
            }

            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Semua Field Harus Diisi Terlebih Dahulu !");
            }
            else
            {

                string values = "('" + Name + "','" + Email + "','" + NomorKTP + "','" + NomorTelp + "','" + NomorPlat + "','" + value + "')";
                string sql = "INSERT INTO Penghuni(NamaPenghuni, NomorKTP, Email, NomorHP, PlatNoKendaraan, IDTipeKendaraan) VALUES " + values;

                SqlDataAdapter sda = new SqlDataAdapter(sql, db);
                db.Open();
                sda.SelectCommand.ExecuteNonQuery();
                db.Close();
                clear_data();
                MessageBox.Show("Data berhasil ditambahkan !");

            }

            load_data("SELECT * FROM Penghuni");
        }

    }
}
