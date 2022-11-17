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
    internal class ClientService
    {
        public ClientVM Get(int id)
        {
            string sql = "SELECT * FROM Clients WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                throw new Exception("找不到要編輯的記錄");
            }

            return ToClientVM(data.Rows[0]);
        }
        private ClientVM ToClientVM(DataRow row)
        {
            return new ClientVM
            {
                Id = row.Field<int>("Id"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
                GUInumber = row.Field<string>("GUInumber"),
                LocationOfCompany = row.Field<string>("LocationOfCompany"),
                NameOfRepresentative = row.Field<string>("NameOfRepresentative"),
            };
        }
    }
}
