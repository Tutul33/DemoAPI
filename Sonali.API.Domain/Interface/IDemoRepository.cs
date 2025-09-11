using Microsoft.AspNetCore.Http;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Domain.Interface
{
    public interface IDemoRepository
    {
        Task<DemoDTO> Save(DemoDTO demo, List<IFormFile> files);
        Task<bool> Delete(int id);
    }
}
