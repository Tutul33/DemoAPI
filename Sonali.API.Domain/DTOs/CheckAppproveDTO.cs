using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class CheckAppproveDTO
    {
        public int Id { get; set; }
        public string CheckedBy { get; set; } = "";
        public string ApprovedBy { get; set; }="";
    }
}
