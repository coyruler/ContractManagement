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
using System.ComponentModel.DataAnnotations;


namespace ContractManagement
{
	public partial class CreateClientForm : Form
	{
        public CreateClientForm()
		{
			InitializeComponent();
        }

		private void saveButton_Click(object sender, EventArgs e)
		{
            string nameOfCompany = nameOfCompanyTextBox.Text;
            string nameOfRepresentative = nameOfRepresentativeTextBox.Text;
            string gUInumber = GUInumberTextBox.Text;
            string locationOfCompany = locationOfCompanyTextBox.Text;

            ClientVM model = new ClientVM
            {
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
                new ClientService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
            }
        }
	}
}
