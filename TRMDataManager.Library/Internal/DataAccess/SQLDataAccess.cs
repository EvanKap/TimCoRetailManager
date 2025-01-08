using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TRMDataManager.Library.Internal.DataAccess 
{

    internal class SQLDataAccess
    {

        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters, string connStringName)
        {
            string connectionString = GetConnectionString(connStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<T> rows = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return rows;
            }
        }


        public void SaveData<T>(string storedProcedure, T parameters, string connStringName)
        {

            string connectionString = GetConnectionString(connStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }

        }
    }




}
