using PhoneBook.Models;

namespace PhoneBook.Database;
internal class GetAllContacts
{
    internal static List<ContactDto> GetAllDto()
    {
        var db = new Instance();
        return db.Contacts.Select(c => new ContactDto
        {
            Name = c.Name,
            PhoneNumber = c.PhoneNumber,
            Email = c.Email
        }).ToList();
    }

    internal static List<Contact> GetAllRaw()
    {
        var db = new Instance();
        return db.Contacts.Select(c => new Contact
        {
            Id = c.Id,
            Name = c.Name,
            PhoneNumber = c.PhoneNumber,
            Email = c.Email
        }).ToList();
    }
}