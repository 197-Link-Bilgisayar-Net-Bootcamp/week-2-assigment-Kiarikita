using Microsoft.AspNetCore.Mvc;
using ProductFinder.Business.Abstract;
using ProductFinder.Entities;

namespace ProductFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        //dependency injection
        private IProductService _productService;
        
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        ///<summary>
        /// Tüm Productları Listeler
        /// </summary>
        /// <returns>List of Product döndürür.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var products =  _productService.GetAllProducts();
            return Ok(products); // StatusCode = 200 ve products(data) dönecek
        }

        /// <summary>
        /// Seçili Productı Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("[action]/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                return Ok(product); //200
            }

            return NotFound(); //404
        }

        [HttpGet()]
        [Route("[action]/{name}")]
        public IActionResult GetProductByName(string name)
        {
            var product = _productService.GetProductByName(name);
            return Ok(product);

        }

        /// <summary>
        /// Product Ekler
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost()]
        public IActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                var model =  _productService.CreateProduct(product);
                return CreatedAtAction("Get", new { id = model.Id }, model);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        /// <summary>
        /// Productı Günceller
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut()]
        public IActionResult Put(Product product)
        {
            if (_productService.GetProductById(product.Id) != null)
            {
                return Ok(_productService.UpdateProduct(product));
            }

            return NotFound();
        }

        /// <summary>
        /// Productı Siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_productService.GetProductById(id) != null)
            {
                _productService.DeleteProduct(id);
                return Ok();
            }

            return NotFound();

        }
    }
}
