using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SA.GA.Business.Services;
using SA.GA.Business.Services.Implementation;
using SA.GA.DataAccess.Context.Implementation;
using SA.GA.DataAccess.Repository;
using SA.GA.DataAccess.Repository.Implementation;

namespace SA.GA.WebApp.ExtentionMethods
{
    public static class ServiceProviderExtensions
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPlotRepository, PlotRepository>();
            services.AddTransient<IElectricityRepository, ElectricityRepository>();
            services.AddTransient<IRateRepository, RateRepository>();
            services.AddTransient<IHistoryRepository, HistoryRepository>();

            services.AddTransient<IRateService, RateService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPlotService, PlotService>();
            services.AddTransient<IElectricityService, ElectricityService>();
            services.AddTransient<IHistoryService, HistoryService>();
            

            var connection = @"Server =.\SQLEXPRESS01; Database = SA.GA.DB; Trusted_Connection = True;";

            services.AddDbContext<AppContext2>(options =>
                options.UseSqlServer(
                    connection,
                    b => b.MigrationsAssembly("SA.GA.WebApp")
                ));
        }
    }
}