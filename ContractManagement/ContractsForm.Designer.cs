namespace ContractManagement
{
	partial class ContractsForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.searchButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameOfCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			this.clientIdComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(374, 23);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(96, 34);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.contractTitleDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.nameOfCompanyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.contractIndexVMBindingSource1;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(917, 378);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "合約編號";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contractTitleDataGridViewTextBoxColumn
			// 
			this.contractTitleDataGridViewTextBoxColumn.DataPropertyName = "ContractTitle";
			this.contractTitleDataGridViewTextBoxColumn.HeaderText = "合約名稱";
			this.contractTitleDataGridViewTextBoxColumn.Name = "contractTitleDataGridViewTextBoxColumn";
			this.contractTitleDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractTitleDataGridViewTextBoxColumn.Width = 200;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "金額";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			this.amountDataGridViewTextBoxColumn.Width = 130;
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
			this.startDateDataGridViewTextBoxColumn.HeaderText = "合約始日";
			this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.startDateDataGridViewTextBoxColumn.Width = 130;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
			this.endDateDataGridViewTextBoxColumn.HeaderText = "合約訖日";
			this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.endDateDataGridViewTextBoxColumn.Width = 130;
			// 
			// nameOfCompanyDataGridViewTextBoxColumn
			// 
			this.nameOfCompanyDataGridViewTextBoxColumn.DataPropertyName = "NameOfCompany";
			this.nameOfCompanyDataGridViewTextBoxColumn.HeaderText = "締約對象";
			this.nameOfCompanyDataGridViewTextBoxColumn.Name = "nameOfCompanyDataGridViewTextBoxColumn";
			this.nameOfCompanyDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameOfCompanyDataGridViewTextBoxColumn.Width = 300;
			// 
			// contractIndexVMBindingSource1
			// 
			this.contractIndexVMBindingSource1.DataSource = typeof(ContractManagement.Models.ViewModels.ContractIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addNewButton.Location = new System.Drawing.Point(835, 21);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(96, 34);
			this.addNewButton.TabIndex = 2;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// clientIdComboBox
			// 
			this.clientIdComboBox.DataSource = this.contractIndexVMBindingSource1;
			this.clientIdComboBox.DisplayMember = "NameOfCompany";
			this.clientIdComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.clientIdComboBox.FormattingEnabled = true;
			this.clientIdComboBox.Location = new System.Drawing.Point(12, 27);
			this.clientIdComboBox.Name = "clientIdComboBox";
			this.clientIdComboBox.Size = new System.Drawing.Size(356, 28);
			this.clientIdComboBox.TabIndex = 0;
			this.clientIdComboBox.ValueMember = "Id";
			// 
			// ContractsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 482);
			this.Controls.Add(this.clientIdComboBox);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.searchButton);
			this.Name = "ContractsForm";
			this.Text = "檢視合約";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUInumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractIndexVMBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfCompanyDataGridViewTextBoxColumn;
	}
}