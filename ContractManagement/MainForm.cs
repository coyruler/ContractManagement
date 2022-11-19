using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 維護合約ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ContractsForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 維護廠商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ClientsForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 合約範本ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frm = new ContractSamplesForm();
            frm.MdiParent = this;
            frm.Show();
        }
        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要登出嗎?",
                "登出",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

       
    }
}
