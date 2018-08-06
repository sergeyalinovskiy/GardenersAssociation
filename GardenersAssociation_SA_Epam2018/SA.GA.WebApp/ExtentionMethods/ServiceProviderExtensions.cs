using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SA.GA.Business.Services;
using SA.GA.Business.Services.Implementation;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Context;
using SA.GA.DataAccess.Context.Implementation;
using SA.GA.DataAccess.Repository;
using SA.GA.DataAccess.Repository.Implementation;

namespace SA.GA.WebApp.ExtentionMethods
{
    public static class ServiceProviderExtensions
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, Repository<User>>();
            services.AddTransient<IRepository<Plot>, Repository<Plot>>();
            services.AddTransient<IRepository<Electricity>, Repository<Electricity>>();
            services.AddTransient<IRepository<Rate>, Repository<Rate>>();

            services.AddTransient<IRateService, RateService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPlotService, PlotService>();
            services.AddTransient<IElectricityService, ElectricityService>();

            services.AddTransient<IDbContext<User>, AppContext<User>>();
            services.AddTransient<IDbContext<Plot>, AppContext<Plot>>();
            services.AddTransient<IDbContext<Electricity>, AppContext<Electricity>>();
            services.AddTransient<IDbContext<History>, AppContext<History>>();
            services.AddTransient<IDbContext<Rate>, AppContext<Rate>>();

            var connection2 = @"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Contoso; Integrated Security = True; Connect Timeout = 30; ";
            var connection = @"Server =.\SQLEXPRESS01; Database = SA.GA.DB; Trusted_Connection = True;";
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
        }
    }
}