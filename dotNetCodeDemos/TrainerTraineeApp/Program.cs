using System.Net.Http.Headers;

namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
            //return Trainer.Organization.Name;
            return Trainees[0].Trainer.Organization.Name;
        }
        public int GetTrainingDuration() 
        { 
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
