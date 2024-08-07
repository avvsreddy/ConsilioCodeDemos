

using ContactManagement.DataAccess;
using System.Data.SqlClient;

namespace ContactsManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // manage (CRUD) contact details

            // insert contact details into sql database

            // Create database - manual - done
            // Create table - manual - done

            // with code - connected approach
            // login to database - open connection with database

         
            // prepare and send sql insert statement
            Contact c = new Contact();
            Console.Write("Enter Contact Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Location: ");
            c.Location = Console.ReadLine();

            IContactsRepository repo = new ContactsDbRepository();
            repo.Create(c);
            Console.WriteLine("Created");






        }
    }
}
