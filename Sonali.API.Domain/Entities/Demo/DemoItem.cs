using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities.Demo
{
    public class DemoItems:RowEntity<int>
    {
        public int DemoId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Title { get; set; } = "";
        public bool IsActive { get; set; }
        public List<DemoItemFileAttachments>? DemoItemFileAttachments { get; set; } = new List<DemoItemFileAttachments>();
    }
}
