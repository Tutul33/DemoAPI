using Sonali.API.Infrastructure.Data.Models;
using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities
{    
    public class ChatMessages:AuditableEntity<int>
    {
        public string? Sender { get; set; }

        public string? Receiver { get; set; }

        public string? Text { get; set; }

        public DateTime? SentDate { get; set; }

        public bool? IsRead { get; set; }

        public bool? IsActive { get; set; }

        
    }
}
