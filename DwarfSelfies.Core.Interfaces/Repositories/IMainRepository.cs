using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfSelfies.Core.Interfaces.Repositories
{
    public interface IMainRepository<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll();
    }
}
