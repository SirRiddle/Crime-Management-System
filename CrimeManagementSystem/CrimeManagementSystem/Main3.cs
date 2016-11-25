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
    public partial class Main3 : Form
    {
        public Main3()
        {
            InitializeComponent();
            fill_CB();
        }
        void fill_CB()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Charges", con);
            SqlDataReader rdr;
            try
            {
                comboBox1.Items.Clear();
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string fk = rdr.GetString(rdr.GetOrdinal("Charge No."));
                    comboBox1.Items.Add(fk);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Main3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeManagementDataSet.Prsioner' table. You can move, or remove it, as needed.
            this.prsionerTableAdapter.Fill(this.crimeManagementDataSet.Prsioner);

        }

        private void prsionerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prsionerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crimeManagementDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Prsioner([Prisoner No.],Time,[Crime Type],[Charge No.]) values('" + this.prisoner_No_TextBox.Text + "' , '" + this.timeTextBox.Text + "','" + this.crime_TypeTextBox.Text + "','" + this.charge_No_TextBox.Text + "')", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.prsionerTableAdapter.Fill(this.crimeManagementDataSet.Prsioner);
                MessageBox.Show("Record Inserted");
                prsionerDataGridView.Update();
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
            charge_No_TextBox.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CrimeManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from Prsioner where [Prisoner No.] = '" + this.prisoner_No_TextBox.Text + "' and Time = '" + this.timeTextBox.Text + "'and [Crime Type] = '" + this.crime_TypeTextBox.Text + "'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.prsionerTableAdapter.Fill(this.crimeManagementDataSet.Prsioner);
                prsionerDataGridView.Update();
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
            SqlCommand cmd = new SqlCommand("update Prsioner set Time = '" + this.timeTextBox.Text + "', [Crime Type] = '" + this.crime_TypeTextBox.Text + "' , [Charge No.] = '" + this.charge_No_TextBox.Text + "' where [Prisoner No.] = '" + this.prisoner_No_TextBox.Text + "'", con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                this.prsionerTableAdapter.Fill(this.crimeManagementDataSet.Prsioner);
                prsionerDataGridView.Update();
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
            foreach (DataGridViewRow row in prsionerDataGridView.Rows)
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
                if (row.Index == prsionerDataGridView.RowCount - 2)
                    break;
            }
            if (!found)
                MessageBox.Show("Record not found");
            textBox1.Clear();
        }
    }
}
