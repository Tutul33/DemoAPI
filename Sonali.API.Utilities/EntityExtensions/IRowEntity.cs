using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.EntityExtensions
{
    public interface IRowEntity
    {
        bool IsEnabled { get; set; }

        bool IsSelected { get; set; }

        EntityState Tag { get; set; }
    }
}
