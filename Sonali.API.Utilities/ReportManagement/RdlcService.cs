using Microsoft.Reporting.NETCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sonali.API.Utilities.ReportManagement
{
    public interface IRdlcService
    {
        Task<Dictionary<string, object>> PrepareParameter(string parametersJson, Dictionary<string, object> paramsObj);
        byte[] ExportReport(string reportPath, DataTable data, string format, string dataSetName, Dictionary<string, object>? parameters = null);
        Task<DataTable> PrepareDataFromJSON(string dataJson, string dataSetName);
    }

    public class RdlcService : IRdlcService
    {
        public byte[] ExportReport(string reportPath, DataTable data, string format, string dataSetName, Dictionary<string, object>? parameters = null)
        {
            try
            {
                using var localReport = new LocalReport();
                localReport.ReportPath = reportPath;

                // Add DataSource
                localReport.DataSources.Add(new ReportDataSource(dataSetName, data));

                // Add parameters if any
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        localReport.SetParameters(new ReportParameter(param.Key, param.Value.ToString()));
                    }
                }

                string mimeType, encoding, fileNameExtension;
                string[] streams;
                Warning[] warnings;

                var renderedBytes = localReport.Render(
                    format: format,          // "PDF", "Excel", "Word"
                    deviceInfo: null,
                    out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings
                );

                return renderedBytes;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Convert paramsJson to Dictionary<string, object>
        /// </summary>
        /// <param name="parametersJson"></param>
        /// <param name="paramsObj"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, object>> PrepareParameter(string parametersJson, Dictionary<string, object> paramsObj)
        {
            try
            {
                JArray paramArray = JArray.Parse(parametersJson);
                foreach (JObject obj in paramArray)
                {
                    var key = obj["key"]?.ToString();
                    var value = obj["value"]?.ToString();

                    if (!string.IsNullOrEmpty(key))
                    {
                        paramsObj[key] = value ?? string.Empty;
                    }
                }
                return paramsObj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Convert dataJson to DataTable
        /// </summary>
        /// <param name="dataJson"></param>
        /// <param name="dataSetName"></param>
        /// <returns></returns>
        public async Task<DataTable> PrepareDataFromJSON(string dataJson, string dataSetName)
        {
            try
            {
                DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(dataJson);
                dataTable.TableName = dataSetName;
                return dataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
