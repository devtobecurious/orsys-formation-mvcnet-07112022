using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerAuTravail
{
    internal class BaseSurMeteoRegleDeplacement : IRegleDeplacement
    {
        private readonly IMeteo meteo;

        public BaseSurMeteoRegleDeplacement(IMeteo meteo)
        {
            this.meteo = meteo;
        }

        public IMoyenDeDeplacement Fournir()
        {
            IMoyenDeDeplacement moyen = null;
            var temps = this.meteo.Fournir();

            switch (temps)
            {
                case Temps.IlFaitBeau:
                    moyen = new Voiture();
                    break;
                case Temps.IlPleut:
                    moyen = new Voiture();
                    break;
                case Temps.IlNeige:
                    moyen = new Voiture();
                    break;
                case Temps.IlGrele:
                    moyen = new Train();
                    break;
                case Temps.IlFaitFroid:
                    moyen = new Train();
                    break;
                default:
                    moyen = new Voiture();
                    break;
            }

            return moyen;
        }
    }
}
