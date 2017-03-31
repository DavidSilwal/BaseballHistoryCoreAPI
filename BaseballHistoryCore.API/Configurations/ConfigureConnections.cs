//using BaseballHistoryCore.API.Services;
//using BaseballHistoryCore.Data.DataModels;
using BaseballHistoryCore.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseballHistoryCore.API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var connection = configuration.GetConnectionString("BaseballStatsDb");
            services.AddDbContext<BaseballStatsContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
