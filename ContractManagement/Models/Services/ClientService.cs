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
        public ClientVM Get(int CLId)
        {
            string sql = "SELECT * FROM Clients WHERE CLId=@CLId";
            var parameters = new SqlParameterBuilder()
                .AddInt("CLId", CLId)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                throw new Exception("找不到要編輯的記錄");
            }

            return ToClientVM(data.Rows[0]);
        }
		public IEnumerable<ClientIndexIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Clients ORDER BY CLId ";

			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}
		private ClientIndexIndexVM ParseToIndexVM(DataRow row)
		{
			return new ClientIndexIndexVM
			{
				CLId = row.Field<int>("CLId"),
				NameOfCompany = row.Field<string>("NameOfCompany"),
				LocationOfCompany = row.Field<string>("LocationOfCompany"),
				NameOfRepresentative = row.Field<string>("NameOfRepresentative"),
				GUInumber = row.Field<string>("GUInumber")
			};
		}
		private ClientVM ToClientVM(DataRow row)
        {
            return new ClientVM
            {
				CLId = row.Field<int>("CLId"),
                NameOfCompany = row.Field<string>("NameOfCompany"),
                GUInumber = row.Field<string>("GUInumber"),
                LocationOfCompany = row.Field<string>("LocationOfCompany"),
                NameOfRepresentative = row.Field<string>("NameOfRepresentative"),
            };
        }
		internal void Update(ClientVM model)
		{
            bool isExists = GUInumberExists(model);
            if (isExists) throw new Exception("統一編號已存在");

            string sql = @"UPDATE Clients
			SET NameOfCompany=@NameOfCompany, GUInumber=@GUInumber, LocationOfCompany=@LocationOfCompany, NameOfRepresentative=@NameOfRepresentative
			WHERE CLId=@CLId";

			var parameters = new SqlParameterBuilder()
				.AddInt("CLId", model.CLId)
				.AddNVarchar("NameOfCompany", 50, model.NameOfCompany)
				.AddNVarchar("GUInumber", 10, model.GUInumber)
				.AddNVarchar("LocationOfCompany", 50, model.LocationOfCompany)
				.AddNVarchar("NameOfRepresentative", 50, model.NameOfRepresentative)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		internal void Delete(int CLId)
		{
			string sql = @"DELETE FROM Clients WHERE CLId=@CLId";

			var parameters = new SqlParameterBuilder()
				.AddInt("CLId", CLId)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

        public void Create(ClientVM model)
        {
            bool isExists = GUInumberExists(model.GUInumber);
            if (isExists) throw new Exception("帳號已存在");

            string sql = @"INSERT INTO Clients
(NameOfCompany,LocationOfCompany, NameOfRepresentative, GUInumber)
VALUES
(@NameOfCompany,@LocationOfCompany, @NameOfRepresentative, @GUInumber)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("NameOfCompany", 50, model.NameOfCompany)
                .AddNVarchar("LocationOfCompany", 50, model.LocationOfCompany)
                .AddNVarchar("NameOfRepresentative", 50, model.NameOfRepresentative)
                .AddNVarchar("GUInumber", 10, model.GUInumber)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        private bool GUInumberExists(string account)
        {
            string sql = @"SELECT Count(*) as count FROM Clients WHERE GUInumber=@GUInumber";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("GUInumber", 50, account)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }

        private bool GUInumberExists(ClientVM model)
        {
            string sql = @"SELECT Count(*) as count FROM Clients WHERE GUInumber=@GUInumber AND CLId!=@CLId";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("GUInumber", 50, model.GUInumber)
                .AddInt("CLId", model.CLId)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }
       
    }
}
