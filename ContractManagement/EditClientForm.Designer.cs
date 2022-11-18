namespace ContractManagement
{
	partial class EditClientForm
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
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
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
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(110, 198);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(97, 36);
			this.updateButton.TabIndex = 27;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(233, 198);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(97, 36);
			this.deleteButton.TabIndex = 28;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// GUInumberTextBox
			// 
			this.GUInumberTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.GUInumberTextBox.Location = new System.Drawing.Point(110, 100);
			this.GUInumberTextBox.Name = "GUInumberTextBox";
			this.GUInumberTextBox.Size = new System.Drawing.Size(220, 29);
			this.GUInumberTextBox.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(27, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "公司名稱:";
			// 
			// locationOfCompanyTextBox
			// 
			this.locationOfCompanyTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.locationOfCompanyTextBox.Location = new System.Drawing.Point(110, 135);
			this.locationOfCompanyTextBox.Name = "locationOfCompanyTextBox";
			this.locationOfCompanyTextBox.Size = new System.Drawing.Size(220, 29);
			this.locationOfCompanyTextBox.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(43, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "負責人:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(27, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "統一編號:";
			// 
			// nameOfRepresentativeTextBox
			// 
			this.nameOfRepresentativeTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameOfRepresentativeTextBox.Location = new System.Drawing.Point(110, 65);
			this.nameOfRepresentativeTextBox.Name = "nameOfRepresentativeTextBox";
			this.nameOfRepresentativeTextBox.Size = new System.Drawing.Size(220, 29);
			this.nameOfRepresentativeTextBox.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(59, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 20;
			this.label4.Text = "地址:";
			// 
			// nameOfCompanyTextBox
			// 
			this.nameOfCompanyTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameOfCompanyTextBox.Location = new System.Drawing.Point(110, 30);
			this.nameOfCompanyTextBox.Name = "nameOfCompanyTextBox";
			this.nameOfCompanyTextBox.Size = new System.Drawing.Size(220, 29);
			this.nameOfCompanyTextBox.TabIndex = 21;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.GUInumberTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.locationOfCompanyTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nameOfRepresentativeTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nameOfCompanyTextBox);
			this.Name = "EditClientForm";
			this.Text = "EditClientForm";
			this.Load += new System.EventHandler(this.EditClientForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
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