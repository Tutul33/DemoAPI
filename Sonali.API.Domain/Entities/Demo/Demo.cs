using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities.Demo
{
    public class Demos:AuditableEntity<int>
    {
        public string Name { get; set; } = "";
        public bool IsActive { get; set; }
        public List<DemoItems>? DemoItems { get; set;} = new List<DemoItems>();
    }
}
