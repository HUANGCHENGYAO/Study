using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace NIPO.Base
{
    public class Connection
    {
        SqlConnection SqlConection;
       public Connection()
        {
            string ConnnectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["Connection1"].ConnectionString.Replace(" ", "");
            SqlConection = new SqlConnection(ConnnectionStr);
        }

        
        public SqlDataReader db()
        {
           
                SqlDataReader SqlDataReader;
                SqlConection.Open();
                SqlCommand SqlCommand = new SqlCommand();
                SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand.CommandText = "TEST";
                SqlCommand.Connection = SqlConection;
                SqlDataReader = SqlCommand.ExecuteReader();
                return SqlDataReader;
                SqlConection.Close();        
        }
    }
}
