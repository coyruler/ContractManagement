namespace ContractManagement
{
	partial class ClientsForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cLIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameOfCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameOfRepresentative = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gUInumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LocationOfCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIdDataGridViewTextBoxColumn,
            this.nameOfCompanyDataGridViewTextBoxColumn,
            this.NameOfRepresentative,
            this.gUInumberDataGridViewTextBoxColumn,
            this.LocationOfCompany});
			this.dataGridView1.DataSource = this.clientIndexVMBindingSource;
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
			this.dataGridView1.Size = new System.Drawing.Size(772, 364);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// cLIdDataGridViewTextBoxColumn
			// 
			this.cLIdDataGridViewTextBoxColumn.DataPropertyName = "CLId";
			this.cLIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.cLIdDataGridViewTextBoxColumn.Name = "cLIdDataGridViewTextBoxColumn";
			this.cLIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.cLIdDataGridViewTextBoxColumn.Width = 70;
			// 
			// nameOfCompanyDataGridViewTextBoxColumn
			// 
			this.nameOfCompanyDataGridViewTextBoxColumn.DataPropertyName = "NameOfCompany";
			this.nameOfCompanyDataGridViewTextBoxColumn.HeaderText = "公司名稱";
			this.nameOfCompanyDataGridViewTextBoxColumn.Name = "nameOfCompanyDataGridViewTextBoxColumn";
			this.nameOfCompanyDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameOfCompanyDataGridViewTextBoxColumn.Width = 150;
			// 
			// NameOfRepresentative
			// 
			this.NameOfRepresentative.DataPropertyName = "NameOfRepresentative";
			this.NameOfRepresentative.HeaderText = "負責人";
			this.NameOfRepresentative.Name = "NameOfRepresentative";
			this.NameOfRepresentative.ReadOnly = true;
			this.NameOfRepresentative.Width = 120;
			// 
			// gUInumberDataGridViewTextBoxColumn
			// 
			this.gUInumberDataGridViewTextBoxColumn.DataPropertyName = "GUInumber";
			this.gUInumberDataGridViewTextBoxColumn.HeaderText = "統一編號";
			this.gUInumberDataGridViewTextBoxColumn.Name = "gUInumberDataGridViewTextBoxColumn";
			this.gUInumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.gUInumberDataGridViewTextBoxColumn.Width = 130;
			// 
			// LocationOfCompany
			// 
			this.LocationOfCompany.DataPropertyName = "LocationOfCompany";
			this.LocationOfCompany.HeaderText = "地址";
			this.LocationOfCompany.Name = "LocationOfCompany";
			this.LocationOfCompany.ReadOnly = true;
			this.LocationOfCompany.Width = 250;
			// 
			// clientIndexVMBindingSource
			// 
			this.clientIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.ClientIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(688, 45);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(96, 34);
			this.addNewButton.TabIndex = 3;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// ClientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 495);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addNewButton);
			this.Name = "ClientsForm";
			this.Text = "ClientForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource clientIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn cLIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOfCompanyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameOfRepresentative;
		private System.Windows.Forms.DataGridViewTextBoxColumn gUInumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LocationOfCompany;
	}
}