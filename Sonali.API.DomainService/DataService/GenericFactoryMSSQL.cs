using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Sonali.API.DomainService.DataService
{
    public class GenericFactoryMSSQL<T> : IGenericFactoryMSSQL<T> where T : class, new()
    {
        public async Task<int> ExecuteCommandAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            int result = 0;
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(spQuery, con) { CommandType = CommandType.StoredProcedure };
                AddParameters(cmd, parameters);

                await using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    result = reader.GetInt32(0);
                }
            }
            catch (Exception)
            {
                throw; // Let caller handle or log
            }

            return result;
        }

        public async Task<string> ExecuteCommandStringAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            string result = string.Empty;
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(spQuery, con) { CommandType = CommandType.StoredProcedure };
                AddParameters(cmd, parameters);

                await using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    result = reader.IsDBNull(0) ? "[]" : reader.GetString(0);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public async Task<string> ExecuteCommandStringAsync(string spQuery, string conString)
        {
            string result = string.Empty;
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(spQuery, con) { CommandType = CommandType.StoredProcedure };

                await using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    result = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public async Task<List<T>> ExecuteCommandListAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            List<T> results = new List<T>();
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(spQuery, con) { CommandType = CommandType.StoredProcedure };
                AddParameters(cmd, parameters);

                await using var reader = await cmd.ExecuteReaderAsync();
                results = DataReaderMapToList(reader);
            }
            catch (Exception)
            {
                throw;
            }

            return results;
        }

        public async Task<T?> ExecuteCommandSingleAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            T? result = null;
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(spQuery, con) { CommandType = CommandType.StoredProcedure };
                AddParameters(cmd, parameters);

                await using var reader = await cmd.ExecuteReaderAsync();
                var list = DataReaderMapToList(reader);
                result = list.FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public async Task<T?> ExecuteQuerySingleAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            return await ExecuteCommandSingleAsync(spQuery, parameters, conString);
        }

        public async Task<List<T>> ExecuteQueryAsync(string spQuery, Dictionary<string, object?> parameters, string conString)
        {
            return await ExecuteCommandListAsync(spQuery, parameters, conString);
        }

        public async Task<List<T>> ExecuteCommandFuncAsync(string query, string conString)
        {
            List<T> results = new List<T>();
            try
            {
                await using var con = new SqlConnection(conString);
                await con.OpenAsync();

                await using var cmd = new SqlCommand(query, con) { CommandType = CommandType.Text };

                await using var reader = await cmd.ExecuteReaderAsync();
                results = DataReaderMapToList(reader);
            }
            catch (Exception)
            {
                throw;
            }

            return results;
        }

        private static void AddParameters(SqlCommand cmd, Dictionary<string, object?> parameters)
        {
            if (parameters == null) return;
            foreach (var kv in parameters)
            {
                cmd.Parameters.AddWithValue("@" + kv.Key, kv.Value ?? DBNull.Value);
            }
        }

        public List<T> DataReaderMapToList(IDataReader reader)
        {
            var results = new List<T>();
            var columnCount = reader.FieldCount;

            while (reader.Read())
            {
                var item = new T();

                var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i).ToLower()).ToArray();

                foreach (var property in typeof(T).GetProperties())
                {
                    // Skip virtual properties or properties not in data reader
                    if (property.GetGetMethod()?.IsVirtual != false || !rdrProperties.Contains(property.Name.ToLower()))
                        continue;

                    if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                    {
                        Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                        object value = reader[property.Name];
                        object? safeValue = Convert.ChangeType(value, convertTo);
                        property.SetValue(item, safeValue);
                    }
                }

                results.Add(item);
            }

            return results;
        }
    }
}
