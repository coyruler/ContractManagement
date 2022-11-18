using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Models.ViewModels
{
    public class ContractIndexVM
    {
        public int Id { get; set; }
        public string ContractTitle { get; set; }
        public int Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NameOfCompany { get; set; }
        public int ClientId { get; set; }
    }
    public class ContractVM
    {
        public int Id { get; set; }
        public string ContractTitle { get; set; }
        public int Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SignDate { get; set; }
        public string FileName { get; set; }

		[Required(ErrorMessage = "締約對象必填")]
		public int ClientId { get; set; }
        public string ContractNote { get; set; }
    }

}
