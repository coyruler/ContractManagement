using ContractManagement.Infra;
using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
using ISpan.Utility;
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
	public partial class EditContractForm : Form
	{
        private int id;
        public EditContractForm(int id)
		{
            InitializeComponent();
			InitForm();
			this.Load += EditContractsForm_Load;
            this.id = id;
        }
		public void InitForm()
		{
			nameOfCompanyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = "SELECT * FROM Clients ";
			var dbHelper = new SqlDbHelper("default");
			List<ClientIndexVM> nameOfCompany = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToIndexVM(row))
				.ToList();
			this.nameOfCompanyComboBox.DataSource = nameOfCompany;
		}
		private ClientIndexVM ToIndexVM(DataRow row)
		{
			return new ClientIndexVM
			{
				CLId = row.Field<int>("CLId"),
				NameOfCompany = row.Field<string>("NameOfCompany"),
			};
		}

		private void EditContractsForm_Load(object sender, EventArgs e)
		{
            BindData(id);
        }
        private void BindData(int id)
        {
            ContractVM model = new ContractService().Get(id);

            contractTitleTextBox.Text = model.ContractTitle;
            amountTextBox.Text = model.Amount.ToString();
            contractNoteTextBox.Text = model.ContractNote;
            startDateDateTimePicker.Value = model.StartDate;
            endDateDateTimePicker.Value = model.EndDate;
            signDateDateTimePicker.Value = model.SignDate;
			fileTextBox.Text = model.FileName;
			nameOfCompanyComboBox.SelectedValue  = model.ClientId;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string contractTitle = contractTitleTextBox.Text;
            string amount = amountTextBox.Text;
            string contractNote = contractNoteTextBox.Text;
            string signDate = signDateDateTimePicker.Text;
            string startDate = startDateDateTimePicker.Text;
            string endDate = endDateDateTimePicker.Text;
            string file = fileTextBox.Text;
			object clientId = nameOfCompanyComboBox.SelectedValue;

            if (Convert.ToDateTime(endDate)< Convert.ToDateTime(startDate))
			{
                MessageBox.Show("合約始日必須早於合約迄日");
                return;
            };
			ContractVM model = new ContractVM
            {
                Id = this.id,
                ContractTitle = contractTitle,
                Amount = int.Parse(amount),
                ContractNote = contractNote,
                SignDate = Convert.ToDateTime(signDate),
                StartDate = Convert.ToDateTime(startDate),
                EndDate = Convert.ToDateTime(endDate),
				ClientId = int.Parse(clientId.ToString()),
				FileName = file
            };

            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
				{"ContractTitle", contractTitleTextBox},
                {"Amount", amountTextBox},
                {"ContractNote", contractNoteTextBox},
                {"SignDate", startDateDateTimePicker},
                {"StartDate",startDateDateTimePicker},
                {"EndDate",endDateDateTimePicker},
                {"Filename",fileTextBox },
				{"ClientId",nameOfCompanyComboBox }
			};

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;

            try
            {
                new ContractService().Update(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
			this.DialogResult = DialogResult.OK;
		}

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要刪除嗎?", "刪除記錄",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            new UserService().Delete(this.id);

            this.DialogResult = DialogResult.OK;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			this.fileTextBox.Text = file.SafeFileName;
		}
    }
}
