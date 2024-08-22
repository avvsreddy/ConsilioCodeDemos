using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsCatalogService.API.Model.Data;
using ProductsCatalogService.API.Model.Entities;

namespace ProductsCatalogService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext db;

        public ProductsController(ProductsDbContext _db)
        {
            db = _db;
        }


        // Design the endpoint uri
        // GET.../api/products

        [HttpGet]
       
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }


        // GET .../api/products/123
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id) 
        {
            var product = db.Products.Find(id);
            if (product == null) 
            {
                // return 404 - not found
                return NotFound();
            }
            else
            {
                // return 200 - ok with data
                return Ok(product);
            }
        }

        // get all products by category
        // design the URL
        // GET .../api/products/mobiles
        [HttpGet]
        [Route("{category:alpha}")]
        public IActionResult GetByCategory(string category)
        {
            var products = from p in db.Products
                           where p.Category == category
                           select p;
            if (products.Count() == 0) 
            {
                return NotFound();
            }
            return Ok(products.ToList());
        }

        // Get all products by country
        // GET .../api/products/country/India
        [HttpGet]
        [Route("country/{country:alpha}")]
        public IActionResult GetByCountry(string country)
        {
            var products = from p in db.Products
                           where p.Country == country
                           select p;
            if (products.Count() == 0)
            {
                return NotFound();
            }
            return Ok(products.ToList());
        }

        //1. Get all products in stock
        //2. get all products out of stock
        //3. get product by name
        //4. get costliest product
        //5. get cheapest product
        //6. get product price between min and max cost
        //7. get products by brand

    }
}
