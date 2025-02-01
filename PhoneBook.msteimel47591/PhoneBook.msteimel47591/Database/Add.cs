using PhoneBook.Models;

namespace PhoneBook.Database;

internal class Add
{
    internal static void Contact(Contact person)
    {
        var db = new Instance();
        db.Contacts.Add(person);
        db.SaveChanges();
    }
}
