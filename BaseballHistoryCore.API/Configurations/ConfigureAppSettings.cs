using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballHistoryCore.API.Configurations
{
    public static class ConfigureAppSettings
    {
        public static IServiceCollection AddAppSettings(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.Configure<AppSettings>(_ => configuration.GetSection("AppSettings").Bind(_));

            return services;
        }
    }
}
