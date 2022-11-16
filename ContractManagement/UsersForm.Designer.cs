namespace ContractManagement
{
	partial class UsersForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.addNewButton = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.userIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userIndexVMBindingSource2;
			this.dataGridView1.Location = new System.Drawing.Point(12, 62);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(638, 385);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(554, 22);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(96, 34);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 80;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// accountDataGridViewTextBoxColumn
			// 
			this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
			this.accountDataGridViewTextBoxColumn.HeaderText = "帳號";
			this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
			this.accountDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountDataGridViewTextBoxColumn.Width = 130;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "信箱";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			this.emailDataGridViewTextBoxColumn.Width = 180;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "手機";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userIndexVMBindingSource2
			// 
			this.userIndexVMBindingSource2.DataSource = typeof(ContractManagement.Models.ViewModels.UserIndexVM);
			// 
			// userIndexVMBindingSource1
			// 
			this.userIndexVMBindingSource1.DataSource = typeof(ContractManagement.Models.ViewModels.UserIndexVM);
			// 
			// userIndexVMBindingSource
			// 
			this.userIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.UserIndexVM);
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 454);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UsersForm";
			this.Text = "使用者資料";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
	}
}