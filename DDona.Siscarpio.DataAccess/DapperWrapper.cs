using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DDona.Siscarpio.DataAccess
{
    public class DapperWrapper
    {
        private string _connectionString = null;

        public DapperWrapper(string ConnectionName)
        {
            try
            {
                _connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> Get<T>(string SQL, object Param = null) where T : class
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    return db.Query<T>(SQL, Param).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
