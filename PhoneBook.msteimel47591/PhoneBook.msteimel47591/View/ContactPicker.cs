using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook.View;
internal class ContactPicker
{
    internal static Contact Select(List<Contact> contacts)
    {
        var choices = contacts.Select(c => c.Name).ToList();

        var selectedName = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select a contact:")
                .PageSize(10)
                .AddChoices(choices)
                .AddChoices("Cancel")
        );

        if (selectedName == "Cancel")
        {
            return null;
        }

        return contacts.First(c => c.Name == selectedName);
    }
}
