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
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();
			this.Load += EditUserForm_Load;
			this.id = id;
		}

		private void EditUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			UserVM model = new UserService().Get(id);

			accountTextBox.Text = model.Account;
			passwordTextBox.Text = model.Password;
			nameTextBox.Text = model.Name;
			emailTextBox.Text = model.Email;
			phoneTextBox.Text = model.Phone;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			string email = emailTextBox.Text;
			string phone = phoneTextBox.Text;

			UserVM model = new UserVM
			{
				Id = this.id,
				Account = account,
				Password = password,
				Name = name,
				Email = email,
				Phone = phone,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
				{"Email", emailTextBox},
				{"Phone", phoneTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new UserService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?",	"刪除記錄",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new UserService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
