using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sonali.API.Domain.DTOs;
using Sonali.API.Domain.DTOs.DemoDTO;
using Sonali.API.Domain.Entities.Demo;
using Sonali.API.Domain.Interface;
using Sonali.API.DomainService.Interface;
using Sonali.API.Infrastructure.Data.Data;
using Sonali.API.Utilities.FileManagement;

namespace Sonali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoRepository _demoRepo;
        private readonly IDemoDomainService _iDataService;

        public DemoController( IDemoRepository demoRepo, IDemoDomainService dataService)
        {
            _demoRepo = demoRepo;
            _iDataService = dataService;
        }

        [Authorize]
        [HttpPost]
        [Route("Save")]
        public async Task<DemoDTO> Save([FromForm] string demo, [FromForm] List<IFormFile> files)
        {
            try
            {
                // Deserialize the JSON string
                var demoDto = JsonConvert.DeserializeObject<DemoDTO>(demo);

                return await _demoRepo.Save(demoDto, files);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetDemoList")]
        public async Task<object?> GetDemoList()
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetDemoList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpGet]
        [Route("GetDemoById")]
        public async Task<object?> GetDemoById([FromQuery] int id)
        {
            object? data = null;
            try
            {
                data = await _iDataService.GetDemoById(id);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return data;
        }

        [Authorize]
        [HttpDelete]
        [Route("Delete")]
        public async Task<bool> Delete(int id)
        {
            try
            {
                return await _demoRepo.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
