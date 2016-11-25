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
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
            fill_CB();
        }

        void fill_CB()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Complaints", con);
            SqlDataReader rdr;
            try
            {
                comboBox1.Items.Clear();
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string fk = rdr.GetString(rdr.GetOrdinal("Complaint No."));
                    comboBox1.Items.Add(fk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chargesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chargesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crimeManagementDataSet);

        }

        private void Main2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeManagementDataSet.Charges' table. You can move, or remove it, as needed.
            this.chargesTableAdapter.Fill(this.crimeManagementDataSet.Charges);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Charges([Charge No.],Witness,Criminal,[Resp. Officer],[Complaint No.]) values('" + this.charge_No_TextBox.Text + "' , '" + this.witnessTextBox.Text + "','" + this.criminalTextBox.Text + "','" + this.resp__OfficerTextBox.Text + "' , '" + this.complaint_No_TextBox.Text + "')", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.chargesTableAdapter.Fill(this.crimeManagementDataSet.Charges);
                MessageBox.Show("Record Inserted");
                fill_CB();
                chargesDataGridView.Update();
                cmd.Clone();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_CB();
            complaint_No_TextBox.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from Charges where [Charge No.] = '" + this.charge_No_TextBox.Text + "' and Witness = '" + this.witnessTextBox.Text + "'and Criminal = '" + this.criminalTextBox.Text + "'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.chargesTableAdapter.Fill(this.crimeManagementDataSet.Charges);
                chargesDataGridView.Update();
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
            SqlCommand cmd = new SqlCommand("update Charges set Witness = '" + this.witnessTextBox.Text + "', Criminal = '" + this.criminalTextBox.Text + "' , [Resp. Officer] = '" + this.resp__OfficerTextBox.Text + "' , [Complaint No.] = '" + this.complaint_No_TextBox.Text + "' where [Charge No.] = '" + this.charge_No_TextBox.Text + "'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.chargesTableAdapter.Fill(this.crimeManagementDataSet.Charges);
                chargesDataGridView.Update();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.ss3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (DataGridViewRow row in chargesDataGridView.Rows)
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
                if (row.Index == chargesDataGridView.RowCount - 2)
                    break;
            }
            if (!found)
                MessageBox.Show("Record not found");
            textBox1.Clear();
        }
    }
}

