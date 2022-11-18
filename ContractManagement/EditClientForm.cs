using ContractManagement.Infra;
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
	public partial class EditClientForm : Form
	{
		private int CLId;
		public EditClientForm(int CLId)
		{
			InitializeComponent();
			this.Load += EditClientForm_Load;
			this.CLId = CLId;
		}
		private void EditClientForm_Load(object sender, EventArgs e)
		{
			BindData(CLId);
		}
		private void BindData(int CLId)
		{
			ClientVM model = new ClientService().Get(CLId);

			nameOfCompanyTextBox.Text = model.NameOfCompany;
			nameOfRepresentativeTextBox.Text = model.NameOfRepresentative;
			GUInumberTextBox.Text = model.GUInumber;
			locationOfCompanyTextBox.Text = model.LocationOfCompany;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string nameOfCompany = nameOfCompanyTextBox.Text;
			string nameOfRepresentative = nameOfRepresentativeTextBox.Text;
			string gUInumber = GUInumberTextBox.Text;
			string locationOfCompany = locationOfCompanyTextBox.Text;


			ClientVM model = new ClientVM
			{
				CLId = this.CLId,
				NameOfCompany = nameOfCompany,
				NameOfRepresentative = nameOfRepresentative,
				GUInumber = gUInumber,
				LocationOfCompany = locationOfCompany,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"NameOfCompany", nameOfCompanyTextBox},
				{"NameOfRepresentative", nameOfRepresentativeTextBox},
				{"GUInumber", GUInumberTextBox},
				{"LocationOfCompany", locationOfCompanyTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new ClientService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除記錄",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new ClientService().Delete(this.CLId);

			this.DialogResult = DialogResult.OK;
		}


	}
}
