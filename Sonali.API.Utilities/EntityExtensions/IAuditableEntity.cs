using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.EntityExtensions
{
    public interface IAuditableEntity
    {
        DateTime CreateDate { get; set; }

        int InsertUserID { get; set; }

        DateTime LastUpdate { get; set; }

        int? EditUserID { get; set; }
    }
}
