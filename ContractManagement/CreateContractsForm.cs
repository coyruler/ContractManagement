using ContractManagement.Infra;
using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using ISpan.Utility;

namespace ContractManagement
{
	public partial class CreateContractsForm : Form
	{
		public CreateContractsForm()
		{
			InitializeComponent();
            InitForm();

        }

        public void InitForm()
        {
            nameOfCompanyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var sql = "SELECT * FROM Contracts INNER JOIN Clients ON Contracts.ClientId = Clients.CLId Order BY Contracts.Id";
            var dbHelper = new SqlDbHelper("default");
            List<ClientIndexVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToIndexVM(row))
                .Prepend(new ClientIndexVM { CLId = 0, NameOfCompany = String.Empty })
                .ToList();
            this.nameOfCompanyComboBox.DataSource = categories;
        }
        private ClientIndexVM ToIndexVM(DataRow row)
        {
            return new ClientIndexVM
            {
                CLId = row.Field<int>("CLId"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
            };
        }
        private void saveButton_Click(object sender, EventArgs e)
		{
            string contractTitle = contractTitleTextBox.Text;
            string amount = amountTextBox.Text;
            string contractNote = contractNoteTextBox.Text;
            string signDate = signDateDateTimePicker.Text;
            string startDate = startDateDateTimePicker.Text;
            string endDate = endDateDateTimePicker.Text;

            ContractVM model = new ContractVM
            {
                ContractTitle = contractTitle,
                Amount = int.Parse(amount),
                ContractNote = contractNote,
                SignDate = Convert.ToDateTime(signDate),
                StartDate = Convert.ToDateTime(startDate),
                EndDate = Convert.ToDateTime(endDate),
            };
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"ContractTitle", contractTitleTextBox},
                {"Amount", amountTextBox},
                {"ContractNote", contractNoteTextBox},
                {"SignDate", startDateDateTimePicker},
                {"StartDate",startDateDateTimePicker},
                {"EndDate",endDateDateTimePicker},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;


            try
            {
                new ContractService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
            }
        }
	}
}
