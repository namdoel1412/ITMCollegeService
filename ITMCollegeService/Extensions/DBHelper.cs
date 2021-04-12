using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Extensions
{
    public class DBHelper
    {
        public static async Task<MySqlConnection> SetConnection()
        {
            //Data Source = LAPTOP - CKLCQUVA\MISASME2017; Initial Catalog = Namdd; Persist Security Info = True; User ID = namdd; Password = ***********
            //Data Source = jarvis2020.ddns.net; Initial Catalog = Jarvis2019; Persist Security Info = True; User ID = AS; Password = ***********
            //Data Source = 149.28.148.11; Initial Catalog = Jarvis2019; Persist Security Info = True; User ID = JARVIS; Password = ***********
            string DATABASE = "itmcollege";
            string DATASOURCE = "localhost";
            string USER = "root";
            string PASS = "admin";
            return await GetDBConnection.SetConnection(DATASOURCE, DATABASE, USER, PASS);
        }
    }
}
