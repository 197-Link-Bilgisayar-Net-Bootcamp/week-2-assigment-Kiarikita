using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.Business.Abstract
{
    public interface IProductService
    {
        //dependency injection kullanabilmek için interface tanımlandı

        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product GetProductByName(string name);

        Product UpdateProduct(Product product);

        Product CreateProduct(Product product);

        void DeleteProduct(int id);
    }
}
