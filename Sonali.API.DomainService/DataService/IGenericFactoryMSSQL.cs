using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Sonali.API.DomainService.DataService
{
    public interface IGenericFactoryMSSQL<T> where T : class
    {
        Task<int> ExecuteCommandAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<string> ExecuteCommandStringAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<string> ExecuteCommandStringAsync(string spQuery, string conString);
        Task<List<T>> ExecuteCommandListAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<T?> ExecuteCommandSingleAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<T?> ExecuteQuerySingleAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<List<T>> ExecuteQueryAsync(string spQuery, Dictionary<string, object?> parameters, string conString);
        Task<List<T>> ExecuteCommandFuncAsync(string query, string conString);
        List<T> DataReaderMapToList(IDataReader reader);
    }
}
