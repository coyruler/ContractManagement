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
    public partial class CreateContractSampleForm : Form
    {
        public CreateContractSampleForm()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.fileTextBox.Text = file.SafeFileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fileName = fileTextBox.Text;

            ContractSampleVM model = new ContractSampleVM
            {
                FileName = fileName
            };
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Filename",fileTextBox }
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;

            try
            {
                new ContractSampleService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
            }
        }
    }
}
