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
	public partial class ClientsForm : Form
	{
		private ClientIndexIndexVM[] clients = null;
		public ClientsForm()
		{
			InitializeComponent();
			DisplayClients();
		}
		private void DisplayClients()
		{
			clients = new ClientService().GetAll().ToArray();
			BindData(clients);
		}
		private void BindData(ClientIndexIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateClientForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayClients();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			ClientIndexIndexVM row = this.clients[rowIndx];

			int clid = row.CLId;
			var frm = new EditClientForm(clid);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayClients();
			}
		}
	}
}
