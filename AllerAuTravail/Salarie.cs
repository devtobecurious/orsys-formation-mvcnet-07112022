using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerAuTravail
{
    internal class Salarie : IDeplacable
    {
        private readonly IRegleDeplacement moteurDeplacement;

        /// <summary>
        ///  Comme le moteur de regle de déplacement pourra changer, mieux vaut ici 
        ///  fournir une interface (un contrat) au salarié
        ///  ==> On externalise les règles de changements
        /// </summary>
        /// <param name="moteurDeplacement"></param>
        public Salarie(IRegleDeplacement moteurDeplacement)
        {
            this.moteurDeplacement = moteurDeplacement; 
        }

        public void AllerAuTravail()
        {
            IMoyenDeDeplacement moyen = this.moteurDeplacement.Fournir();
            moyen.Deplacer(this);

            // Ici, on a une classe Tuple avec deux propriétés x et y
            // this.PositionCourante.y
        }

        public (int x, int y) PositionCourante { get; set; }
    }
}
