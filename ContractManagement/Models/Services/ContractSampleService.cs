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
    internal class ContractSampleService
    {
        public void Create(ContractSampleVM model)
        {

            string sql = @"INSERT INTO ContractSamples (FileName) VALUES (@FileName)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("FileName", 200, model.FileName)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }
        public ContractSampleVM Get(int id)
        {
            string sql = "SELECT * FROM ContractSamples WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                throw new Exception("找不到要編輯的記錄");
            }

            return ToContractSampleVM(data.Rows[0]);
        }

        private ContractSampleVM ToContractSampleVM(DataRow row)
        {
            return new ContractSampleVM
            {
                Id = row.Field<int>("Id"),
                FileName = row.Field<string>("FileName")
            };
        }
        internal void Update(ContractSampleVM model)
        {


            string sql = @"UPDATE ContractSamples SET FileName=@FileName WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", model.Id)
                .AddNVarchar("FileName", 200, model.FileName)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        internal void Delete(int id)
        {
            string sql = @"DELETE FROM ContractSamples WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

    }
}
