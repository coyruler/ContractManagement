namespace ContractManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.維護合約ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.維護廠商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.維護使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.維護合約ToolStripMenuItem,
            this.維護廠商ToolStripMenuItem,
            this.維護使用者ToolStripMenuItem,
            this.登出ToolStripMenuItem,
            this.登出ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // 維護合約ToolStripMenuItem
            // 
            this.維護合約ToolStripMenuItem.Name = "維護合約ToolStripMenuItem";
            this.維護合約ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.維護合約ToolStripMenuItem.Text = "維護合約";
            this.維護合約ToolStripMenuItem.Click += new System.EventHandler(this.維護合約ToolStripMenuItem_Click);
            // 
            // 維護廠商ToolStripMenuItem
            // 
            this.維護廠商ToolStripMenuItem.Name = "維護廠商ToolStripMenuItem";
            this.維護廠商ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.維護廠商ToolStripMenuItem.Text = "維護廠商";
            this.維護廠商ToolStripMenuItem.Click += new System.EventHandler(this.維護廠商ToolStripMenuItem_Click);
            // 
            // 維護使用者ToolStripMenuItem
            // 
            this.維護使用者ToolStripMenuItem.Name = "維護使用者ToolStripMenuItem";
            this.維護使用者ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.維護使用者ToolStripMenuItem.Text = "維護使用者";
            this.維護使用者ToolStripMenuItem.Click += new System.EventHandler(this.維護使用者ToolStripMenuItem_Click);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.登出ToolStripMenuItem.Text = "合約範本";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.合約範本ToolStripMenuItem_Click_1);
            // 
            // 登出ToolStripMenuItem1
            // 
            this.登出ToolStripMenuItem1.Name = "登出ToolStripMenuItem1";
            this.登出ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.登出ToolStripMenuItem1.Text = "登出";
            this.登出ToolStripMenuItem1.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 547);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "合約管理系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 維護合約ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 維護廠商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 維護使用者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem1;
    }
}