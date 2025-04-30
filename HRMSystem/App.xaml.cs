using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows;
using HRMSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HRMSystem
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            var connectionString = "Server=localhost\\SQLEXPRESS;Database=HRMSDB;Trusted_Connection=True;TrustServerCertificate=True;";

            services.AddDbContext<HrmsDbContext>(options =>
                options.UseSqlServer(connectionString));

            ServiceProvider = services.BuildServiceProvider();

            base.OnStartup(e);
        }
    }
}
