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
    public partial class ContractSamplesForm : Form
    {
        private ContractSampleIndexVM[] contractSamples = null;
        public ContractSamplesForm()
        {
            InitializeComponent();
            DisplayContractSamples();
        }
        private void DisplayContractSamples()
        {
            string sql = @"SELECT * FROM ContractSamples";

            SqlParameter[] parameters = new SqlParameter[] { };

            var dbHelper = new SqlDbHelper("default");
            contractSamples = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();


            BindData(contractSamples);
        }
        private void BindData(ContractSampleIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }
        private ContractSampleIndexVM ParseToIndexVM(DataRow row)
        {
            return new ContractSampleIndexVM
            {
                Id = row.Field<int>("Id"),
                FileName = row.Field<string>("FileName")
            };
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            var frm = new CreateContractSampleForm();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DisplayContractSamples();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;
            if (rowIndx < 0) return;
            ContractSampleIndexVM row = this.contractSamples[rowIndx];
            int id = row.Id;

            var frm = new EditContractSampleForm(id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayContractSamples();
            }
        }
    }
}
