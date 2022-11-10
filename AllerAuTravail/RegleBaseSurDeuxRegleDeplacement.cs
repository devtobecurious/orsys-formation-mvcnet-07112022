using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerAuTravail
{
    internal class RegleBaseSurDeuxRegleDeplacement : IRegleDeplacement
    {
        public RegleBaseSurDeuxRegleDeplacement(IRegleDeplacement une, IRegleDeplacement deux)
        {

        }

        public IMoyenDeDeplacement Fournir()
        {
            throw new NotImplementedException();
        }
    }
}
