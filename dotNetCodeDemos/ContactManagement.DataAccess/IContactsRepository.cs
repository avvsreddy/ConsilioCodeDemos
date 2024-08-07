using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.DataAccess
{
    public interface IContactsRepository
    {

        void Create(Contact contact);
        void Delete(int contactId);
        void Update(Contact contact);
        List<Contact> GetAll();
        Contact GetById(int id);
        List<Contact> GetByLocation(string location);


    }
}
