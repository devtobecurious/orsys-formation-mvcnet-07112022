using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerAuTravail
{
    internal class ApiMeteoFrance : IMeteo
    {
        public Temps Fournir()
        {
            return Temps.IlFaitBeau;
        }
    }
}
