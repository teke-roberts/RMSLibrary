using System;
using System.Collections.Generic;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RMSLibrary
{
    public static class GlobalConfig
    {
        public static SqlConnection Cnn {  get; set; }
        public static void InitializeConnections()
        {
            Cnn = new SqlConnection();
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
