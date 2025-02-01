using PhoneBook.Models;

namespace PhoneBook.Database;
internal class Delete
{
    internal static void Contact(Contact contact)
    {
        var db = new Instance();
        db.Contacts.Remove(contact);
        db.SaveChanges();
    }
}