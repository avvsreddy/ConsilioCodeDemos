namespace OODemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DieselEngine de = new DieselEngine();
            // de.Start();
            // de.Stop();

            // PetrolEngine petrol = new PetrolEngine();
            // petrol.Start();
            // petrol.Stop();




            HybridEngine he = new HybridEngine();
            he.engines.Add(new PetrolEngine());
            //he.engines.Add(new DieselEngine());
            he.engines.Add(new GasEngine());
            he.Start();
            he.Stop();
                
        }
    }

    interface IEngine
    {
        void Start();
        void Stop();
    }

    //abstract class Engine
    //{
    //    abstract public void Start();
    //    abstract public void Stop();
    //}


    //class H2O : Engine
    //{
    //    public override void Start()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void Stop()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Diesel Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Diesel Engine");
        }
    }

    class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Petrol Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Petrol Engine");
        }
    }

    class HybridEngine
    {
        //public DieselEngine DieselEngine { get; set; } = new DieselEngine();
        //public PetrolEngine PetrolEngine { get; set; } = new PetrolEngine();
        //private DieselEngine dEng= new DieselEngine();
        //private PetrolEngine pEng= new PetrolEngine();
        //private GasEngine gsEng= new GasEngine();

        public List<IEngine> engines { get; set; } = new List<IEngine>();

        public void Start() 
        {
            //dEng.Start();
            //pEng.Start();
            //gsEng.Start();
            foreach (var engine in engines) 
            { 
                engine.Start();
            }
        }
        public void Stop() 
        {
            //dEng.Stop();
            //pEng.Stop();
            //gsEng.Stop();
            foreach (var engine in engines)
            {
                engine.Stop();
            }
        }
    }



    class GasEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Gas Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping Gas Engine");
        }
    }
}
