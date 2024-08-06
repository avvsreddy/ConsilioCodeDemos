namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3,4,5,6,7,8,9 };
            // select all even numbers into another array and display
            //List<int> evens = new List<int>();
            //foreach (int i in numbers)
            //{
            //    if(i % 2 == 0)
            //        evens.Add(i);
            //}

            var evens = from n in numbers
                        where n % 2 == 0
                        select n;

            evens = numbers.Where(n => n % 2 == 0).Select(x => x);

            foreach (int i in evens) { Console.WriteLine(i); }

            //table : numbers
            // col : number
            //sql: select number from numbers where number mod 2 = 0
        }
    }
}
