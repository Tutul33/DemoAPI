using Sonali.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? TypeName { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public long? RfId { get; set; }

        public string? UpdateCardBy { get; set; }

        public DateTime? UpdateCardDate { get; set; }
    }
}
