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
    public partial class EditContractSampleForm : Form
    {
        private int id;
        public EditContractSampleForm(int id)
        {
            InitializeComponent();
            this.Load += EditContractSampleForm_Load;
            this.id = id;
        }
        private void EditContractSampleForm_Load(object sender, EventArgs e)
        {
            BindData(id);
        }
        private void BindData(int id)
        {
            ContractSampleVM model = new ContractSampleService().Get(id);
            fileTextBox.Text = model.FileName;

        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.fileTextBox.Text = file.SafeFileName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string fileName = fileTextBox.Text;
            ContractSampleVM model = new ContractSampleVM
            {
                Id = id,
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
                new ContractSampleService().Update(model);

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

            new ContractSampleService().Delete(this.id);

            this.DialogResult = DialogResult.OK;
        }


    }
}
