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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       SqlConnection con = new SqlConnection("Data Source=DESKTOP-R85IR9I\\SQLEXPRESS;Initial Catalog=AnketProjeOdev;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 tt = new Form1();
            tt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(derecesi.Text) || String.IsNullOrEmpty(hizmetii.Text) || String.IsNullOrEmpty(skytoneri.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            else
            {
                Form10 uu = new Form10();
                uu.Show();

                con.Open();
                string query = "INSERT INTO tbl_defacto (mderecesi,hizmeti,oneriskyt) VALUES('" + derecesi.Text + "','" + hizmetii.Text + "','" + skytoneri.Text + "') ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        private void derecesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Back:
                case (char)Keys.Delete:
                case (char)Keys.D1:
                case (char)Keys.D2:
                case (char)Keys.D3:
                case (char)Keys.D4:
                case (char)Keys.D5:
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            derecesi.MaxLength = 1;
        }
    }
}
