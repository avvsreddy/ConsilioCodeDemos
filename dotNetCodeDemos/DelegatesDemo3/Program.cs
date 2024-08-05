namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            // find the sum of all even numbers
            int sumOfAll = numbers.Sum();

            Func<int, bool> filter = new Func<int, bool>(IsEven);
            int sumOfEvens = numbers.Where(filter).Sum();

            sumOfEvens = numbers.Where(IsEven).Sum();

            sumOfEvens = numbers.Where( x => x % 2 == 0 ).Sum();
        }


        static bool IsEven(int n)
        {  
            return n % 2 == 0; 
        }
    }
}
