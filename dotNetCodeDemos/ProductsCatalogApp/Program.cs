using ProductsCatalogApp.DataAccess;
using ProductsCatalogApp.Entities;

namespace ProductsCatalogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage Products (CRUD)
            Read();
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
