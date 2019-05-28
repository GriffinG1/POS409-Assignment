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
            this.endProgram = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelectionButton
            // 
            this.fileSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectionButton.Location = new System.Drawing.Point(662, 347);
            this.fileSelectionButton.Name = "fileSelectionButton";
            this.fileSelectionButton.Size = new System.Drawing.Size(110, 23);
            this.fileSelectionButton.TabIndex = 0;
            this.fileSelectionButton.Text = "Select File to Load";
            this.fileSelectionButton.UseVisualStyleBackColor = true;
            this.fileSelectionButton.Click += new System.EventHandler(this.openFileButton_Clicked);
            // 
            // filePathBox
            // 
            this.filePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathBox.Location = new System.Drawing.Point(29, 350);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(603, 20);
            this.filePathBox.TabIndex = 1;
            // 
            // dataArr
            // 
            this.dataArr.AllowUserToAddRows = false;
            this.dataArr.AllowUserToDeleteRows = false;
            this.dataArr.AllowUserToOrderColumns = true;
            this.dataArr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataArr.Size = new System.Drawing.Size(743, 319);
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
            this.cloneArr.Size = new System.Drawing.Size(17, 15);
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
            this.recordChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recordChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recordChoice.Enabled = false;
            this.recordChoice.FormattingEnabled = true;
            this.recordChoice.Location = new System.Drawing.Point(179, 398);
            this.recordChoice.Name = "recordChoice";
            this.recordChoice.Size = new System.Drawing.Size(122, 21);
            this.recordChoice.TabIndex = 4;
            this.recordChoice.SelectedIndexChanged += new System.EventHandler(this.recordChoice_SelectedIndexChanged);
            // 
            // endProgram
            // 
            this.endProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endProgram.Location = new System.Drawing.Point(681, 399);
            this.endProgram.Name = "endProgram";
            this.endProgram.Size = new System.Drawing.Size(76, 23);
            this.endProgram.TabIndex = 6;
            this.endProgram.Text = "Exit";
            this.endProgram.UseVisualStyleBackColor = true;
            this.endProgram.Click += new System.EventHandler(this.exitButton_Clicked);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(600, 399);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Clicked);
            // 
            // searchInputs
            // 
            this.searchInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInputs.Enabled = false;
            this.searchInputs.Location = new System.Drawing.Point(408, 399);
            this.searchInputs.Name = "searchInputs";
            this.searchInputs.Size = new System.Drawing.Size(187, 20);
            this.searchInputs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of records to display: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search terms:";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataSource = typeof(Record_Objects.Manager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInputs);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endProgram);
            this.Controls.Add(this.recordChoice);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.fileSelectionButton);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.cloneArr);
            this.MinimumSize = new System.Drawing.Size(817, 487);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button endProgram;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

