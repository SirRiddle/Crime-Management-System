using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeManagementDataSet.Complaints' table. You can move, or remove it, as needed.
            this.complaintsTableAdapter.Fill(this.crimeManagementDataSet.Complaints);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Complaints([Complaint No.],Date,Name) values('" + this.complaint_No_TextBox.Text + "' , '" + this.dateTextBox.Text + "','" + this.nameTextBox.Text + "')", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.complaintsTableAdapter.Fill(this.crimeManagementDataSet.Complaints);
                MessageBox.Show("Record Inserted");
                complaintsDataGridView.Update();
                cmd.Clone();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            /*
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insertcomp", con);
            cmd.CommandText="CrimeManagement.insertcomp '" + this.complaint_No_TextBox.Text + "' , '" + this.nameTextBox.Text + "','" + this.dateTextBox.Text + "'";
            //SqlCommand cmd = new SqlCommand("EXECUTE insertcomp '" + this.complaint_No_TextBox.Text + "' , '" + this.nameTextBox.Text + "','" + this.dateTextBox.Text + "')", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.complaintsTableAdapter.Fill(this.crimeManagementDataSet.Complaints);
                MessageBox.Show("Record Inserted");
                complaintsDataGridView.Update();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from Complaints where [Complaint No.]='" + this.complaint_No_TextBox.Text + "' and Date = '" + this.dateTextBox.Text + "'and Name ='" +  this.nameTextBox.Text + "'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.complaintsTableAdapter.Fill(this.crimeManagementDataSet.Complaints);
                complaintsDataGridView.Update();
                MessageBox.Show("Record deleted");                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update Complaints set  Date = '" + this.dateTextBox.Text + "', Name ='" + this.nameTextBox.Text + "' where [Complaint No.] = '"+this.complaint_No_TextBox.Text+"'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.complaintsTableAdapter.Fill(this.crimeManagementDataSet.Complaints);
                complaintsDataGridView.Update();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.ss2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (DataGridViewRow row in complaintsDataGridView.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (textBox1.Text == cell.Value.ToString())
                    {
                        row.Selected = true;
                        found = true;
                        break;
                    }
                }
                if (row.Index == complaintsDataGridView.RowCount - 2)
                    break;
            }
            if (!found)
                MessageBox.Show("Record not found");
            textBox1.Clear();
        }
    }
}