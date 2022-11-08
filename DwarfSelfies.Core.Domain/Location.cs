using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfSelfies.Core.Domain
{
    /// <summary>
    /// Location d'un selfie
    /// </summary>
    public class Location
    {
        #region Constructors
        public Location(): this(0, string.Empty) {}

        public Location(int id, string libelle)
        {
            this.Libelle = libelle;
            this.Id = id;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Libelle { get; set; } = string.Empty;
        #endregion
    }
}
