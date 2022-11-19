using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ContractManagement.Models.ViewModels
{
    public class ClientIndexVM
    {
        public int CLId { get; set; }
        public string NameOfCompany { get; set; }
        public string GUInumber { get; set; }
		public string LocationOfCompany { get; set; }
		public string NameOfRepresentative { get; set; }
	}
    public class ClientVM
    {
        public int CLId { get; set; }
        [Required(ErrorMessage = "公司名稱必填")]
        public string NameOfCompany { get; set; }
        [Required(ErrorMessage = "統一編號必填")]
        [StringLength(10, ErrorMessage = "統一編號長度只能十個字")]
        public string GUInumber { get; set; }
        [Required(ErrorMessage = "公司地址必填")]
        public string LocationOfCompany { get; set; }
        [Required(ErrorMessage = "負責人必填")]
        public string NameOfRepresentative { get; set; }
    }
}
