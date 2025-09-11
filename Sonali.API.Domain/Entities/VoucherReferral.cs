using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class VoucherReferral: AuditableEntity<int>
    {
        public string VoucherNo { get; set; } = "";

        public string RefBy { get; set; } = "";

        public string RefTo { get; set; } = "";

        public string RefType { get; set; } = "";

        public string Comments { get; set; } = "";

        public DateTime? ReferDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
