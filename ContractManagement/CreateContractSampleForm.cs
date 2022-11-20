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
            //file.InitialDirectory = "c:\\";
            file.ShowDialog();
            this.fileNameTextBox.Text = file.SafeFileName;
            this.fileURLTextBox.Text = file.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fileName = fileNameTextBox.Text;
            string fileURl = fileURLTextBox.Text;

            ContractSampleVM model = new ContractSampleVM
            {
                SampleFileName = fileName,
                SampleFileURL = fileURl,
            };
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Filename",fileNameTextBox},
                {"FileURL", fileURLTextBox}
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
