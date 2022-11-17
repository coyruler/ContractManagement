namespace ContractManagement
{
	partial class EditContractsForm
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
            this.contractIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contractNoteTextBox
            // 
            this.contractNoteTextBox.Location = new System.Drawing.Point(12, 193);
            this.contractNoteTextBox.Multiline = true;
            this.contractNoteTextBox.Name = "contractNoteTextBox";
            this.contractNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contractNoteTextBox.Size = new System.Drawing.Size(543, 225);
            this.contractNoteTextBox.TabIndex = 28;
            // 
            // nameOfCompanyComboBox
            // 
            this.nameOfCompanyComboBox.DataSource = this.contractIndexVMBindingSource;
            this.nameOfCompanyComboBox.DisplayMember = "NameOfCompany";
            this.nameOfCompanyComboBox.FormattingEnabled = true;
            this.nameOfCompanyComboBox.Location = new System.Drawing.Point(92, 74);
            this.nameOfCompanyComboBox.Name = "nameOfCompanyComboBox";
            this.nameOfCompanyComboBox.Size = new System.Drawing.Size(121, 20);
            this.nameOfCompanyComboBox.TabIndex = 27;
            this.nameOfCompanyComboBox.ValueMember = "Id";
            // 
            // signDateDateTimePicker
            // 
            this.signDateDateTimePicker.Location = new System.Drawing.Point(92, 145);
            this.signDateDateTimePicker.Name = "signDateDateTimePicker";
            this.signDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.signDateDateTimePicker.TabIndex = 25;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Location = new System.Drawing.Point(92, 125);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateDateTimePicker.TabIndex = 24;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Location = new System.Drawing.Point(92, 102);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateDateTimePicker.TabIndex = 23;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(92, 43);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(279, 22);
            this.amountTextBox.TabIndex = 22;
            // 
            // contractTitleTextBox
            // 
            this.contractTitleTextBox.Location = new System.Drawing.Point(92, 14);
            this.contractTitleTextBox.Name = "contractTitleTextBox";
            this.contractTitleTextBox.Size = new System.Drawing.Size(279, 22);
            this.contractTitleTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(8, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "合約備註:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "締約對象:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "合約迄日:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(8, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "合約始日:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "合約金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "締約日:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "合約名稱:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(475, 14);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 36);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(475, 131);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 36);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contractIndexVMBindingSource
            // 
            this.contractIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.ContractIndexVM);
            // 
            // EditContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 435);
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
            this.Name = "EditContractsForm";
            this.Text = "EditContractsForm";
            this.Load += new System.EventHandler(this.EditContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIndexVMBindingSource)).EndInit();
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
    }
}