using PhoneBook.Models;

namespace PhoneBook.Database;

internal class Update
{
    internal static void Contact(Contact person)
    {
        using var db = new Instance();
        db.Update(person);
        db.SaveChanges();
    }
}
