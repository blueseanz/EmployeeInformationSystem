using BusinessObjectLayer;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class EISDBContext : DbContext
    {
        public EISDBContext() : base("EISDB")
        {

        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
