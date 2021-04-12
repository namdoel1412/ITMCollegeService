using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Extensions
{
    public static class GetDBConnection
    {
        public static async Task<MySqlConnection> SetConnection(string server, string database, string user, string pass)
        {
            //Data Source = LAPTOP - CKLCQUVA\MISASME2017; Initial Catalog = Namdd; Persist Security Info = True; User ID = namdd; Password = ***********
            //Data Source = 192.168.242.1; Initial Catalog = NamDD_WebApi; Persist Security Info = True; User ID = namdd; Password = ***********
            string connectionString = $"server={server};port=3306;database={database};uid={user};password={pass}";//"Data Source = " + server + "; Initial Catalog = " + database + "; Persist Security Info = True; User Id = " + user + "; Password = " + pass;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            try
            {
                //MyLogger.LogSQL("connection.Open()\n");
                await connection.OpenAsync();
                //MyLogger.LogSQL("Success.Open this connection!");
            }
            catch (Exception e)
            {
                //MyLogger.LogError(CCommon.GetDetailError(e));
            }
            return connection;
        }
    }
}
