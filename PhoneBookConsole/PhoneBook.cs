using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    internal class PhoneBook
    {
        private List<Contact> _contacts { get; set; }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        // Method displays contact details for each contact
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}: {contact.Number}");
        }

        // Display contact based on name searched
        public void SearchByName(string name)
        {
            var contact = _contacts.FirstOrDefault(c => c.Name == name);
            if(contact != null)
            {
                DisplayContactDetails(contact);
            } 
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        // Display contact based on number searched
        public void SearchByNumber(string number)
        {
            var contact =  _contacts.FirstOrDefault(c => c.Number == number);
            if(contact != null)
            {
                DisplayContactDetails(contact);
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        
    }
}
