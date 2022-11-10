using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfSelfies.Core.Interfaces.DataLayers
{
    public interface IMainDataLayer<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
