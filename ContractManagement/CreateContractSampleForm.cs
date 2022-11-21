using ContractManagement.Infra;
using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            string fileURL = fileURLTextBox.Text;

			Stream myStream;
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "請選擇上傳路徑";
			sfd.InitialDirectory = @"C:\範本";
			sfd.Filter = "所有文件|*.*";
			sfd.FileName = fileName;			
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					using (FileStream fsRead = new FileStream(fileURL, FileMode.OpenOrCreate, FileAccess.Read))
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
					fileURL = sfd.FileName.ToString();
				}
				catch
				{
					MessageBox.Show("請重新確認檔案名稱及位置");
					return;
				}
			}
			

			ContractSampleVM model = new ContractSampleVM
			{
				SampleFileName = fileName,
				SampleFileURL = fileURL,
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
