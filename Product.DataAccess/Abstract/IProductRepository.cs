using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.DataAccess.Abstract
{
    public interface IProductRepository
    {
        //methodlar tanımlandı

        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product GetProductByName(string name);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
