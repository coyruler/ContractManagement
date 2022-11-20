namespace ContractManagement
{
    partial class ContractSamplesForm
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractSampleIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addNewButton = new System.Windows.Forms.Button();
            this.contractSampleIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractSampleIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource2)).BeginInit();
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
            this.SampleFileName});
            this.dataGridView1.DataSource = this.contractSampleIndexVMBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "編號";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SampleFileName
            // 
            this.SampleFileName.DataPropertyName = "SampleFileName";
            this.SampleFileName.HeaderText = "檔案名稱";
            this.SampleFileName.Name = "SampleFileName";
            this.SampleFileName.ReadOnly = true;
            this.SampleFileName.Width = 400;
            // 
            // contractSampleIndexVMBindingSource1
            // 
            this.contractSampleIndexVMBindingSource1.DataSource = typeof(ContractManagement.Models.ViewModels.ContractSampleIndexVM);
            // 
            // addNewButton
            // 
            this.addNewButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addNewButton.Location = new System.Drawing.Point(559, 22);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(96, 34);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "新增";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // contractSampleIndexVMBindingSource
            // 
            this.contractSampleIndexVMBindingSource.DataSource = typeof(ContractManagement.Models.ViewModels.ContractSampleIndexVM);
            // 
            // contractSampleIndexVMBindingSource2
            // 
            this.contractSampleIndexVMBindingSource2.DataSource = typeof(ContractManagement.Models.ViewModels.ContractSampleIndexVM);
            // 
            // ContractSamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 360);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ContractSamplesForm";
            this.Text = "合約範本";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractSampleIndexVMBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractSampleIndexVMBindingSource;
        private System.Windows.Forms.BindingSource contractSampleIndexVMBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleFileName;
        private System.Windows.Forms.BindingSource contractSampleIndexVMBindingSource2;
    }
}