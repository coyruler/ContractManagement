namespace ContractManagement
{
	partial class CreateClientForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.GUInumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locationOfCompanyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameOfRepresentativeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameOfCompanyTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveButton.Location = new System.Drawing.Point(295, 183);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "儲存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // GUInumberTextBox
            // 
            this.GUInumberTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GUInumberTextBox.Location = new System.Drawing.Point(105, 103);
            this.GUInumberTextBox.Name = "GUInumberTextBox";
            this.GUInumberTextBox.Size = new System.Drawing.Size(287, 29);
            this.GUInumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "公司名稱:";
            // 
            // locationOfCompanyTextBox
            // 
            this.locationOfCompanyTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.locationOfCompanyTextBox.Location = new System.Drawing.Point(105, 138);
            this.locationOfCompanyTextBox.Name = "locationOfCompanyTextBox";
            this.locationOfCompanyTextBox.Size = new System.Drawing.Size(287, 29);
            this.locationOfCompanyTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "負責人:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "統一編號:";
            // 
            // nameOfRepresentativeTextBox
            // 
            this.nameOfRepresentativeTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameOfRepresentativeTextBox.Location = new System.Drawing.Point(105, 68);
            this.nameOfRepresentativeTextBox.Name = "nameOfRepresentativeTextBox";
            this.nameOfRepresentativeTextBox.Size = new System.Drawing.Size(287, 29);
            this.nameOfRepresentativeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(54, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "地址:";
            // 
            // nameOfCompanyTextBox
            // 
            this.nameOfCompanyTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameOfCompanyTextBox.Location = new System.Drawing.Point(105, 33);
            this.nameOfCompanyTextBox.Name = "nameOfCompanyTextBox";
            this.nameOfCompanyTextBox.Size = new System.Drawing.Size(287, 29);
            this.nameOfCompanyTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 292);
            this.Controls.Add(this.GUInumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationOfCompanyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameOfRepresentativeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameOfCompanyTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "CreateClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增廠商";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox GUInumberTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox locationOfCompanyTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameOfRepresentativeTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nameOfCompanyTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}