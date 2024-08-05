using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Dev 1 - all process
            //ProcessManager.ShowProcessList(NoFilter);
            ProcessManager.ShowProcessList( p => true);
            // Client dev 2 -  get all the prcess name starts with S
            //ProcessManager.ShowProcessList();
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //ProcessManager.ShowProcessList(filter);

            // Client 3 - memory size

            //ProcessManager.ShowProcessList(FilterByMemSize);

            // Anonymous Delegates
            ProcessManager.ShowProcessList( 
                delegate (Process p) {
                return p.WorkingSet64 >= 50 * 1024 * 1024;
                });

            // Lambda Expression - light weight syntax for anonymous delegates
            // Lambda Expressions
            
            // Lambda statements
            ProcessManager.ShowProcessList(
                (Process p) => {
                   return p.WorkingSet64 >= 50 * 1024 * 1024;
               });


            // Lambda expression 1
            ProcessManager.ShowProcessList(
                (Process p) => 
                     p.WorkingSet64 >= 50 * 1024 * 1024
                );

            // Lambda expression 2
            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 50 * 1024 * 1024);


        }

        // client 1
        public static bool NoFilter(Process process) { return true; }
       
        // client 2
        public static bool FilterByName(Process p)
        {
            if (p.ProcessName.StartsWith("S"))
                return true;
            return false;
        }

        // client 3
        //public static bool FilterByMemSize(Process p)
        //{
        //    return p.WorkingSet64 >= 50 * 1024 * 1024;
        //}



    }
    // Backend developer


    // declare the delegate

    public delegate bool FilterDelegate(Process p);
    class ProcessManager
    {
        public static void ShowProcessList(FilterDelegate filter)
        {
            // display all running process names
            foreach (var p in Process.GetProcesses())
            {
                if (filter(p)) // delegate invocation
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}