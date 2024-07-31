namespace IDELab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();
            ide.Languages.Add(new LangC());
            ide.Languages.Add(new LangCSharp());
            ide.Work();

        }
    }

    class IDE
    {
        //private LangC c = new LangC();
        //private LangCSharp cs = new LangCSharp();
        //private LangJava java = new LangJava();

        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

        public void Work()
        {
            foreach (ILanguage language in Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
            }

            //Console.WriteLine(c.GetName());
            //Console.WriteLine(c.GetUnit());
            //Console.WriteLine(c.GetParadigm());
            //Console.WriteLine("---------------------");
            //Console.WriteLine(cs.GetName());
            //Console.WriteLine(cs.GetUnit());
            //Console.WriteLine(cs.GetParadigm());
            //Console.WriteLine("---------------------");
            //Console.WriteLine(java.GetName());
            //Console.WriteLine(java.GetUnit());
            //Console.WriteLine(java.GetParadigm());

        }
    }


    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }

    abstract class OOLanguage : ILanguage 
    {
        public string GetUnit() { return "Class"; }
        public string GetParadigm() { return "Object Oriented"; }

        abstract public string GetName();
       
    }

    abstract class Procedural : ILanguage
    {
        public string GetUnit() { return "Function"; }
        public string GetParadigm() { return "Procedural"; }

        abstract public string GetName();
        
    }

    class LangCSharp : OOLanguage
    {
      
        public override string GetName() { return "CSharp"; }

    }

    class LangJava : OOLanguage
    {
       
        public override string GetName() { return "Java"; }
    }

    class LangC : Procedural
    {
      
        public override string GetName() { return "C Language"; }
    }
}
