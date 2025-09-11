using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class UserRoleMap:RowEntity<int>
    {
        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public bool? IsActive { get; set; }
    }
}
