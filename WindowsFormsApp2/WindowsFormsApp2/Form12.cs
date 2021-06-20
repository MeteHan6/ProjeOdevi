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


namespace WindowsFormsApp2
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R85IR9I\\SQLEXPRESS;Initial Catalog=AnketProjeOdev;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 zz = new Form1();
            zz.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM eposta";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            con.Open();
            string query2 = "SELECT * FROM tbl_defacto";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();

            con.Open();
            string query3 = "SELECT * FROM tbl_yemeksepeti";
            SqlDataAdapter SDA3 = new SqlDataAdapter(query3, con);
            DataTable dt3 = new DataTable();
            SDA3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            con.Close();
        }
    }
}
