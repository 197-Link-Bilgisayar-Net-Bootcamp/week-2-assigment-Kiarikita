using ProductFinder.DataAccess.Abstract;
using ProductFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                var model = GetProductById(id);
                //var model = productDbContext.Products.Find(id);
                productDbContext.Products.Remove(model);
                //remove ile seçilen product db'den silindi
                productDbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.ToList(); //database ile ilgili methodlara ulaşılabiliyor
            }//using --> bu methodtan çıkıldığı anda bu methodla ilgili alanları hafızadan temizler
        }

        public Product GetProductById(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.Find(id);
                //find methodunu id = primary key olduğu için kullanabildi ancak pk olmasaydı firstordefault kullanılacaktı
            }
        }

        public Product GetProductByName(string name)
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }
    }
}
