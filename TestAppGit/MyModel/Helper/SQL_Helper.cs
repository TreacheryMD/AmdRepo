using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyModel.Helper
{
    public class SQL_Helper
    {
        public string ConnStr;
        private string ConnStrName = null;
        public string Error;


        public string connStrName
        {
            get { return ConnStrName; }
            set
            {
                foreach (ConnectionStringSettings c in ConfigurationManager.ConnectionStrings)
                {
                    if (c.Name.ToLower() == value.ToLower())
                    {
                        ConnStrName = connStrName;
                        ConnStr = c.ConnectionString;
                        return;
                    }
                }
            }
        }

        public void CreateCommand(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       ConnStr))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public string ExecScalarQuery(string sqlText)
        {
            string result = "";
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sqlText, conn))
                {
                    command.CommandTimeout = 1900;
                    try
                    {
                        result = command.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                    }
                }
            }
            return result;
        }

        public DataTable BuildQueryCommand(string sqlString)
        {
            DataSet dataSet = new DataSet();
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd; //define select
                    cmd.CommandTimeout = 1900;
                    try
                    {
                        dataAdapter.Fill(dataSet);
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                    }
                }
            }
            return dataSet.Tables[0].Rows.Count > 0 ? dataSet.Tables[0] : null;
        }

        public DataTable GetDataTableFromSP(string spName, SqlParameter[] parameters = null, DataTable t = null)
        {
            if (t == null)
                t = new DataTable();
            try
            {
                using (var conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    using (var a = new SqlDataAdapter(spName, conn))
                    {
                        a.SelectCommand.CommandType = CommandType.StoredProcedure;
                        a.SelectCommand.CommandTimeout = 1600;
                        if (parameters != null)
                        {
                            foreach (SqlParameter parameter in parameters)
                            {
                                a.SelectCommand.Parameters.Add(parameter);
                            }
                        }
                        a.Fill(t);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return t;
        }

        public DataSet GetDataSetFromSP(string spName, IDataParameter[] parameters = null)
        {
            var t = new DataSet();
            try
            {
                using (var conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    using (var a = new SqlDataAdapter(spName, conn))
                    {
                        a.SelectCommand.CommandType = CommandType.StoredProcedure;
                        a.SelectCommand.CommandTimeout = 1600;
                        if (parameters != null)
                        {
                            foreach (SqlParameter parameter in parameters)
                            {
                                a.SelectCommand.Parameters.Add(parameter);
                            }
                        }
                        a.Fill(t);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return t;
        }
       
    }
}
