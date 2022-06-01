using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion
{
    public class ProductRepository : IProductRepository
    {
        //ders örneği
        public int Count { get; set; }

        public List<string> GetList()
        {
            return new List<string>() { "Ahmet", "Mehmet", "Hasan" };
        }

        public void InlineMethod()
        {

        }
    }
}
