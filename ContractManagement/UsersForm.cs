using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
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
	public partial class UsersForm : Form
	{
		private UserIndexVM[] users = null;
		public UsersForm()
		{
			InitializeComponent();
			DisplayUsers();
		}

		private void DisplayUsers()
		{
			users = new UserService().GetAll().ToArray();
			BindData(users);
		}
		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			UserIndexVM row = this.users[rowIndx];

			int id = row.Id;
			var frm = new EditUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
