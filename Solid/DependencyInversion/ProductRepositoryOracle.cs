using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion
{
    internal class ProductRepositoryOracle : IProductRepository
    {
        //ders örneği
        public List<string> GetList()
        {
            return new List<string>() { "Oracle Ahmet", "Oracle Mehmet", "Oracle Hasan" };
        }
    }
}
