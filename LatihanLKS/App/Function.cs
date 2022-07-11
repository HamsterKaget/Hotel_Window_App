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


public partial class Function
{
    public static Function instance;
    public static string sqlconn = @"Data Source=DESKTOP-93DH9HT\SQLEXPRESS;Initial Catalog=db_lks;Integrated Security=True";

    public Function()
    {
        instance = this;
    }

    public static string[] login(string sql)
    {
        SqlConnection db = new SqlConnection(sqlconn);
        SqlDataAdapter sda = new SqlDataAdapter(sql, db);
        DataTable dt = new DataTable();
        sda.Fill(dt);

        if(dt.Rows.Count >= 0)
        {
            var stringArr = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return stringArr;
        } else
        {
            string[] stringArr = { "null" };
            return stringArr;
        }
        
        


    }



}
