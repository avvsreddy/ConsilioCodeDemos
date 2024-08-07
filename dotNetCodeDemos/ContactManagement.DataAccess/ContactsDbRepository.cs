using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactManagement.DataAccess
{
    public class ContactsDbRepository : IContactsRepository
    {
        public void Create(Contact contact)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContactsDB;Integrated Security=True";
            conn.Open();

            string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Mobile}','{contact.Email}','{contact.Location}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            //Console.WriteLine("Contact inserted");
            // logout - close the connection
            conn.Close();
            //Console.WriteLine("db connection closed");
        }

        public void Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
