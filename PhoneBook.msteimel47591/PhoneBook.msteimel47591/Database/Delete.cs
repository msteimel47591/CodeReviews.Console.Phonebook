using PhoneBook.Models;

namespace PhoneBook.Database;
internal class Delete
{
    internal static void Contact(Contact person)
    {
        var db = new Instance();
        db.Contacts.Remove(person);
        db.SaveChanges();
    }
}