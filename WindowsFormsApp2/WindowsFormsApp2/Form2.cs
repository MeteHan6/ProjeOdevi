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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ka = kadi.Text;
            string sfr = sifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-R85IR9I\\SQLEXPRESS;Initial Catalog=AnketProjeOdev;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM SirketGiris where kullaniciadi='" + kadi.Text + "' AND sifre='" + sifre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (kadi.Text == "yemeksepeti" && sifre.Text == "yemeksepeti")
                { 
                this.Hide();
                Form8 yy = new Form8();
                yy.Show();
                }
                else if (kadi.Text == "defacto" && sifre.Text == "defacto")
                {
                    this.Hide();
                    Form11 zz = new Form11();
                    zz.Show();
                }
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi yaptınız! Lütfen bilgilerinizi  doğru girdiğinizden emin olunuz.");
            }
            con.Close();
        }
    }
}
