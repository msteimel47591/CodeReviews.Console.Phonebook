using PhoneBook.Models;

namespace PhoneBook.Control;
internal class ContactService
{
    internal static void AddContact()
    {
        Contact contact = new Contact();
        contact.Name = Helpers.GetNameInput();
        contact.PhoneNumber = Helpers.GetPhoneNumber();
        contact.Email = Helpers.GetEmail();
        Database.Add.Contact(contact);
    }

    internal static void ViewAllContacts()
    {
        View.AllContacts.DisplayAll(Database.GetAllContacts.GetAllDto());
    }

    internal static void DeleteContact()
    {
        List<Contact> contacts = Database.GetAllContacts.GetAllRaw();
        Contact contact = View.ContactPicker.Select(contacts);

        if (contact != null)
        {
            bool confirmation = Helpers.ConfirmOperation();

            if (confirmation)
            {
                Database.Delete.Contact(contact);
            }
        }
    }

    internal static void UpdateContact()
    {
        List<Contact> contacts = Database.GetAllContacts.GetAllRaw();
        Contact contact = View.ContactPicker.Select(contacts);

        if (contact != null)
        {
            contact.Name = Helpers.GetNameInput();
            contact.PhoneNumber = Helpers.GetPhoneNumber();
            contact.Email = Helpers.GetEmail();

            bool confirmation = Helpers.ConfirmOperation();

            if (confirmation)
            {
                Database.Update.Contact(contact);
            }
        }
    }
}
