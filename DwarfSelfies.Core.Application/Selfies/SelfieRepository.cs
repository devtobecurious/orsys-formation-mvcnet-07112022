using DwarfSelfies.Core.Domain;
using DwarfSelfies.Core.Interfaces.DataLayers;
using DwarfSelfies.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfSelfies.Core.Application.Selfies
{
    public class SelfieRepository : ISelfieRepository
    {
        private readonly ISelfieDataLayer layer;

        /// <summary>
        ///  Si j'ai besoin d'autres règles, je vais les 
        ///  chercher via d'autres datalayers
        /// </summary>
        /// <param name="layer"></param>
        public SelfieRepository(ISelfieDataLayer layer)
        {
            this.layer = layer;
        }

        public List<Selfie> GetAll()
        {
            // C'est bien dans le repo que les regles métiers
            // sont écrites !

            var query = from item in this.layer.GetAll()
                        where item.Id < 10
                        select item;

            return query.ToList();
        }
    }
}
