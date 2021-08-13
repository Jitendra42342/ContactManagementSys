using System.Collections.Generic;
using System.Linq;
using CMS.BusinessLayer.Models;
using CMS.DataAccess;
using CMS.DataAccess.Repository;

namespace CMS.DataAccess.DataManager
{
    public class ContactManager : IDataRepository<Contact>
    {
        readonly ContactContext _ContactContext;

        public ContactManager(ContactContext context)
        {
            _ContactContext = context;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _ContactContext.Contacts.ToList();
        }

        public Contact Get(long id)
        {
            return _ContactContext.Contacts.FirstOrDefault(e => e.ContactId == id);
        }

        public void Add(Contact entity)
        {
            _ContactContext.Contacts.Add(entity);
            _ContactContext.SaveChanges();
        }

        public void Update(Contact Contact, Contact entity)
        {
            Contact.FirstName = entity.FirstName;
            Contact.LastName = entity.LastName;
            Contact.Email = entity.Email;
            Contact.Status = entity.Status;
            Contact.PhoneNumber = entity.PhoneNumber;

            _ContactContext.SaveChanges();
        }

        public void Delete(Contact Contact)
        {
            _ContactContext.Contacts.Remove(Contact);
            _ContactContext.SaveChanges();
        }
    }
}
