using DwarfSelfies.Core.Domain;
using DwarfSelfies.Web.UI.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DwarfSelfies.Web.UI.Models
{
    public class DefaultDbContext : DbContext
    {
        #region Constructors
        public DefaultDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultDbContext()
        {
        }
        #endregion

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Selfie>().ToTable("Selfie");
            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            
            modelBuilder.Entity<Location>().ToTable("Location");
        }
        #endregion

        #region Properties
        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Location> Locations { get; set; }
        #endregion
    }
}
