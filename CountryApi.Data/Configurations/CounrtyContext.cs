using Microsoft.EntityFrameworkCore;
using CountryApi.Entity.Concrete;
using CountryApi.Data.Concrete.EfCore.Configs;

namespace CountryApi.Data.Concrete.EfCore
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
