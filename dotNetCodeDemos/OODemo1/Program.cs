using System.Diagnostics;

namespace OODemo1
{
    internal class Program
    {

        //Person p1 = new Person(); // HAS-A - Aggrigation
        static void Main(string[] args)
        {
            //Product p1 = new ();
            //p1.ProductId = 1;
            //p1.ProductName = "IPhone";
            //p1.ProductDescription = "Description";
            //p1.Price = 99999;

            var p2 = new  
            { 
                ProductId=2,
                ProductName= "Iphone 16", 
                ProductDescription="costly product", 
                Price=99999 
            };

            var p3 = new 
            {
                ProductId= 3, 
                ProductName="Galaxy S24" 
            };

            var p4 = new  
            { 
                ProductId=4, 
                Price=789089 
            };
            //p4.Price = 234;
        }
    }

    class Person 
    {
        
        int age;

        //public void SetAge(int age)
        //{ 
        //    if(age > 0)
        //        this.age = age;
        //    else
        //        this.age = 1;
        //}
        //public int GetAge() 
        //{ 
        //    return age; 
        //}


        public int Age 
        {
            get 
            {
                return age;
            }
            set 
            {
                if (age > 0)
                    this.age = value;
                else
                    this.age = 1;
            }
        }
        //string fname;
        //string lname;
        string _backingfield343423423;
        public string Name // automatic properties
        {
            get { return _backingfield343423423; } 
            set { _backingfield343423423 = value; }
        }
    }



    //class Product
    //{
    //    public int ProductId { get; set; }
    //    public int Price { get;  set; }
    //    public string ProductName { get; set; }
    //    public string ProductDescription { get; set; }
    //    public string ProductCategory { get; set; }
       

    //    //public Product()
    //    //{
            
    //    //}
    //    //public Product(int id,  string name, string desc,int price):this(id,name)
    //    //{
    //    //    //this.ProductId = id;
    //    //    this.Price = price;
    //    //    //this.ProductName = name;
    //    //    this.ProductDescription = desc;
    //    //}

    //    //public Product(int id, string name)
    //    //{
    //    //    this.ProductId = id;
    //    //    this.ProductName= name;
    //    //}
    //}
}
