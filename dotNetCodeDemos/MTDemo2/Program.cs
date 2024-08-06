using System.Diagnostics;

namespace MTDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Seq...");
            Stopwatch sw = Stopwatch.StartNew();
            M1();
            M2();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();

            Console.WriteLine("Running Paralle...");
            sw.Restart();
            Parallel.Invoke(M1,M2 );
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            sw.Restart();
            Console.WriteLine("Running Parallel Loop...");
            Parallel.Invoke(M11,M22 );
            Console.WriteLine(sw.ElapsedMilliseconds);

        }


        public static void M1()
        {
            //Console.WriteLine($"M1 running in thread id {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 10; i++) 
            {
                Thread.Sleep(1000);
            }
        }

        public static void M2()
        {
            //Console.WriteLine($"M2 running in thread id {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
            }
        }

        public static void M11()
        {
            //Console.WriteLine($"M1 running in thread id {Thread.CurrentThread.ManagedThreadId}");
            //for (int i = 1; i <= 10; i++)
            ParallelOptions options = new ParallelOptions();
            var pcount = Environment.ProcessorCount/2;
            options.MaxDegreeOfParallelism = pcount;
            Parallel.For(1, 11,options, i => 
            { 
                Thread.Sleep(1000);
            });
            
        }

        public static void M22()
        {
            //Console.WriteLine($"M2 running in thread id {Thread.CurrentThread.ManagedThreadId}");
            //for (int i = 1; i <= 10; i++)
            ParallelOptions options = new ParallelOptions();
            var pcount = Environment.ProcessorCount / 2;
            options.MaxDegreeOfParallelism = pcount;
            Parallel.For(1, 11,options, i =>
            {
                Thread.Sleep(1000);
            });
        }
    }
}
