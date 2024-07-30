
using SimpleCalculator.ClassLibrary;

namespace SimpleCalculator.ConsoleApp
{
    internal class Program // UI
    {
        static void Main(string[] args) //  SRP
        {
            // accept two ints, find the sum then display

            // step 1: accept two ints
            int fno;
            int sno;
            int sum;

            Console.Write("Enter first number :");
            fno = int.Parse(Console.ReadLine());

            Console.Write("Enter second number :");
            sno = int.Parse(Console.ReadLine());
            // step 2: find the sum
            //sum = fno + sno; // BL
            //Program obj = new Program();
           
           Calculator cal = new Calculator();
            sum = cal.FindSum(fno,sno);
            // step 3: display the result
            Console.WriteLine($"The sum of {fno} and {sno} is {sum}");


            Calculator c1 = new Calculator();
        }

    }
}
