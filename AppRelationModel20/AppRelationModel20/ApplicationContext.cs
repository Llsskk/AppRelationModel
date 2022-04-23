using Microsoft.EntityFrameworkCore;

namespace AppRelationModel20

{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;" +
            "Port=5433;" +
            "Database=testdb;" +
            "Username=postgres;" +
            "Password=rinh2021");
        }
    }
}

