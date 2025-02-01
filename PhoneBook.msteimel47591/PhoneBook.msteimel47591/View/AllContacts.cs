using PhoneBook.Control;
using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook.View;
internal class AllContacts
{
    internal static void DisplayAll(List<ContactDto> contacts)
    {
        Helpers.Header();

        Table table = new Table();

        table.AddColumn("Name");
        table.AddColumn("Phone Number");
        table.AddColumn("Email");

        foreach (var contact in contacts)
        {
            table.AddRow(contact.Name, contact.PhoneNumber, contact.Email);
        }

        AnsiConsole.Write(table);
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadLine();
    }
}
