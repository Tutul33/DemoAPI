using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sonali.API.Utilities.Helper
{
    public static class DataTableHelper
    {
        public static DataTable ToDataTable<T>(List<T> items)
        {
            try
            {
                var dataTable = new DataTable(typeof(T).Name);

                if (items == null || items.Count == 0)
                    return dataTable;

                // Get all the properties of T
                PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                // Create columns in DataTable for each property
                foreach (var prop in props)
                {
                    // Handle nullable types
                    Type propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    dataTable.Columns.Add(prop.Name, propType);
                }

                // Fill rows
                foreach (T item in items)
                {
                    var values = new object[props.Length];

                    for (int i = 0; i < props.Length; i++)
                    {
                        var val = props[i].GetValue(item, null);
                        values[i] = val ?? DBNull.Value; // replace nulls with DBNull.Value
                    }

                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<T> DataTableToList<T>(DataTable table) where T : new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (DataRow row in table.Rows)
                {
                    T obj = new T();

                    foreach (DataColumn column in table.Columns)
                    {
                        var property = typeof(T).GetProperty(column.ColumnName);
                        if (property != null && row[column] != DBNull.Value)
                        {
                            // Handle Nullable<T>
                            Type targetType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                            object safeValue = Convert.ChangeType(row[column], targetType);
                            property.SetValue(obj, safeValue);
                        }
                    }

                    list.Add(obj);
                }

                return list;


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
