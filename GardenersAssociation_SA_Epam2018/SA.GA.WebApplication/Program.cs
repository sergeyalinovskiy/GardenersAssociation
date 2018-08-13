namespace SA.GA.WebApplication
{
    #region Usings
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    #endregion
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
    }
}