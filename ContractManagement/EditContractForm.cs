using ContractManagement.Infra;
using ContractManagement.Models.Services;
using ContractManagement.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
			var sql = "SELECT * FROM Clients";
			var dbHelper = new SqlDbHelper("default");
			List<ClientIndexIndexVM> nameOfCompany = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToIndexVM(row))
				.ToList();
			this.nameOfCompanyComboBox.DataSource = nameOfCompany;
		}
		private ClientIndexIndexVM ToIndexVM(DataRow row)
		{
			return new ClientIndexIndexVM
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
            fileURLTextBox.Text = model.FileURL;
            nameOfCompanyComboBox.SelectedValue = model.ClientId;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string contractTitle = contractTitleTextBox.Text;
            string amount = amountTextBox.Text;
            string contractNote = contractNoteTextBox.Text;
            string signDate = signDateDateTimePicker.Text;
            string startDate = startDateDateTimePicker.Text;
            string endDate = endDateDateTimePicker.Text;
            string fileName = fileTextBox.Text;
            string fileURL = fileURLTextBox.Text;
            object clientId = nameOfCompanyComboBox.SelectedValue;

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

			if (Convert.ToDateTime(endDate) < Convert.ToDateTime(startDate))
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
                FileName = fileName,
                FileURL = fileURL,
            };

            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
				{"ContractTitle", contractTitleTextBox},
                {"Amount", amountTextBox},
                {"ContractNote", contractNoteTextBox},
                {"SignDate", startDateDateTimePicker},
                {"StartDate", startDateDateTimePicker},
                {"EndDate", endDateDateTimePicker},
                {"Filename", fileTextBox},
                {"FileURL", fileURLTextBox},
                {"ClientId", nameOfCompanyComboBox},
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

            new ContractService().Delete(this.id);

            this.DialogResult = DialogResult.OK;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			this.fileTextBox.Text = file.SafeFileName;
            this.fileURLTextBox.Text = file.FileName;
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
