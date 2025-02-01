using PhoneBook.Models;

namespace PhoneBook.Database;

internal class SeedDatabase
{
    public void Seed()
    {
        using var db = new Instance();

        List<Contact> contacts = new List<Contact>
        {
            new Contact
            {
                Name = "John Doe",
                PhoneNumber = "1-555-555-5555",
                Email = "john.doe@example.com"
            },
            new Contact
            {
                Name = "Jane Smith",
                PhoneNumber = "1-555-555-1234",
                Email = "jane.smith@example.com"
            },
            new Contact
            {
                Name = "Alice Johnson",
                PhoneNumber = "1-555-555-6789",
                Email = "alice.johnson@example.com"
            },
            new Contact
            {
                Name = "Bob Brown",
                PhoneNumber = "1-555-555-9876",
                Email = "bob.brown@example.com"
            },
            new Contact
            {
                Name = "Charlie Davis",
                PhoneNumber = "1-555-555-4321",
                Email = "charlie.davis@example.com"
            }
        };

        db.Contacts.AddRange(contacts);
        db.SaveChanges();
    }
}