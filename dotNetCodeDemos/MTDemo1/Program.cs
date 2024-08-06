namespace MTDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //M1();
            //M2();

            //Task t1 = new Task(M1);
            //Thread t1= new Thread(M1);
            //t1.Start();

            //Task t2 = new Task(M2);
            //Thread t2= new Thread(M2);
            //t2.Start();

            //t1.Wait();
            //t1.Join();
            //t2.Wait();
            //t2.Join();

            Parallel.Invoke(M1, M2);
            //kjjkjk
        }

        static void M1()
        {
            for (int i = 1; i < 1000; i++) { Console.WriteLine($"M1:{i}"); }
        }

        static void M2()
        {
            for (int i = 1; i < 1000; i++) { Console.WriteLine($"\tM2:{i}"); }
        }
    }
}
