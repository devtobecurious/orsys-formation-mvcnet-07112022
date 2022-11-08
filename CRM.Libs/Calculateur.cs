using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Libs
{
    public class Calculateur
    {
        public float CalculerTva(float montantHT, 
                                 Func<float> getValeurTva,
                                 AfficherMonInfo afficher)
        {
            var result = montantHT * getValeurTva();

            // Attention, je suis fortement couplé à la console
            // Je veux afficher mon résultat pour l'utilisateur final
            // Créer une variable qui va pointer vers une fonction
            afficher(result.ToString());


            return result;
        }
    }
}
