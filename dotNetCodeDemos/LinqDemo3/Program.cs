namespace LinqDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9 };

            var evens = (from number in numbers
                        where number % 2 == 0
                        select number).ToList();


            
            numbers.Add(10);

            foreach (var e in evens) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
