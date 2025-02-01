using Spectre.Console;
using PhoneBook.Control;
namespace PhoneBook.View;
internal class MainMenu
{
    public MainMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Helpers.Header();

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What would you like to do?")
                    .PageSize(10)
                    .AddChoices( "View Contacts", "Add Contact", "Update Contact", "Delete Contact", "Exit" )
            );
            switch (choice)
            {
                case "View Contacts":
                    ContactService.ViewAllContacts();
                    break;
                case "Add Contact":
                    ContactService.AddContact();
                    break;
                case "Update Contact":
                    ContactService.UpdateContact();
                    break;
                case "Delete Contact":
                    ContactService.DeleteContact();
                    break;
                case "Exit":
                    exit = true;
                    break;
            }
        }
    }
}
