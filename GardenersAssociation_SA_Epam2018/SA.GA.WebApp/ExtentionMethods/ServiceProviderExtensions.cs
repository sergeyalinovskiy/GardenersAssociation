using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Context;
using SA.GA.DataAccess.Context.Implementation;
using SA.GA.DataAccess.Repository;
using SA.GA.DataAccess.Repository.Implementation;
using System.Configuration;

namespace SA.GA.WebApp.ExtentionMethods
{
    public static class ServiceProviderExtensions
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            


            //services.AddTransient<IDbContext<User>, AppContext<User>>();
            //services.AddTransient<IDbContext<Plot>, AppContext<Plot>>();
            //services.AddTransient<IDbContext<Electricity>, AppContext<Electricity>>();
            //services.AddTransient<IDbContext<History>, AppContext<History>>();
            //services.AddTransient<IDbContext<Rate>, AppContext<Rate>>();










            var connection = @"Server =.\SQLEXPRESS01; Database = SA.GA.DB4; Trusted_Connection = True;";
            //services.AddDbContext<AppContext2>(options => options.UseSqlServer(connection));
            services.AddDbContext<AppContext2>(options =>
                options.UseSqlServer(
                    connection,
                    b => b.MigrationsAssembly("SA.GA.WebApp")
                ));
            //services.AddDbContext<AppContext<Plot>>(options => options.UseSqlServer(connection));
            //services.AddDbContext<AppContext<Electricity>>(options => options.UseSqlServer(connection));
            //services.AddDbContext<AppContext<History>>(options => options.UseSqlServer(connection));
            //services.AddDbContext<AppContext<Rate>>(options => options.UseSqlServer(connection));



            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Plot>, Repository<Plot>>();
            services.AddTransient<IRepository<Electricity>, Repository<Electricity>>();
            services.AddTransient<IRepository<Rate>, Repository<Rate>>();


           
        }
    }
}