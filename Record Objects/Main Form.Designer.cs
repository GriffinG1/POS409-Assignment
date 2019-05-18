namespace Record_Objects
{
    partial class Form1
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
            this.fileSelectionButton = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.dataArr = new System.Windows.Forms.DataGridView();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloneArr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordChoice = new System.Windows.Forms.ComboBox();
            this.displayText = new System.Windows.Forms.TextBox();
            this.endProgram = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchInputs = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelectionButton
            // 
            this.fileSelectionButton.Location = new System.Drawing.Point(662, 349);
            this.fileSelectionButton.Name = "fileSelectionButton";
            this.fileSelectionButton.Size = new System.Drawing.Size(109, 23);
            this.fileSelectionButton.TabIndex = 0;
            this.fileSelectionButton.Text = "Select File to Load";
            this.fileSelectionButton.UseVisualStyleBackColor = true;
            this.fileSelectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(29, 352);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(602, 20);
            this.filePathBox.TabIndex = 1;
            this.filePathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataArr
            // 
            this.dataArr.AllowUserToAddRows = false;
            this.dataArr.AllowUserToDeleteRows = false;
            this.dataArr.AllowUserToOrderColumns = true;
            this.dataArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.Address,
            this.EmpType,
            this.Supervisor,
            this.CostCenter,
            this.DevType,
            this.TaxType});
            this.dataArr.Location = new System.Drawing.Point(29, 12);
            this.dataArr.Name = "dataArr";
            this.dataArr.ShowEditingIcon = false;
            this.dataArr.Size = new System.Drawing.Size(742, 321);
            this.dataArr.TabIndex = 2;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // EmpType
            // 
            this.EmpType.HeaderText = "Employee Type";
            this.EmpType.Name = "EmpType";
            // 
            // Supervisor
            // 
            this.Supervisor.HeaderText = "Supervisor";
            this.Supervisor.Name = "Supervisor";
            // 
            // CostCenter
            // 
            this.CostCenter.HeaderText = "Cost Center";
            this.CostCenter.Name = "CostCenter";
            // 
            // DevType
            // 
            this.DevType.HeaderText = "Developer Type";
            this.DevType.Name = "DevType";
            // 
            // TaxType
            // 
            this.TaxType.HeaderText = "Tax Type";
            this.TaxType.Name = "TaxType";
            // 
            // cloneArr
            // 
            this.cloneArr.AllowUserToDeleteRows = false;
            this.cloneArr.AllowUserToOrderColumns = true;
            this.cloneArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cloneArr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cloneArr.Location = new System.Drawing.Point(29, 12);
            this.cloneArr.Name = "cloneArr";
            this.cloneArr.ShowEditingIcon = false;
            this.cloneArr.Size = new System.Drawing.Size(742, 321);
            this.cloneArr.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Supervisor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost Center";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Developer Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tax Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // recordChoice
            // 
            this.recordChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recordChoice.Enabled = false;
            this.recordChoice.FormattingEnabled = true;
            this.recordChoice.Location = new System.Drawing.Point(179, 400);
            this.recordChoice.Name = "recordChoice";
            this.recordChoice.Size = new System.Drawing.Size(121, 21);
            this.recordChoice.TabIndex = 4;
            this.recordChoice.SelectedIndexChanged += new System.EventHandler(this.recordChoice_SelectedIndexChanged);
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(29, 400);
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(144, 20);
            this.displayText.TabIndex = 5;
            this.displayText.Text = "Number of records to display: ";
            // 
            // endProgram
            // 
            this.endProgram.Location = new System.Drawing.Point(681, 401);
            this.endProgram.Name = "endProgram";
            this.endProgram.Size = new System.Drawing.Size(75, 23);
            this.endProgram.TabIndex = 6;
            this.endProgram.Text = "Exit";
            this.endProgram.UseVisualStyleBackColor = true;
            this.endProgram.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(600, 401);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataSource = typeof(Record_Objects.Manager);
            // 
            // searchInputs
            // 
            this.searchInputs.Enabled = false;
            this.searchInputs.Location = new System.Drawing.Point(408, 401);
            this.searchInputs.Name = "searchInputs";
            this.searchInputs.Size = new System.Drawing.Size(186, 20);
            this.searchInputs.TabIndex = 8;
            this.searchInputs.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Search terms:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchInputs);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endProgram);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.recordChoice);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.fileSelectionButton);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.cloneArr);
            this.Name = "Form1";
            this.Text = "Employee Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelectionButton;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private System.Windows.Forms.DataGridView dataArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxType;
        private System.Windows.Forms.DataGridView cloneArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox recordChoice;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button endProgram;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInputs;
        private System.Windows.Forms.TextBox textBox2;
    }
}

