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
    }
}
