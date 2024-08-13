using Microsoft.EntityFrameworkCore;
using ProductsCatalogApp.DataAccess;
using ProductsCatalogApp.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProductsCatalogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // get all products for display
            ProductsDbContext db = new ProductsDbContext();
            var allProducts = db.Products.AsNoTracking().ToList();

            foreach (var product in allProducts) {
                Console.WriteLine(product.Name);
            }



            var productToUpate = GetProductById(1);
            productToUpate.Price = 100000;

            UpdateProduct(productToUpate);
            Console.WriteLine("Updated...");
        }

        public static Product GetProductById(int id)
        {
            ProductsDbContext db = new ProductsDbContext();
            return db.Products.Find(id);
        }

        public static void UpdateProduct(Product product) 
        {
            ProductsDbContext db = new ProductsDbContext();
            //var oldProduct = db.Products.Find(product.ProductId);
            //?????
            //oldProduct.Price = product.Price;
            //oldProduct.Name = product.Name;
            //db.Entry(product).State = EntityState.Modified;

            //db.Products.Remove(product);

            db.Products.Update(product);
            db.SaveChanges();
        }



        private static void NewProductWithCatagory()
        {
            // Add new product to an existing catagory
            // get the existing catagory
            ProductsDbContext db = new ProductsDbContext();
            var c = db.Catagories.Find(1);
            var p = new Product { Brand = "Apple", Catagory = c, Country = "US", Name = "IMac Pro", Price = 120000 };
            db.Products.Add(p);
            db.SaveChanges();
        }

        private static void NewCatagoryNewProductAdd()
        {
            // create new catagory with new product and save
            var c = new Catagory
            {
                CatagoryName = "Laptops"
            };
            var p = new Product
            {
                Name = "Dell XPS 13",
                Brand = "DELL",
                Catagory = c,
                Country = "India",
                Price = 75000
            };
            // save
            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p);
            db.Catagories.Add(c); // its optional
            db.SaveChanges();
        }

        private static void Update()
        {
            // Update - increase the product 1 price

            // get the product/s you want to update
            ProductsDbContext db = new ProductsDbContext();

            //var prodcutToUpdate = (from p in db.Products
            //                       where p.ProductId == 1
            //                       select p).FirstOrDefault();

            var prodcutToUpdate = db.Products.Find(1);
            prodcutToUpdate.Price = 80000;
            db.SaveChanges();
        }

        private static void Delete()
        {
            // Deleate products by id
            // Get the product/s you want delete
            ProductsDbContext db = new ProductsDbContext();
            var prodcutToDelete = (from p in db.Products
                                   where p.ProductId == 4
                                   select p).FirstOrDefault();
            if (prodcutToDelete != null)
            {
                db.Products.Remove(prodcutToDelete);
                db.SaveChanges();
            }
        }

        private static void Read()
        {
            // Get All products and display
            ProductsDbContext db = new ProductsDbContext();
            // linq to entities
            var allProducts = from p in db.Products
                              select p;

            // display
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.Name);
            }
        }

        private static void Add()
        {
            // Add new product - write oo code
            Product product = new Product { Name = "IPhone 14 Pro Plus", Price = 68000 };
            ProductsDbContext db = new ProductsDbContext();

            db.Products.Add(product);
            db.SaveChanges();
            Console.WriteLine("Saved");
        }
    }
}
