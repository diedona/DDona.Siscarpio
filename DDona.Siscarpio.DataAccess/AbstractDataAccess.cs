using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.Siscarpio.DataAccess
{
    public class AbstractDataAccess
    {
        private const string CONNECTION_STRING = "SiscarpioContext";

        public List<T> Get<T>(string SQL, object Params = null) where T: class
        {
            DapperWrapper Dapper = new DapperWrapper(CONNECTION_STRING);
            return Dapper.Get<T>(SQL, Params);
        }
    }
}
