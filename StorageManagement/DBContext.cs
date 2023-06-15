using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Configuration;

namespace StorageManagement
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DbContext> opt) : base(opt)
        {
                
        }

        public DbSet<UserCatalog> UserCatalogs { get; set; }
        public DbSet<OperationLog> OperationLogs { get; set; }
        public DbSet<Bank> Banks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConfigurationManager.AppSettings["ConnectionSport"]; 
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnectionSport"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCatalog>().ToTable("UserCatalog");
            modelBuilder.Entity<OperationLog>().ToTable("OperationLog");
            modelBuilder.Entity<Bank>().ToTable("Bank");
        }
    }
}