using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Tank;

namespace Tank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<FormTanksCollections>());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<FormTanksCollections>().AddLogging(option =>
            {
                string[] path = Directory.GetCurrentDirectory().Split('\\');
                string pathNeed = "";
                for (int i = 0; i < path.Length - 3; i++)
                {
                    pathNeed += path[i] + "\\";
                }
                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path: $"{pathNeed}appSetting.json", optional: false, reloadOnChange: true).Build();
                var logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

                option.SetMinimumLevel(LogLevel.Information);
                option.AddSerilog(logger);
            });
        }
    }
}