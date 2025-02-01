using PhoneBook.Models;

namespace PhoneBook.Database;

internal class Add
{
    internal static void Contact(Contact contact)
    {
        var db = new Instance();
        db.Contacts.Add(contact);
        db.SaveChanges();
    }
}
