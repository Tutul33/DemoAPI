using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.EntityExtensions
{
    public abstract class RowEntity<T> : Identity<T>, IRowEntity
    {
        public bool IsEnabled { get; set; }

        public bool IsSelected { get; set; }

        public EntityState Tag { get; set; }

        public string CodeGenPropertyVal { get; set; } = "";

        public int ResponseCode { get; set; }

        public string ResponseMessage { get; set; } = "";

        public bool ResponseSuccess { get; set; }
    }
}
