using ContractManagement.Infra;
using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


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
            fileURLTextBox.Text = model.SampleFileURL;
            fileTextBox.Text = model.SampleFileName;
            

        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.fileTextBox.Text = file.SafeFileName;
            this.fileURLTextBox.Text = file.FileName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string fileName = fileTextBox.Text;
            string fileURl = fileURLTextBox.Text;
			Stream myStream;
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "請選擇上傳路徑";
			sfd.InitialDirectory = @"C:\範本";
			sfd.Filter = "所有文件|*.*";
			sfd.FileName = fileName;
			sfd.ShowDialog();

			try
			{
				using (FileStream fsRead = new FileStream(fileURl, FileMode.OpenOrCreate, FileAccess.Read))
				{
					using (FileStream fsWrite = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
					{
						if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							SaveFileProgressBar.Maximum = (int)fsRead.Length;
							byte[] buffer = new byte[1024 * 1024 * 3];
							while (true)
							{
								int r = fsRead.Read(buffer, 0, buffer.Length);
								if (r == 0)
								{
									break;
								}
								fsWrite.Write(buffer, 0, r);
								SaveFileProgressBar.Value = (int)fsWrite.Length;
							}
							fileURl = sfd.FileName.ToString();
							MessageBox.Show("上傳成功！");
						}
						else
						{
							MessageBox.Show("取消上傳");
							return;
						}						
					}
				}
			}
			catch
			{
				MessageBox.Show("請重新確認檔案名稱及位置");
				return;
			}
			ContractSampleVM model = new ContractSampleVM
            {
                Id = id,
                SampleFileName = fileName,
                SampleFileURL = fileURl,
            };
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Filename", fileTextBox},
                {"FileURL", fileURLTextBox}
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

        private void DownloadButton_Click(object sender, EventArgs e)
        {
			string fileName = fileTextBox.Text;
			string fileURl = fileURLTextBox.Text;
			Stream myStream;
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "請選擇路徑";
			sfd.InitialDirectory = @"C:\Users\ispan\Desktop";
			sfd.Filter = "所有文件|*.*";
            sfd.FileName = fileName;
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					using (FileStream fsRead = new FileStream(fileURl, FileMode.OpenOrCreate, FileAccess.Read))
					{
						using (FileStream fsWrite = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
						{
							SaveFileProgressBar.Maximum = (int)fsRead.Length;
							byte[] buffer = new byte[1024 * 1024 * 3];
							while (true)
							{
								int r = fsRead.Read(buffer, 0, buffer.Length);
								if (r == 0)
								{
									break;
								}
								fsWrite.Write(buffer, 0, r);
								SaveFileProgressBar.Value = (int)fsWrite.Length;
							}
							MessageBox.Show("保存成功！");
						}
					}
				}
				catch
				{
					MessageBox.Show("請重新確認檔案名稱及位置");
					return;
				}
			}
			else
			{
				MessageBox.Show("請重新確認檔案名稱及位置");
			}
						
		}
    }
}
