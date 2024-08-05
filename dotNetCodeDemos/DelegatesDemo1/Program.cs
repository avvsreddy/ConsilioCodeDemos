namespace DelegatesDemo1
{


    //class MyDelegate : MulticastDelegate
    //{

    //}


    // Step 1: Declare a delegate - 

    delegate void MyDelegate(string str);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Direct Method Invocation
            //Greetings("Direct!");
            // Indirect method invocation - using delegates
            //Delegate d = new Delegate();

            // Step 2: Instatiate and Intialize it
            Program p = new Program();
            MyDelegate d = new MyDelegate(Greetings);
           
            d += p.Hello;  // Subscription
            d -= Greetings; // unsubscription

            //d += Hi;
            //MyDelegate d1 = new MyDelegate(d);
            // invocation of delegate
            // Step 3: 
            //d.Invoke("Indirect");
            d("Other way...");
        }

        static void Greetings(string msg)
        {
            Console.WriteLine($"Greetings: {msg}");
        }

        void Hello(string msg) 
        { 
            Console.WriteLine($"Hello {msg}"); 
        }

        static void Hi()
        {

        }
    }
}
