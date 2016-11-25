namespace CrimeManagementSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label complaint_No_Label;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            this.crimeManagementDataSet = new CrimeManagementSystem.CrimeManagementDataSet();
            this.complaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintsTableAdapter = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.ComplaintsTableAdapter();
            this.tableAdapterManager = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager();
            this.complaintsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint_No_TextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            complaint_No_Label = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // complaint_No_Label
            // 
            complaint_No_Label.AutoSize = true;
            complaint_No_Label.Location = new System.Drawing.Point(18, 64);
            complaint_No_Label.Name = "complaint_No_Label";
            complaint_No_Label.Size = new System.Drawing.Size(100, 17);
            complaint_No_Label.TabIndex = 1;
            complaint_No_Label.Text = "Complaint No :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(18, 120);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date:";
            // 
            // crimeManagementDataSet
            // 
            this.crimeManagementDataSet.DataSetName = "CrimeManagementDataSet";
            this.crimeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintsBindingSource
            // 
            this.complaintsBindingSource.DataMember = "Complaints";
            this.complaintsBindingSource.DataSource = this.crimeManagementDataSet;
            // 
            // complaintsTableAdapter
            // 
            this.complaintsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChargesTableAdapter = null;
            this.tableAdapterManager.ComplaintsTableAdapter = this.complaintsTableAdapter;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PrsionerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // complaintsDataGridView
            // 
            this.complaintsDataGridView.AutoGenerateColumns = false;
            this.complaintsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.complaintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.complaintsDataGridView.DataSource = this.complaintsBindingSource;
            this.complaintsDataGridView.Location = new System.Drawing.Point(291, 12);
            this.complaintsDataGridView.Name = "complaintsDataGridView";
            this.complaintsDataGridView.RowTemplate.Height = 24;
            this.complaintsDataGridView.Size = new System.Drawing.Size(403, 220);
            this.complaintsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Complaint No_";
            this.dataGridViewTextBoxColumn1.HeaderText = "Complaint No_";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // complaint_No_TextBox
            // 
            this.complaint_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Complaint No_", true));
            this.complaint_No_TextBox.Location = new System.Drawing.Point(124, 61);
            this.complaint_No_TextBox.Name = "complaint_No_TextBox";
            this.complaint_No_TextBox.Size = new System.Drawing.Size(100, 22);
            this.complaint_No_TextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(124, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintsBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(124, 117);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(477, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "To Charges";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(32, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Find";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(702, 349);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(complaint_No_Label);
            this.Controls.Add(this.complaint_No_TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.complaintsDataGridView);
            this.Name = "Main";
            this.Text = "Complaints";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrimeManagementDataSet crimeManagementDataSet;
        private System.Windows.Forms.BindingSource complaintsBindingSource;
        private CrimeManagementDataSetTableAdapters.ComplaintsTableAdapter complaintsTableAdapter;
        private CrimeManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView complaintsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox complaint_No_TextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
    }
}