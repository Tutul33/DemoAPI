using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.EntityExtensions
{
    public abstract class AuditableEntity<T> : Identity<T>, IAuditableEntity
    {
        public byte LocationID { get; set; }

        public DateTime CreateDate { get; set; }

        public int InsertUserID { get; set; }

        public DateTime LastUpdate { get; set; }

        public int? EditUserID { get; set; }

        public string CodeGenPropertyVal { get; set; } = "";

        public int ResponseCode { get; set; }

        public string ResponseMessage { get; set; } = "";

        public bool ResponseSuccess { get; set; }
    }
}
