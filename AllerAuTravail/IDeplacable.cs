using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllerAuTravail
{
    internal interface IDeplacable
    {
        /// <summary>
        /// Ici le (int x, int y) représente un Tuple<int, int> 
        /// Ca utilise ainsi : Tuple<int, int> maVariable; maVariable.Item1 = 1; maVariable.Item2 = 1;
        /// </summary>
        /// <returns></returns>
        (int x, int y) PositionCourante { get; set; }
    }
}
