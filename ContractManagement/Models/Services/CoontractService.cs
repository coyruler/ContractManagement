using ContractManagement.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Models.Services
{
    internal class ContractService
    {
        public IEnumerable<ContractIndexVM> GetAll()
        {
            string sql = @"SELECT * FROM Contracts ";

            var dbHelper = new SqlDbHelper("default");
            return dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row));
        }

        public void Create(ContractVM model)
        {

            string sql = @"INSERT INTO Contracts
(ContractTitle,Amount, ContractNote, SignDate, StartDate, EndDate, ClientId, FileName, FileURL)
VALUES
(@ContractTitle,@Amount, @ContractNote, @SignDate, @StartDate, @EndDate, @ClientId, @FileName, @FileURL)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("ContractTitle", 50, model.ContractTitle)
                .AddNVarchar("ContractNote", 300, model.ContractNote)
                .AddNVarchar("FileName", 200, model.FileName)
                .AddNVarchar("FileURL", 200, model.FileURL)
                .AddInt("Amount", model.Amount)
                .AddDateTime("SignDate",model.SignDate)
                .AddDateTime("StartDate", model.StartDate)
                .AddDateTime("EndDate", model.EndDate)
                .AddInt("ClientId", model.ClientId)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        private ContractIndexVM ParseToIndexVM(DataRow row)
        {
            return new ContractIndexVM
            {
                Id = row.Field<int>("Id"),
                ContractTitle = row.Field<string>("ContractTitle"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
                StartDate = row.Field<DateTime>("StartDate"),
                EndDate = row.Field<DateTime>("EndDate"),
                Amount = row.Field<int>("Amount"),               
            };
        }

        public ContractVM Get(int id)
        {
            string sql = "SELECT * FROM Contracts WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                throw new Exception("找不到要編輯的記錄");
            }

            return ToContractVM(data.Rows[0]);
        }

        private ContractVM ToContractVM(DataRow row)
        {
            return new ContractVM
            {
                Id = row.Field<int>("Id"),
                ContractTitle = row.Field<string>("ContractTitle"),
                FileName = row.Field<string>("FileName"),
                FileURL = row.Field<string>("FileURL"),
                StartDate = row.Field<DateTime>("StartDate"),
                EndDate = row.Field<DateTime>("EndDate"),
                SignDate = row.Field<DateTime>("SignDate"),
                Amount = row.Field<int>("Amount"),
                ContractNote = row.Field<string>("ContractNote"),
                ClientId = row.Field<int>("ClientId"),
            };
        }

        internal void Update(ContractVM model)
        {


            string sql = @"UPDATE Contracts
			SET ContractTitle=@ContractTitle, FileName=@FileName, StartDate=@StartDate, EndDate=@EndDate
, SignDate=@SignDate, Amount=@Amount, ContractNote=@ContractNote, ClientId=@ClientId, FileURL=@FileURL  
			WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
				.AddInt("Id", model.Id)
				.AddNVarchar("ContractTitle", 50, model.ContractTitle)
                .AddNVarchar("ContractNote", 300, model.ContractNote)
                .AddNVarchar("FileName", 200, model.FileName)
                .AddNVarchar("FileURL", 200, model.FileURL)
                .AddInt("Amount", model.Amount)
                .AddDateTime("SignDate", model.SignDate)
                .AddDateTime("StartDate", model.StartDate)
                .AddDateTime("EndDate", model.EndDate)
                .AddInt("ClientId", model.ClientId)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        internal void Delete(int id)
        {
            string sql = @"DELETE FROM Users WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

    }
}
