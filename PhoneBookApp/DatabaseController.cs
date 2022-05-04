using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class DatabaseController
    {
        internal void AddEntryToDatabase(string name, string phoneNumber)
        {
            using (var context = new Models.PhoneBookContext())
            {
                var contact = new Models.Contact()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                };

                context.Contacts.Add(contact);
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
        }

        internal void RemoveEntryFromDatabase()
        { 
            
        }

        internal void ListAllEntries()
        { 
        
        }


    }
}
