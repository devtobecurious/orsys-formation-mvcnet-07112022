using Microsoft.EntityFrameworkCore;
using DwarfSelfies.Core.Domain;
using ChangeLiveConnnectionString.Models;

namespace ChangeLiveConnnectionString.Models
{
    public class DefaultDbContext : DbContext
    {
        private readonly IConnectionStringProvider provider; 

        public DefaultDbContext(DbContextOptions options, IConnectionStringProvider provider) : base(options)
        {
            this.provider = provider;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.provider.Get());
        }

        public DbSet<Selfie> Selfie { get; set; }
    }
}
