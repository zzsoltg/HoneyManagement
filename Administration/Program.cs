using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Administration
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<Common.Database.IDatabase, Common.Database.SqliteDatabase>();
                    services.AddTransient<DefaultForm>();
                    services.AddTransient<AddProductsForm>();
                }).Build();

            using var serviceScope = host.Services.CreateScope();
            var startForm = serviceScope.ServiceProvider.GetRequiredService<DefaultForm>();

            Application.Run(startForm);
        }
    }
}