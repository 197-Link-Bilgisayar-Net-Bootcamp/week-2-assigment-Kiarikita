using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion
{
    //ders örneği
    public interface IProductRepository
    {
        List<string> GetList();
    }
}
