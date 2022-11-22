using ContractManagement.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagement
{
	public partial class ContractsForm : Form
	{
        private ContractIndexVM[] products = null;
        public ContractsForm()
		{
			InitializeComponent();
            InitForm();
            DisplayContracts();
        }
        public void InitForm()
        {
            clientIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var sql = "SELECT * FROM Clients ";
            var dbHelper = new SqlDbHelper("default");
            List<ClientIndexIndexVM> nameOfCompany = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToIndexVM(row))
                .Prepend(new ClientIndexIndexVM { CLId = 0,NameOfCompany= String.Empty })
                .ToList();
            this.clientIdComboBox.DataSource = nameOfCompany;
        }
        private ClientIndexIndexVM ToIndexVM(DataRow row)
        {
            return new ClientIndexIndexVM
            {
                CLId = row.Field<int>("CLId"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
            };
        }
        private void DisplayContracts()
        {
            string sql = @"SELECT ct.Id, ct.ContractTitle, ct.Amount, c.NameOfCompany, c.GUInumber, ct.StartDate, ct.EndDate
FROM Contracts ct
INNER JOIN Clients c 
ON ct.ClientId = c.CLId";

            SqlParameter[] parameters = new SqlParameter[] { };
            int ClientId = ((ClientIndexIndexVM)clientIdComboBox.SelectedItem).CLId;
            if (ClientId > 0)
            {
                sql += " WHERE ClientId =@ClientId";
                parameters = new SqlParameterBuilder()
                    .AddInt("ClientId", ClientId)
                    .Build();
            }
            var dbHelper = new SqlDbHelper("default");
            products = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();


            BindData(products);
        }
        private void BindData(ContractIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }
        private ContractIndexVM ParseToIndexVM(DataRow row)
        {
            return new ContractIndexVM
            {
                Id = row.Field<int>("Id"),
                ContractTitle = row.Field<string>("ContractTitle"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
                Amount = row.Field<int>("Amount"),
                StartDate = row.Field<DateTime>("StartDate"),
                EndDate = row.Field<DateTime>("EndDate"),
            };
        }
        private void searchButton_Click(object sender, EventArgs e)
		{
            DisplayContracts();
        }
        private void addNewButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateContractForm();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DisplayContracts();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;
            if (rowIndx < 0) return;
            ContractIndexVM row = this.products[rowIndx];
            int id = row.Id;

            var frm = new EditContractForm(id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayContracts();
            }
        }
    }
}
