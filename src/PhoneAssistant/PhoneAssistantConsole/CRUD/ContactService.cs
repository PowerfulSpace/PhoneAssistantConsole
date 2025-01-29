using PhoneAssistantConsole.Context;
using PhoneAssistantConsole.Entities;

namespace PhoneAssistantConsole.CRUD
{
    public class ContactService
    {
        public void AddContact(string name, string phoneNumber, string email)
        {
            using var db = new PhoneBookContext();
            var contact = new Contact { Name = name, PhoneNumber = phoneNumber};
            db.Contacts.Add(contact);
            db.SaveChanges();
            Console.WriteLine("Контакт успешно добавлен.");
        }

        public void DeleteContact(int id)
        {
            using var db = new PhoneBookContext();
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
                Console.WriteLine("Контакт успешно удалён.");
            }
            else
            {
                Console.WriteLine("Контакт с указанным Id не найден.");
            }
        }

        public void UpdateContact(int id, string newName, string newPhoneNumber, string newEmail)
        {
            using var db = new PhoneBookContext();
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                contact.Name = newName;
                contact.PhoneNumber = newPhoneNumber;
                db.SaveChanges();
                Console.WriteLine("Контакт успешно обновлён.");
            }
            else
            {
                Console.WriteLine("Контакт с указанным Id не найден.");
            }
        }

        public List<Contact> SearchContacts(string query)
        {
            using var db = new PhoneBookContext();
            return db.Contacts
                     .Where(c => c.Name.Contains(query))
                     .ToList();
        }

        public List<Contact> GetAllContacts()
        {
            using var db = new PhoneBookContext();
            return db.Contacts.ToList();
        }
    }
}
