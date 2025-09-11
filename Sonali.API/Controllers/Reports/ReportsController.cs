using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sonali.API.Utilities;
using Sonali.API.Utilities.ReportManagement;
using System.Data;
using System.Text.Json;

namespace Sonali.API.Controllers.Reports
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IRdlcService _rdlcService;
        private readonly IWebHostEnvironment _env;
        public ReportsController(IRdlcService rdlcService, IWebHostEnvironment env)
        {
            _rdlcService = rdlcService;
            _env = env;
        }

        [HttpPost("ShowReports")]
        public async Task<IActionResult> ShowReports([FromBody] JsonElement data)
        {
            JObject jObject = JObject.Parse(data.ToString());

            string reportType = jObject["reportType"]?.ToString()?.ToLower() ?? "pdf";
            string reportName = jObject["reportName"]?.ToString() ?? "";
            string dataJson = jObject["data"]?.ToString() ?? "";
            string parametersJson = jObject["params"]?.ToString() ?? "";
            string dataSetName = jObject["dataSetName"]?.ToString() ?? "";

            // Convert dataJson to DataTable
            DataTable dataTable = new DataTable();
            if (!string.IsNullOrEmpty(dataJson))
            {
                try
                {
                    dataTable = await _rdlcService.PrepareDataFromJSON(dataJson, dataSetName);
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid data format for DataTable: {ex.Message}");
                }
            }

            // Convert paramsJson to Dictionary<string, object>
            var paramsObj = new Dictionary<string, object>();
            if (!string.IsNullOrEmpty(parametersJson))
            {
                try
                {
                    await _rdlcService.PrepareParameter(parametersJson, paramsObj);
                }
                catch (Exception ex)
                {
                    return BadRequest($"Invalid params format: {ex.Message}");
                }
            }

            // Build Report Path
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "RDLC", reportName+".rdlc");

            if (!System.IO.File.Exists(reportPath))
                return NotFound($"Report file not found: {reportPath}");

            string renderFormat = reportType.ToLower() switch
            {
                "pdf" => "PDF",
                "excel" => "EXCELOPENXML",
                "word" => "WORDOPENXML",
                "image" => "IMAGE",
                _ => "PDF"
            };

            // Export RDLC
            var fileContent = _rdlcService.ExportReport(reportPath, dataTable, renderFormat, dataSetName, paramsObj);

            // Decide folder & extension by report type
            string extension = reportType switch
            {
                "pdf" => "pdf",
                "excel" => "xlsx",
                "word" => "docx",
                "image" => "png",
                _ => "bin"
            };

            //string saveFolder = Path.Combine(Directory.GetCurrentDirectory(), "Reports", extension.ToUpperInvariant());
            string saveFolder = Path.Combine(ReportFileSettings.BasePath, extension.ToUpperInvariant());
            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);

            string fileName = $"{reportName}_{DateTime.Now:yyyyMMddHHmmss}.{extension}";
            string fullPath = Path.Combine(saveFolder, fileName);

            System.IO.File.WriteAllBytes(fullPath, fileContent);

            // Return JSON with file name and type
            return Ok(new { fileName, reportType = extension });
        }

        [HttpGet("download/{fileType}/{fileName}")]
        public IActionResult DownloadReport(string fileType, string fileName)
        {
            try
            {
                // Full path
                //var filePath = Path.Combine(_env.ContentRootPath, "Reports", fileType, fileName);
                var filePath = Path.Combine(ReportFileSettings.BasePath, fileType, fileName);

                if (!System.IO.File.Exists(filePath))
                    return NotFound("File not found");

                // Get bytes
                var fileBytes = System.IO.File.ReadAllBytes(filePath);

                // Determine content type
                string contentType = fileName.EndsWith(".pdf") ? "application/pdf" :
                                     fileName.EndsWith(".docx") ? "application/vnd.openxmlformats-officedocument.wordprocessingml.document" :
                                     fileName.EndsWith(".xlsx") ? "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" :
                                     "application/octet-stream";

                return File(fileBytes, contentType, fileName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
