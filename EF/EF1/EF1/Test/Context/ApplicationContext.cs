using Microsoft.EntityFrameworkCore;

namespace Test.Context
{
    public class ApplicationContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Country> countries { get; set; }

        public DbSet<Movie> movies { get; set; }

        public ApplicationContext() : base()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=10.32.101.127;Database=Cinema-6;Username=postgres;");
        }

    }
}
