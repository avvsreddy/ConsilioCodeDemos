namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Test
    {

    }

    public interface ITest
    {
        public int TestId { get; set; }
        public Test Test { get; set; }
    }

    public class ClsTest : ITest
    {
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
