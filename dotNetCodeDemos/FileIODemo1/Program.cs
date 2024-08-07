namespace FileIODemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var drives = DriveInfo.GetDrives();
            foreach (var drive in drives) 
            {
                Console.WriteLine(drive.Name);
            }

           var files = Directory.GetFiles("C:\\");
            foreach (var file in files) 
            {
                Console.WriteLine(file);
            }
        }

        private static void Read()
        {
            // read all data from file

            StreamReader sr = new StreamReader("..\\..\\..\\program.cs");  // file must exist
            //string allLines = sr.ReadToEnd();
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();
        }

        private static void Write()
        {
            // store some data into file

            string data;
            Console.Write("Enter some data :");
            data = Console.ReadLine();

            StreamWriter sw = new StreamWriter("test.txt", true);
            try
            {
                sw.WriteLine(data);
                //lhlhl
                //llkllk
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { sw.Close(); }
        }
    }
}
