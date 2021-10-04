using FireFly.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FireFly.Data
{
    public class FireFlyContext : DbContext
    {
        public FireFlyContext() : base("FireFlyContext")
        {

        }

        public DbSet<Authentication> Authentication { get; set; }
        public DbSet<SystemSettings> SystemSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}