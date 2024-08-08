using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
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
            string dbProvider = ConfigurationManager.ConnectionStrings["default"].ProviderName;
            
           
            DbProviderFactories.RegisterFactory(dbProvider,  SqlClientFactory.Instance);
           
            DbProviderFactory factory = DbProviderFactories.GetFactory(dbProvider);

            IDbConnection conn = factory.CreateConnection();
            string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn.ConnectionString = connStr;
           
            // sql injection
            //string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Mobile}','{contact.Email}','{contact.Location}')";

            string sqlInsert = $"insert into contacts values (@name,@mobile,@email,@loc)";

           

            IDbCommand cmd = conn.CreateCommand();
            IDbDataParameter p1 = cmd.CreateParameter();
            p1.ParameterName = "@name";
            p1.Value = contact.Name;
            cmd.Parameters.Add(p1);

            IDbDataParameter p2 = cmd.CreateParameter();
            p2.ParameterName = "@mobile";
            p2.Value = contact.Mobile;
            cmd.Parameters.Add(p2);

            IDbDataParameter p3= cmd.CreateParameter();
            p3.ParameterName = "@email";
            p3.Value = contact.Email;
            cmd.Parameters.Add(p3);


            IDbDataParameter p4 = cmd.CreateParameter();
            p4.ParameterName = "@loc";
            p4.Value = contact.Location;
            cmd.Parameters.Add(p4);


            //cmd.Parameters.AddWithValue("@mobile", contact.Mobile);
            //cmd.Parameters.AddWithValue("@email",contact.Email);
            //cmd.Parameters.AddWithValue("@loc", contact.Location);

            cmd.CommandText = sqlInsert;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //Console.WriteLine("Contact inserted");
                // logout - close the connection
            }
            //catch(Exception ex)
            finally
            {
                conn.Close();
            }
            //Console.WriteLine("db connection closed");
        }

        public void Delete(int contactId)
        {
            string dbProvider = ConfigurationManager.ConnectionStrings["default"].ProviderName;


            DbProviderFactories.RegisterFactory(dbProvider, SqlClientFactory.Instance);

            DbProviderFactory factory = DbProviderFactories.GetFactory(dbProvider);

            IDbConnection conn = factory.CreateConnection();
            string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn.ConnectionString = connStr;

            // sql injection
            //string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Mobile}','{contact.Email}','{contact.Location}')";

            string sqlDelete = $"delete from contacts where id = @id";



            IDbCommand cmd = conn.CreateCommand();
            IDbDataParameter p1 = cmd.CreateParameter();
            p1.ParameterName = "@id";
            p1.Value = contactId;
            cmd.Parameters.Add(p1);

            


            //cmd.Parameters.AddWithValue("@mobile", contact.Mobile);
            //cmd.Parameters.AddWithValue("@email",contact.Email);
            //cmd.Parameters.AddWithValue("@loc", contact.Location);

            cmd.CommandText = sqlDelete;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //Console.WriteLine("Contact inserted");
                // logout - close the connection
            }
            //catch(Exception ex)
            finally
            {
                conn.Close();
            }
            //Console.WriteLine("db connection closed");
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
            string dbProvider = ConfigurationManager.ConnectionStrings["default"].ProviderName;


            DbProviderFactories.RegisterFactory(dbProvider, SqlClientFactory.Instance);

            DbProviderFactory factory = DbProviderFactories.GetFactory(dbProvider);

            IDbConnection conn = factory.CreateConnection();
            string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn.ConnectionString = connStr;

            // sql injection
            //string sqlInsert = $"insert into contacts values ('{contact.Name}','{contact.Mobile}','{contact.Email}','{contact.Location}')";

            string sqlUpdate = $"update contacts set name = @name, email = @email, mobile=@mobile, location=@loc where id=@id";



            IDbCommand cmd = conn.CreateCommand();
            IDbDataParameter p1 = cmd.CreateParameter();
            p1.ParameterName = "@name";
            p1.Value = contact.Name;
            cmd.Parameters.Add(p1);

            IDbDataParameter p2 = cmd.CreateParameter();
            p2.ParameterName = "@mobile";
            p2.Value = contact.Mobile;
            cmd.Parameters.Add(p2);

            IDbDataParameter p3 = cmd.CreateParameter();
            p3.ParameterName = "@email";
            p3.Value = contact.Email;
            cmd.Parameters.Add(p3);


            IDbDataParameter p4 = cmd.CreateParameter();
            p4.ParameterName = "@loc";
            p4.Value = contact.Location;
            cmd.Parameters.Add(p4);

            IDbDataParameter p5 = cmd.CreateParameter();
            p4.ParameterName = "@id";
            p4.Value = contact.Id;
            cmd.Parameters.Add(p5);


            //cmd.Parameters.AddWithValue("@mobile", contact.Mobile);
            //cmd.Parameters.AddWithValue("@email",contact.Email);
            //cmd.Parameters.AddWithValue("@loc", contact.Location);

            cmd.CommandText = sqlUpdate;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //Console.WriteLine("Contact inserted");
                // logout - close the connection
            }
            //catch(Exception ex)
            finally
            {
                conn.Close();
            }
        }
    }
}
