namespace CrimeManagementSystem
{
    partial class Main3
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
            System.Windows.Forms.Label prisoner_No_Label;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label crime_TypeLabel;
            System.Windows.Forms.Label charge_No_Label;
            this.crimeManagementDataSet = new CrimeManagementSystem.CrimeManagementDataSet();
            this.prsionerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prsionerTableAdapter = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.PrsionerTableAdapter();
            this.tableAdapterManager = new CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager();
            this.prsionerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisoner_No_TextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.crime_TypeTextBox = new System.Windows.Forms.TextBox();
            this.charge_No_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            prisoner_No_Label = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            crime_TypeLabel = new System.Windows.Forms.Label();
            charge_No_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsionerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsionerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prisoner_No_Label
            // 
            prisoner_No_Label.AutoSize = true;
            prisoner_No_Label.Location = new System.Drawing.Point(15, 55);
            prisoner_No_Label.Name = "prisoner_No_Label";
            prisoner_No_Label.Size = new System.Drawing.Size(91, 17);
            prisoner_No_Label.TabIndex = 1;
            prisoner_No_Label.Text = "Prisoner No :";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(15, 83);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(43, 17);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time:";
            // 
            // crime_TypeLabel
            // 
            crime_TypeLabel.AutoSize = true;
            crime_TypeLabel.Location = new System.Drawing.Point(15, 111);
            crime_TypeLabel.Name = "crime_TypeLabel";
            crime_TypeLabel.Size = new System.Drawing.Size(84, 17);
            crime_TypeLabel.TabIndex = 5;
            crime_TypeLabel.Text = "Crime Type:";
            // 
            // charge_No_Label
            // 
            charge_No_Label.AutoSize = true;
            charge_No_Label.Location = new System.Drawing.Point(15, 139);
            charge_No_Label.Name = "charge_No_Label";
            charge_No_Label.Size = new System.Drawing.Size(84, 17);
            charge_No_Label.TabIndex = 7;
            charge_No_Label.Text = "Charge No :";
            // 
            // crimeManagementDataSet
            // 
            this.crimeManagementDataSet.DataSetName = "CrimeManagementDataSet";
            this.crimeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prsionerBindingSource
            // 
            this.prsionerBindingSource.DataMember = "Prsioner";
            this.prsionerBindingSource.DataSource = this.crimeManagementDataSet;
            // 
            // prsionerTableAdapter
            // 
            this.prsionerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChargesTableAdapter = null;
            this.tableAdapterManager.ComplaintsTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PrsionerTableAdapter = this.prsionerTableAdapter;
            this.tableAdapterManager.UpdateOrder = CrimeManagementSystem.CrimeManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prsionerDataGridView
            // 
            this.prsionerDataGridView.AutoGenerateColumns = false;
            this.prsionerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prsionerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prsionerDataGridView.DataSource = this.prsionerBindingSource;
            this.prsionerDataGridView.Location = new System.Drawing.Point(266, 12);
            this.prsionerDataGridView.Name = "prsionerDataGridView";
            this.prsionerDataGridView.RowTemplate.Height = 24;
            this.prsionerDataGridView.Size = new System.Drawing.Size(443, 249);
            this.prsionerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prisoner No_";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prisoner No_";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Crime Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Crime Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Charge No_";
            this.dataGridViewTextBoxColumn4.HeaderText = "Charge No_";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // prisoner_No_TextBox
            // 
            this.prisoner_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prsionerBindingSource, "Prisoner No_", true));
            this.prisoner_No_TextBox.Location = new System.Drawing.Point(112, 52);
            this.prisoner_No_TextBox.Name = "prisoner_No_TextBox";
            this.prisoner_No_TextBox.Size = new System.Drawing.Size(100, 22);
            this.prisoner_No_TextBox.TabIndex = 2;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prsionerBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(112, 80);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox.TabIndex = 4;
            // 
            // crime_TypeTextBox
            // 
            this.crime_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prsionerBindingSource, "Crime Type", true));
            this.crime_TypeTextBox.Location = new System.Drawing.Point(112, 108);
            this.crime_TypeTextBox.Name = "crime_TypeTextBox";
            this.crime_TypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.crime_TypeTextBox.TabIndex = 6;
            // 
            // charge_No_TextBox
            // 
            this.charge_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prsionerBindingSource, "Charge No_", true));
            this.charge_No_TextBox.Location = new System.Drawing.Point(112, 136);
            this.charge_No_TextBox.Name = "charge_No_TextBox";
            this.charge_No_TextBox.Size = new System.Drawing.Size(100, 22);
            this.charge_No_TextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(469, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "To Charges";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 37);
            this.button6.TabIndex = 15;
            this.button6.Text = "Find";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 22);
            this.textBox1.TabIndex = 16;
            // 
            // Main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(729, 404);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(prisoner_No_Label);
            this.Controls.Add(this.prisoner_No_TextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(crime_TypeLabel);
            this.Controls.Add(this.crime_TypeTextBox);
            this.Controls.Add(charge_No_Label);
            this.Controls.Add(this.charge_No_TextBox);
            this.Controls.Add(this.prsionerDataGridView);
            this.Name = "Main3";
            this.Text = "Main3";
            this.Load += new System.EventHandler(this.Main3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crimeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsionerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prsionerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrimeManagementDataSet crimeManagementDataSet;
        private System.Windows.Forms.BindingSource prsionerBindingSource;
        private CrimeManagementDataSetTableAdapters.PrsionerTableAdapter prsionerTableAdapter;
        private CrimeManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView prsionerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox prisoner_No_TextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox crime_TypeTextBox;
        private System.Windows.Forms.TextBox charge_No_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
    }
}