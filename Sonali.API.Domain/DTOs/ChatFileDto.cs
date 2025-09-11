using Microsoft.AspNetCore.Http;
using Sonali.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.DTOs
{
    public class ChatFileDto:ChatFiles
    {
        public IFormFile? File { get; set; }
    }
}
