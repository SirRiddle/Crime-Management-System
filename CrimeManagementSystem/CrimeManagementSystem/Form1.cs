using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrimeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Logins where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Globals.ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
            dt.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) &&
                                 !string.IsNullOrEmpty(textBox2.Text);
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) &&
                                  !string.IsNullOrEmpty(textBox2.Text);

            // TextBox1_Enter(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text) &&
                                  !string.IsNullOrEmpty(textBox2.Text);
            // TextBox1_Enter(sender, e);
        }
    }
}
