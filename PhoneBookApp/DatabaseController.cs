using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Internal;

namespace PhoneBookApp
{
    internal class DatabaseController
    {
        TableDisplayEngine tableDisplayEngine = new TableDisplayEngine();
        OutputController outputController = new OutputController();
        InputController inputController = new InputController();

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
                context.SaveChanges();
            }
        }

        internal void UpdateEntryInDatabase(int id, string name, string number)
        {
            using (var context = new Models.PhoneBookContext())
            {
                Models.Contact contact = null;
                while (contact == null)
                {
                    contact = context.Contacts.Where(b => b.Id == id).FirstOrDefault();
                    if (contact == null)
                    {
                        outputController.DisplayMessage("UpdateNoID");
                        id = inputController.GetInputInt();
                    }
                    else
                    {
                        contact.Name = name;
                        contact.PhoneNumber = number;
                    }
                }
                context.SaveChanges();
            }
        }

        internal void DisplayAllEntries()
        {
            List<Models.Contact> listOfContacts = new List<Models.Contact>();
            string[] columnNames = new string[] { };

            using (var context = new Models.PhoneBookContext())
            {
                var contact = context.Contacts.OrderBy(b => b.Id);

                listOfContacts = contact.ToList();
            }

            columnNames = typeof(Models.Contact).GetProperties()
                                                .Select(p => p.Name)
                                                .ToArray();

            tableDisplayEngine.DisplayPhoneBook(listOfContacts, columnNames);
        }

        internal void RemoveEntryFromDatabase(int id)
        {
            using (var context = new Models.PhoneBookContext())
            {
                var contact = context.Contacts.Where(b => b.Id == id).FirstOrDefault();
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
        }
    }
}
