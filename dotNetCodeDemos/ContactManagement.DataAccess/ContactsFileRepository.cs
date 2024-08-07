using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.DataAccess
{
    public class ContactsFileRepository : IContactsRepository
    {
        public void Create(Contact contact)
        {
            throw new NotImplementedException();
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
