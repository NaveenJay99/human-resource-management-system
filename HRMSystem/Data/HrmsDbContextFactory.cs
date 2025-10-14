using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HRMSystem.Data
{
    public class HrmsDbContextFactory : IDesignTimeDbContextFactory<HrmsDbContext>
    {
        public HrmsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HrmsDbContext>();

            // Same connection string as in App.xaml.cs
            var connectionString = "Server=localhost\\SQLEXPRESS;Database=HRMSDB;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);

            return new HrmsDbContext(optionsBuilder.Options);
        }
    }
}
