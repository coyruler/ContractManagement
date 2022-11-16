using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Models.ViewModels
{
    public class ClientIndexVM
    {
        public int CLId { get; set; }
        public string NameOfCompany { get; set; }
    }
    public class ClientVM
    {
        public int Id { get; set; }
        public string NameOfCompany { get; set; }
        public string GUInumber { get; set; }
        public string LocationOfCompany { get; set; }
        public string NameOfRepresentative { get; set; }
    }
}
