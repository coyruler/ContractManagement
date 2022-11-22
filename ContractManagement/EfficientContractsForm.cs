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
    public partial class EfficientContractsForm : Form
    {
        private ContractIndexVM[] products = null;
        public EfficientContractsForm()
        {
            InitializeComponent();
            DisplayContracts();
        }
        
        private void DisplayContracts()
        {
            string sql = @"SELECT ct.Id, ct.ContractTitle, ct.Amount, c.NameOfCompany, c.GUInumber, ct.StartDate, ct.EndDate
FROM Contracts ct
INNER JOIN Clients c 
ON ct.ClientId = c.CLId
where StartDate <= GETDATE()  and GETDATE() <= EndDate
order by EndDate";

            SqlParameter[] parameters = new SqlParameter[] { };
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
