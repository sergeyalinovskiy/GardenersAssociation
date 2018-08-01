using Microsoft.Extensions.DependencyInjection;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Context;
using SA.GA.DataAccess.Context.Implementation;
using SA.GA.DataAccess.Repository;
using SA.GA.DataAccess.Repository.Implementation;
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
            services.AddSingleton<IDbContext<History>, AppContext<History>>();
            services.AddSingleton<IDbContext<Rate>, AppContext<Rate>>();


            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Plot>, Repository<Plot>>();
            services.AddTransient<IRepository<Electricity>, Repository<Electricity>>();
            services.AddTransient<IRepository<Rate>, Repository<Rate>>();

        }
    }
}
