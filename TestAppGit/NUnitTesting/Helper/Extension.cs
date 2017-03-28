using NUnitTesting.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.Extension
{
    public static class Extension
    {
        public static DataTable ListToDataTable<T>(this IList<T> data, string tableName)
        {
            DataTable table = new DataTable(tableName);

            //special handling for value types and string
            if (typeof(T).IsValueType || typeof(T) == typeof(string))
            {
                DataColumn dc = new DataColumn("Value");
                table.Columns.Add(dc);
                foreach (T item in data)
                {
                    DataRow dr = table.NewRow();
                    dr[0] = item;
                    table.Rows.Add(dr);
                }
            }
            else
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                foreach (PropertyDescriptor prop in properties)
                {
                    table.Columns.Add(prop.Name,
                    Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        try
                        {
                            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                        }
                        catch (Exception ex)
                        {
                            row[prop.Name] = DBNull.Value;
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public static List<T> FilterNegativeBankAccounts<T>(this IEnumerable<T> data) where T : BankAccount
        {
            return data.Where(w => w.Balance > 0).ToList<T>();
        }
    }
}
