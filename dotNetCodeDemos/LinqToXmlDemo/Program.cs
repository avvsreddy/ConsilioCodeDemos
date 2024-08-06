using System.Diagnostics;
using System.Xml.Linq;

namespace LinqToXmlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // load xml doc
            XDocument xml = XDocument.Load("XMLfile1.xml");

            // get all title of the books and display
            var allTitles = from title in xml.Descendants("title")
                            select title.Value;

            //foreach (var title in allTitles) { Console.WriteLine(title); }

            // get first 3 titles and display
            var first3Titles = from title in xml.Descendants("title").Skip(2).Take(3)
                               select title.Value;
            //foreach (var title in first3Titles) { Console.WriteLine(title); }


            var firstonly = (from title in xml.Descendants("title")
                               select title.Value).FirstOrDefault();

            // get all titles belongs to computer

            var computerBooks = from book in xml.Descendants("book")
                                where book?.Element("genre")?.Value == "Computer"
                                select new  
                                {
                                    Title= book?.Element("title")?.Value, 
                                    Author=book?.Element("author")?.Value 
                                };

            //foreach (var book in computerBooks) { Console.WriteLine(book); }


            var plist = from p in Process.GetProcesses()
                        select new 
                        {
                            Name=p.ProcessName, 
                            Memory = p.WorkingSet64 
                        };


            XElement element = new XElement("Processes",
                from p in Process.GetProcesses() 
                select new XElement("Process", 
                    new XElement("Name", p.ProcessName), 
                    new XElement("Memory",p.WorkingSet64)));


            element.Save("processlist.xml");
            //foreach (var proc in plist) 
            //{
            //    Console.WriteLine($"{proc.Name}\t{proc.Memory}");
            //}
            /*
             * <Processes>
             *      <Process>
             *          <Name>abcd</Name>
             *          <Memory>334353454</Memory>
             *      </Process>
             *      ...
             *  </Processes>
             *  
             */

        }
    }



    //class TitleAndAuthor
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //}
}
