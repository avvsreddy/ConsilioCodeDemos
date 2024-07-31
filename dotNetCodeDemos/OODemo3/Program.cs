namespace OODemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engine engine = new Engine();
            //engine.Start();
            //engine.Stop();

            //DieselEngine engine = new DieselEngine();
            //engine.Start();
            //engine.Stop();

            //PetrolEngine engine = new PetrolEngine();
            //engine.Start();
            //engine.Stop();

            // Base class reference variable can hold derived class objects

            //Engine engine = new DieselEngine();
            //engine.Start();
            //engine.Stop();


            //DriveVehicle(new Engine());
            //DriveVehicle(new DieselEngine());
            DriveVehicle(new PetrolEngine());


        }
        static void DriveVehicle(Engine e)
        {
            e.Start();
            e.Stop();
        }
    }

    class Engine
    {
        public virtual void Start() 
        {
            Console.WriteLine("Stratging an Engine");
        }
        public virtual void Stop() 
        {
            Console.WriteLine("Stoping an Engine");
        }
    }

    class DieselEngine : Engine
    {
         override public void Start()
        {
            Console.WriteLine("Stratging a Diesel Engine");
        }
        public override void Stop()
        {
            Console.WriteLine("Stoping a Diesel Engine");
        }
    }

    class PetrolEngine : Engine
    {
        override public void Start()
        {
            Console.WriteLine("Stratging a Petrol Engine");
        }
        public override void Stop()
        {
            Console.WriteLine("Stoping a Petrol Engine");
        }
    }
}
