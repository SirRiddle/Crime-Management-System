namespace CrimeManagementSystem
{
    partial class Main2
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
            System.Windows.Forms.Label charge_No_Label;
            System.Windows.Forms.Label witnessLabel;
            System.Windows.Forms.Label criminalLabel;
            System.Windows.Forms.Label resp__OfficerLabel;
            System.Windows.Forms.Label complaint_No_Label;
            this.crimeManagementDataSet = new CrimeManagementSystem.CrimeManagementDataSet();
            this.chargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chargesTableAdapter = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.ChargesTableAdapter();
            this.tableAdapterManager = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager();
            this.chargesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge_No_TextBox = new System.Windows.Forms.TextBox();
            this.witnessTextBox = new System.Windows.Forms.TextBox();
            this.criminalTextBox = new System.Windows.Forms.TextBox();
            this.resp__OfficerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.complaint_No_TextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            charge_No_Label = new System.Windows.Forms.Label();
            witnessLabel = new System.Windows.Forms.Label();
            criminalLabel = new System.Windows.Forms.Label();
            resp__OfficerLabel = new System.Windows.Forms.Label();
            complaint_No_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // charge_No_Label
            // 
            charge_No_Label.AutoSize = true;
            charge_No_Label.Location = new System.Drawing.Point(12, 89);
            charge_No_Label.Name = "charge_No_Label";
            charge_No_Label.Size = new System.Drawing.Size(84, 17);
            charge_No_Label.TabIndex = 1;
            charge_No_Label.Text = "Charge No :";
            // 
            // witnessLabel
            // 
            witnessLabel.AutoSize = true;
            witnessLabel.Location = new System.Drawing.Point(12, 117);
            witnessLabel.Name = "witnessLabel";
            witnessLabel.Size = new System.Drawing.Size(62, 17);
            witnessLabel.TabIndex = 3;
            witnessLabel.Text = "Witness:";
            // 
            // criminalLabel
            // 
            criminalLabel.AutoSize = true;
            criminalLabel.Location = new System.Drawing.Point(12, 145);
            criminalLabel.Name = "criminalLabel";
            criminalLabel.Size = new System.Drawing.Size(62, 17);
            criminalLabel.TabIndex = 5;
            criminalLabel.Text = "Criminal:";
            // 
            // resp__OfficerLabel
            // 
            resp__OfficerLabel.AutoSize = true;
            resp__OfficerLabel.Location = new System.Drawing.Point(12, 173);
            resp__OfficerLabel.Name = "resp__OfficerLabel";
            resp__OfficerLabel.Size = new System.Drawing.Size(95, 17);
            resp__OfficerLabel.TabIndex = 7;
            resp__OfficerLabel.Text = "Resp  Officer:";
            // 
            // complaint_No_Label
            // 
            complaint_No_Label.AutoSize = true;
            complaint_No_Label.Location = new System.Drawing.Point(12, 201);
            complaint_No_Label.Name = "complaint_No_Label";
            complaint_No_Label.Size = new System.Drawing.Size(100, 17);
            complaint_No_Label.TabIndex = 9;
            complaint_No_Label.Text = "Complaint No :";
            // 
            // crimeManagementDataSet
            // 
            this.crimeManagementDataSet.DataSetName = "CrimeManagementDataSet";
            this.crimeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chargesBindingSource
            // 
            this.chargesBindingSource.DataMember = "Charges";
            this.chargesBindingSource.DataSource = this.crimeManagementDataSet;
            // 
            // chargesTableAdapter
            // 
            this.chargesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChargesTableAdapter = this.chargesTableAdapter;
            this.tableAdapterManager.ComplaintsTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PrsionerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chargesDataGridView
            // 
            this.chargesDataGridView.AutoGenerateColumns = false;
            this.chargesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chargesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chargesDataGridView.DataSource = this.chargesBindingSource;
            this.chargesDataGridView.Location = new System.Drawing.Point(336, 12);
            this.chargesDataGridView.Name = "chargesDataGridView";
            this.chargesDataGridView.RowTemplate.Height = 24;
            this.chargesDataGridView.Size = new System.Drawing.Size(623, 313);
            this.chargesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Charge No_";
            this.dataGridViewTextBoxColumn1.HeaderText = "Charge No_";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Witness";
            this.dataGridViewTextBoxColumn2.HeaderText = "Witness";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Criminal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Criminal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Resp_ Officer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Resp_ Officer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Complaint No_";
            this.dataGridViewTextBoxColumn5.HeaderText = "Complaint No_";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // charge_No_TextBox
            // 
            this.charge_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chargesBindingSource, "Charge No_", true));
            this.charge_No_TextBox.Location = new System.Drawing.Point(118, 86);
            this.charge_No_TextBox.Name = "charge_No_TextBox";
            this.charge_No_TextBox.Size = new System.Drawing.Size(100, 22);
            this.charge_No_TextBox.TabIndex = 2;
            // 
            // witnessTextBox
            // 
            this.witnessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chargesBindingSource, "Witness", true));
            this.witnessTextBox.Location = new System.Drawing.Point(118, 114);
            this.witnessTextBox.Name = "witnessTextBox";
            this.witnessTextBox.Size = new System.Drawing.Size(100, 22);
            this.witnessTextBox.TabIndex = 4;
            // 
            // criminalTextBox
            // 
            this.criminalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chargesBindingSource, "Criminal", true));
            this.criminalTextBox.Location = new System.Drawing.Point(118, 142);
            this.criminalTextBox.Name = "criminalTextBox";
            this.criminalTextBox.Size = new System.Drawing.Size(100, 22);
            this.criminalTextBox.TabIndex = 6;
            // 
            // resp__OfficerTextBox
            // 
            this.resp__OfficerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chargesBindingSource, "Resp_ Officer", true));
            this.resp__OfficerTextBox.Location = new System.Drawing.Point(118, 170);
            this.resp__OfficerTextBox.Name = "resp__OfficerTextBox";
            this.resp__OfficerTextBox.Size = new System.Drawing.Size(100, 22);
            this.resp__OfficerTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(785, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 38);
            this.button5.TabIndex = 15;
            this.button5.Text = "To prisoners";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // complaint_No_TextBox
            // 
            this.complaint_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chargesBindingSource, "Complaint No_", true));
            this.complaint_No_TextBox.Location = new System.Drawing.Point(118, 198);
            this.complaint_No_TextBox.Name = "complaint_No_TextBox";
            this.complaint_No_TextBox.Size = new System.Drawing.Size(100, 22);
            this.complaint_No_TextBox.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(624, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 38);
            this.button6.TabIndex = 18;
            this.button6.Text = "To Complaints";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "Find";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(971, 487);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(charge_No_Label);
            this.Controls.Add(this.charge_No_TextBox);
            this.Controls.Add(witnessLabel);
            this.Controls.Add(this.witnessTextBox);
            this.Controls.Add(criminalLabel);
            this.Controls.Add(this.criminalTextBox);
            this.Controls.Add(resp__OfficerLabel);
            this.Controls.Add(this.resp__OfficerTextBox);
            this.Controls.Add(complaint_No_Label);
            this.Controls.Add(this.complaint_No_TextBox);
            this.Controls.Add(this.chargesDataGridView);
            this.Name = "Main2";
            this.Text = "Charges";
            this.Load += new System.EventHandler(this.Main2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrimeManagementDataSet crimeManagementDataSet;
        private System.Windows.Forms.BindingSource chargesBindingSource;
        private CrimeManagementDataSetTableAdapters.ChargesTableAdapter chargesTableAdapter;
        private CrimeManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView chargesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox charge_No_TextBox;
        private System.Windows.Forms.TextBox witnessTextBox;
        private System.Windows.Forms.TextBox criminalTextBox;
        private System.Windows.Forms.TextBox resp__OfficerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox complaint_No_TextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}