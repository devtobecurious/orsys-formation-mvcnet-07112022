using DwarfSelfies.Core.Domain;
using DwarfSelfies.Core.Interfaces.DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfSelfies.Core.Infrastructures.Data.DataLayers
{
    public class SelfieDataLayer : ISelfieDataLayer
    {
        private readonly DefaultDbContext context;

        public SelfieDataLayer(DefaultDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Selfie> GetAll()
        {
            return this.context.Selfies;
        }
    }
}
