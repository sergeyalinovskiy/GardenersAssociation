using Microsoft.Extensions.DependencyInjection;
using SA.GA.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.GA.WebApp.ExtentionMethods
{
    public static class ServiceProviderExtensions
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddSingleton<IDbContext<User>, AppContext<User>>();
            services.AddSingleton<IDbContext<Plot>, AppContext<Plot>>();
            services.AddSingleton<IDbContext<Electricity>, AppContext<Electricity>>();

            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Plot>, Repository<Plot>>();
            services.AddTransient<IRepository<Electricity>, Repository<Electricity>>();
        }
    }
}
