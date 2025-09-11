using Sonali.API.Domain.Entities.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs.DemoDTO
{
    public class DemoDTO:Demos
    {
        // put extra properties here if needed
    }
    public class DemoDTORequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public int DemoItemId { get; set; }
        public string DemoItemName { get; set; }
        public string RefTo { get; set; }
        public string DemoItemTitle { get; set; }
        public string DemoItemDescription { get; set; }
        public bool DemoItemActive { get; set; }

        public int DAtacchmentId { get; set; }
        public string FileName { get; set; }
        public bool DAttachmentActive { get; set; }
    }

}
