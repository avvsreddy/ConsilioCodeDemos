namespace IDELab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();
            ide.Work();

        }
    }

    class IDE
    {
        private LangC c = new LangC();
        private LangCSharp cs = new LangCSharp();
        private LangJava java = new LangJava();

        public void Work()
        {
            Console.WriteLine(c.GetName());
            Console.WriteLine(c.GetUnit());
            Console.WriteLine(c.GetParadigm());
            Console.WriteLine("---------------------");
            Console.WriteLine(cs.GetName());
            Console.WriteLine(cs.GetUnit());
            Console.WriteLine(cs.GetParadigm());
            Console.WriteLine("---------------------");
            Console.WriteLine(java.GetName());
            Console.WriteLine(java.GetUnit());
            Console.WriteLine(java.GetParadigm());
            
        }
    }

    class LangCSharp
    {
        public string GetUnit() { return "Class"; }
        public string GetParadigm() { return "Object Oriented"; }
        public string GetName() { return "CSharp"; }

    }

    class LangJava
    {
        public string GetUnit() { return "Class"; }
        public string GetParadigm() { return "Object Oriented"; }
        public string GetName() { return "Java"; }
    }

    class LangC
    {
        public string GetUnit() { return "Function"; }
        public string GetParadigm() { return "Procedural"; }
        public string GetName() { return "C Language"; }
    }
}
