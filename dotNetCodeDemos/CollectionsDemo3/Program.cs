namespace CollectionsDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Product> products = new List<Product>();
            Product product = new Product { Id = 111, Name = "IPhone", Price = 99999 };
            products.Add(product);
            products.Add(new Product { Id = 222, Name = "Product 2", Price = 89999 });

            products.Add(new Product { Id = 333, Name = "Product 3", Price = 56666 });
            products.Add(new Product { Id = 456, Name = "Product 4", Price = 56444 });

            products.Sort(new ProductNameComparer());

            //IComparable

            foreach (var item in products)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine("----------");

            }
            // stack
            Stack<int> stack = new Stack<int>();
            // add
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int x = stack.Pop();
            x=stack.Peek();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            x = queue.Dequeue();
            x =queue.Peek();

            Dictionary<int,string> result = new Dictionary<int,string>();
            result[123] = "Pass";
            result[234] = "Pass";
            result[768] = "Fail";
            result[128] = "Pass";

            Console.WriteLine(result[123]);



        }
    }

    class Product// : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //public int CompareTo(Product? other)
        //{
        //    if(this.Price > other.Price) return -1;
        //    else return 1;
        //}
    }


    class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Price > y.Price) return -1;
            else return 1;
        }
    }

    class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Name.CompareTo(y.Name) > 1) return -1;
            else return 1;
        }
    }
}
