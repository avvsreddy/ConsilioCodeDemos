using System.Net.Http.Headers;

namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Training training = new Training();
            Trainer trainer = new Trainer();
            training.Trainer = trainer;
            Organization org = new Organization();
            org.Name = "Pratian";
            trainer.Organization = org;

            Console.WriteLine($"Training Org Name : {training.GetTrainingOrgName()}");
          
            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();
            Trainee t4 = new Trainee();
            Trainee t5 = new Trainee();
            Trainee t6 = new Trainee();

            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);
            training.Trainees.Add(t4);
            training.Trainees.Add(t5);
            training.Trainees.Add(t6);

            Console.WriteLine($"Trainees Count {training.GetTraineesCount()}");

            Course course = new Course();
            training.Course = course;

            Module m1 = new Module();
            Module m2 = new Module();
            course.Modules.Add(m1);
            course.Modules.Add(m2);

            Unit u1 = new Unit { Duration = 40 };
            Unit u2 = new Unit { Duration = 20 }; 
            Unit u3 = new Unit { Duration = 60 }; 
            
            m1.Units.Add(u1);
            m1.Units.Add(u2);
            m2.Units.Add(u3);

            Console.WriteLine($"Training Duration : {training.GetTrainingDuration()}");

        }
    }

    class Organization 
    {
        public string Name { get; set; }
    }
    class Trainer
    {
        //public Organization org = new Organization();
        public Organization Organization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
    class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
    class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course Course { get; set; }

        public string GetTrainingOrgName() 
        {
            return Trainer.Organization.Name;
            //return Trainees[0].Trainer.Organization.Name;
        }
        public int GetTrainingDuration() 
        {
            int totDuration = 0;
            // for each module in a course
            foreach(Module module in Course.Modules)
            {
                // for each unit in a module
                foreach (Unit unit in module.Units)
                {
                    totDuration += unit.Duration;
                }
            }
            return totDuration;
        }

        public int GetTraineesCount() 
        { 
            return Trainees.Count;
        }





    }
    class Course
    {
        public List<Module> Modules { get; set; } = new List<Module>();
    }
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
    class Unit
    {
        public int Duration { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {
        public string  Name { get; set; }
    }
}
