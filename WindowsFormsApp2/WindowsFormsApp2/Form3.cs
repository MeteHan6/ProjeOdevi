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
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dd = new Form1();
            dd.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka = kadi.Text;
            string sfr = sifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-R85IR9I\\SQLEXPRESS;Initial Catalog=AnketProjeOdev;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM AdminGiris where kullaniciadi='" + kadi.Text + "' AND sifre='" + sifre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form12 dd2 = new Form12();
                dd2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi yaptınız! Lütfen bilgilerinizi  doğru girdiğinizden emin olunuz.");
            }
            con.Close();
        }
    }
}
