namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {23,5,23,6,7,45,78,68,34 };


            // sql select : select number from numbers where number mod 2 = 0 order by number desc

            // linq expressions (keywords)
            var evens1 = from number in list 
                         where number % 2 == 0 
                         orderby number descending
                         select number;

            // linq with (extension methods with lambda expression)
            var evens2 = list.Where(n =>  n % 2 == 0).OrderByDescending(x=>x);

            foreach (var e in evens1)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------");
            foreach (var e in evens2)
            {
                Console.WriteLine(e);
            }
        }
    }
}
