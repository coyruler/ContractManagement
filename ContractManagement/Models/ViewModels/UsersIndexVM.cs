using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

	}

	public class UserVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }
		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }
		[Required(ErrorMessage = "姓名必填")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Email必填")]
		[EmailAddress(ErrorMessage = "Email格式有誤")]
		public string Email { get; set; }
		[Required(ErrorMessage = "手機必填")]
		[StringLength(10, ErrorMessage = "手機長度只能十個字")]
		public string Phone { get; set; }
	}
}
