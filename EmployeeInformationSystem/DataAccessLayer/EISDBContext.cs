using BusinessObjectLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class EISDBContext : DbContext
    {
        public EISDBContext() : base("EmployeeInformationSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EISDBContext, DataAccessLayer.Migrations.Configuration>());
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
