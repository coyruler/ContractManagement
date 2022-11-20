using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Models.ViewModels
{
    internal class ContractSampleIndexVM
    {
        public int Id { get; set; }
        public string SampleFileName { get; set; }
        public string SampleFileURL { get; set; }
    }
    internal class ContractSampleVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "檔案名稱必填")]
        public string SampleFileName { get; set; }
        public string SampleFileURL { get; set; }
    }
}
