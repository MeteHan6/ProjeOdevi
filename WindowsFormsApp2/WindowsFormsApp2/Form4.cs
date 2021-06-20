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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R85IR9I\\SQLEXPRESS;Initial Catalog=AnketProjeOdev;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ww = new Form1();
            ww.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(derece.Text) || String.IsNullOrEmpty(hizmett.Text) || String.IsNullOrEmpty(oneris.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            else
            {
                Form9 uu = new Form9();
                uu.Show();

                con.Open();
                string query = "INSERT INTO tbl_yemeksepeti (mderecesi,hizmet,onerisikayet) VALUES('" + derece.Text + "','" + hizmett.Text + "','" + oneris.Text + "') ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            derece.MaxLength = 1; 
        }

        private void derece_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
