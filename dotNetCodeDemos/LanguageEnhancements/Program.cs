namespace LanguageEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Local variable type inference - var
            var a =90;
            var str = "hello";
            //2. Object initialization syntax
            var p = new  { FirstName = "name1", Age = 23 };
            //3 Anonymous Objects
            //4. Extension Methods

            string data = "Some confidential data";
            Console.WriteLine(data.ToUpper());
            data.Encrypt();
            data.Encrypt();
            string encData = SimpleEncryption.Encrypt(data);
            int x = 10;
            x.Encrypt();
            Program program = new Program();
            //program.

        }
    }

      static class SimpleEncryption //: String
    {
        public static string Encrypt(this Object data) 
        {
            return "@#$#$@#RFDFSDFSER@#%@#%@$%@$%SDGDFGFDG@#%@#%";
        }
        //public static string Encrypt(this int data)
        //{
        //    return "@#$#$@#RFDFSDFSER@#%@#%@$%@$%SDGDFGFDG@#%@#%";
        //}
    }

    //class Person
    //{
    //    public string FirstName { get; set; }
    //    public int Age { get; set; }
    //}
}
