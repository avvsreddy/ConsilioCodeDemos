namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memory Management in .Net Apps");

            M1();
            M1();
            M1();


        }

        public static void M1()
        {
            int a = 10;
            string str = "Hello world!";
        }
    }
}
