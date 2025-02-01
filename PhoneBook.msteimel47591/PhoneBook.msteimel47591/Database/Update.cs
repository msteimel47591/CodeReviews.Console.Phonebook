using PhoneBook.Models;

namespace PhoneBook.Database;

internal class Update
{
    internal static void Contact(Contact contact)
    {
        using var db = new Instance();
        db.Update(contact);
        db.SaveChanges();
    }
}
