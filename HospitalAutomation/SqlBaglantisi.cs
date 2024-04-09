using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    public class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection sqlConnection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=HastaneOtamasyonuDB;User Id=sa;Password=123");
            sqlConnection.Open();

            return sqlConnection; ;
        }
    }
}
