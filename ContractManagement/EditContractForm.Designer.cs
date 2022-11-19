namespace ContractManagement
{
	partial class EditContractForm
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
            this.contractNoteTextBox = new System.Windows.Forms.TextBox();
            this.nameOfCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.clientIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.contractTitleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contractIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contractNoteTextBox
            // 
            this.contractNoteTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contractNoteTextBox.Location = new System.Drawing.Point(29, 283);
            this.contractNoteTextBox.Multiline = true;
            this.contractNoteTextBox.Name = "contractNoteTextBox";
            this.contractNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contractNoteTextBox.Size = new System.Drawing.Size(543, 225);
            this.contractNoteTextBox.TabIndex = 8;
            // 
            // nameOfCompanyComboBox
            // 
            this.nameOfCompanyComboBox.DataSource = this.clientIndexVMBindingSource;
            this.nameOfCompanyComboBox.DisplayMember = "NameOfCompany";
            this.nameOfCompanyComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameOfCompanyComboBox.FormattingEnabled = true;
            this.nameOfCompanyComboBox.Location = new System.Drawing.Point(109, 85);
            this.nameOfCompanyComboBox.Name = "nameOfCompanyComboBox";
            this.nameOfCompanyComboBox.Size = new System.Drawing.Size(279, 28);
            this.nameOfCompanyComboBox.TabIndex = 2;
            this.nameOfCompanyComboBox.ValueMember = "CLId";
            // 
            // clientIndexVMBindingSource
            // 
            this.clientIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.ClientIndexVM);
            // 
            // userIndexVMBindingSource
            // 
            this.userIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.UserIndexVM);
            // 
            // signDateDateTimePicker
            // 
            this.signDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signDateDateTimePicker.Location = new System.Drawing.Point(109, 189);
            this.signDateDateTimePicker.Name = "signDateDateTimePicker";
            this.signDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.signDateDateTimePicker.TabIndex = 5;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(109, 154);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.endDateDateTimePicker.TabIndex = 4;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(109, 119);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.startDateDateTimePicker.TabIndex = 3;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.amountTextBox.Location = new System.Drawing.Point(109, 50);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(279, 29);
            this.amountTextBox.TabIndex = 1;
            // 
            // contractTitleTextBox
            // 
            this.contractTitleTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contractTitleTextBox.Location = new System.Drawing.Point(109, 15);
            this.contractTitleTextBox.Name = "contractTitleTextBox";
            this.contractTitleTextBox.Size = new System.Drawing.Size(279, 29);
            this.contractTitleTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "合約備註:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(26, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "締約對象:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "合約迄日:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "合約始日:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "合約金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "締約日:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "合約名稱:";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateButton.Location = new System.Drawing.Point(475, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 36);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteButton.Location = new System.Drawing.Point(475, 131);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 36);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contractIndexVMBindingSource1
            // 
            this.contractIndexVMBindingSource1.DataSource = typeof(ContractManagement.Models.ViewModels.ContractIndexVM);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectFileButton.Location = new System.Drawing.Point(315, 224);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(89, 30);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "選擇檔案";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fileTextBox.Location = new System.Drawing.Point(29, 224);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(280, 29);
            this.fileTextBox.TabIndex = 6;
            // 
            // EditContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 520);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.contractNoteTextBox);
            this.Controls.Add(this.nameOfCompanyComboBox);
            this.Controls.Add(this.signDateDateTimePicker);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.contractTitleTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合約維護";
            this.Load += new System.EventHandler(this.EditContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox contractNoteTextBox;
		private System.Windows.Forms.ComboBox nameOfCompanyComboBox;
		private System.Windows.Forms.DateTimePicker signDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.Windows.Forms.TextBox contractTitleTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource contractIndexVMBindingSource;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource;
		private System.Windows.Forms.BindingSource clientIndexVMBindingSource;
		private System.Windows.Forms.BindingSource contractIndexVMBindingSource1;
		private System.Windows.Forms.Button selectFileButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox fileTextBox;
	}
}