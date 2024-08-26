using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
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




        // GET.../api/products/odata

        [HttpGet]
        [EnableQuery]
        [Route("odata")]
        public IQueryable<Product> GetAll()
        {
            return db.Products.AsQueryable();
        }


        #region other end points

        // GET...api/products/async
        [HttpGet]
        [Route("async")]
        public async Task<List<Product>> GetAllAsync()
        {
            return await db.Products.ToListAsync();
            //dsddgfds
            //sdfdsfdsf
        }


        //// GET .../api/products/123
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var product = await db.Products.FindAsync(id);
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

        //// get all products by category
        //// design the URL
        //// GET .../api/products/mobiles
        //[HttpGet]
        //[Route("{category:alpha}")]
        //public IActionResult GetByCategory(string category)
        //{
        //    var products = from p in db.Products
        //                   where p.Category == category
        //                   select p;
        //    if (products.Count() == 0) 
        //    {
        //        return NotFound();
        //    }
        //    return Ok(products.ToList());
        //}

        //// Get all products by country
        //// GET .../api/products/country/India
        //[HttpGet]
        //[Route("country/{country:alpha}")]
        //[ProducesResponseType<Product>(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public IActionResult GetByCountry(string country)
        //{
        //    var products = from p in db.Products
        //                   where p.Country == country
        //                   select p;
        //    if (products.Count() == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(products.ToList());
        //}

        //1. Get all products in stock
        //2. get all products out of stock
        //3. get product by name
        //4. get costliest product
        //5. get cheapest product
        //6. get product price between min and max cost
        //7. get products by brand
        #endregion

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType<Product>(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // .../api/products
        public async Task<IActionResult> AddAsync(Product product)
        {
            // validate
            if (!ModelState.IsValid) 
            { 
                return BadRequest(ModelState);
            }
            db.Products.Add(product);
            await db.SaveChangesAsync();
            // return 201 with location and data
            //return Ok();
            return Created($"/api/products/{product.ProductId}",product);
        }

        [HttpDelete]
        [ProducesResponseType<Product>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // .../api/products/1
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var product = await db.Products.FindAsync(id);
            if (product == null) 
            {
                return NotFound();
            }
            db.Products.Remove(product);
           await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // .../api/products/1
        public async Task<IActionResult> PutAsync([FromQuery] int id, [FromBody] Product product) 
        {
            // find the product
            var p = await db.Products.FindAsync(id);
            if (p == null)
            {
                return NotFound();
            }
            // validate
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Automappers
            
            p.Name = product.Name;
            p.Price = product.Price;
            p.Description = product.Description;
            p.Category = product.Category;
            p.Country = product.Country;
            p.IsAvailable = product.IsAvailable;


            //db.Products.Update(product);
            //db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();

        }

        
    }
}
