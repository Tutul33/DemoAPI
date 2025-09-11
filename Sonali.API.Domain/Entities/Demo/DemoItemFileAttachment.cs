using Sonali.API.Utilities.EntityExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Entities.Demo
{
    public class DemoItemFileAttachments:RowEntity<int>
    {
        public int DemoItemId { get; set; }
        public string? FileName { get; set; }
        public string? FolderNAme { get; set; }
        public bool IsActive { get; set; }
    }
}
