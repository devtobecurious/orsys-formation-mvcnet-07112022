using DwarfSelfies.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DwarfSelfies.Web.UI.Models
{
    public class DefaultDbContext : DbContext
    {
        #region Properties
        public DbSet<Selfie> Selfies { get; set; }
        #endregion
    }
}
