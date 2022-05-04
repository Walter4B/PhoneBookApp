using PhoneBookApp.Models;

namespace PhoneBookApp
{
    internal class DatabaseController
    {
        TableDisplayEngine tableDisplayEngine = new TableDisplayEngine();
        OutputEngine outputController = new OutputEngine();
        InputEngine inputController = new InputEngine();

        internal void AddEntryToDatabase()
        {
            outputController.DisplayMessage("InputName");
            string name = inputController.GetInputString();
            outputController.DisplayMessage("InputNumber");
            string phoneNumber = inputController.GetInputPhoneNumber();
            using (var context = new PhoneBookContext())
            {
                var contact = new Contact()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                };

                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }

        internal void UpdateEntryInDatabase()
        {
            outputController.DisplayMessage("UpdateChooseID");
            int id = inputController.GetInputInt();
            outputController.DisplayMessage("InputName");
            string name = inputController.GetInputString();
            outputController.DisplayMessage("InputNumber");
            string number = inputController.GetInputPhoneNumber();
            using (var context = new PhoneBookContext())
            {
                Contact contact = null;
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
            List<Contact> listOfContacts = new List<Contact>();
            string[] columnNames = new string[] { };

            using (var context = new PhoneBookContext())
            {
                var contact = context.Contacts.OrderBy(b => b.Id);

                listOfContacts = contact.ToList();
            }

            columnNames = typeof(Contact).GetProperties()
                                                .Select(p => p.Name)
                                                .ToArray();

            tableDisplayEngine.DisplayPhoneBook(listOfContacts, columnNames);
        }

        internal void RemoveEntryFromDatabase()
        {
            outputController.DisplayMessage("DeleteContact");
            int id = inputController.GetInputInt();
            using (var context = new PhoneBookContext())
            {
                var contact = context.Contacts.Where(b => b.Id == id).FirstOrDefault();
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
        }
    }
}
