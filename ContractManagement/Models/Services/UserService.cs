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
	public class UserService
	{
		public IEnumerable<UserIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Users ORDER BY ID ";

			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}

		public void Create(UserVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"INSERT INTO Users
(Account,Password, Name, Email, Phone)
VALUES
(@Account,@Password, @Name, @Email, @Phone)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNVarchar("Email", 50, model.Email)
				.AddNVarchar("Phone", 50, model.Phone)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool AccountExists(UserVM model)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account AND Id!=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name"),
				Email = row.Field<string>("Email"),
				Phone = row.Field<string>("Phone")
			};
		}

		public UserVM Get(int id)
		{
			string sql = "SELECT * FROM Users WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
			}

			return ToUserVM(data.Rows[0]);
		}

		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
				Email = row.Field<string>("Email"),
				Phone = row.Field<string>("Phone")
			};
		}

		internal void Update(UserVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"UPDATE Users
			SET Account=@Account, Password=@Password, Name=@Name, Email=@Email, Phone=@Phone
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddInt("Id", model.Id)
				.AddNVarchar("Email", 50, model.Email)
				.AddNVarchar("Phone", 50, model.Phone)
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

		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false; 

			return (user.Password == model.Password);
		}

		public UserVM Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}
			return ToUserVM(data.Rows[0]);
		}
	}
}
