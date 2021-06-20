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
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
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
            
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(textBox1.Text, pattern))
            {
                con.Open();
                string query = "INSERT INTO eposta (eposta) VALUES('" + textBox1.Text + "') ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Form5 ee = new Form5();
                ee.Show();

            }
            else
            {
                MessageBox.Show("Epostanızı doğru girin");
            }
        }
    }
}
