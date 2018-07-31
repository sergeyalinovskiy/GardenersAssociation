using Microsoft.Extensions.DependencyInjection;
using SA.GA.Common.Models;
using SA.GA.DataAccess.Context;
using SA.GA.DataAccess.Context.Implementation;
using SA.GA.DataAccess.Repository;
using SA.GA.DataAccess.Repository.Implementation;

namespace SA.GA.DataAccess.Dependency
{
    public class DataAccessDependencyRegistry
    {
        public void ConfigureServices(IServiceCollection services)
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
