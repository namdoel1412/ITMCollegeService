using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Extensions
{
    public static class ServiceExtensions
    {
        public static void CongigureMySqlConnection<T>(this IServiceCollection services, IConfiguration config) where T : DbContext
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<T>(o => o.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
