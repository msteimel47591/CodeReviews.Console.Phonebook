using Spectre.Console;
using System.Text.RegularExpressions;

namespace PhoneBook.Control;

internal class Helpers
{
    internal static string GetNameInput()
    {
        var name = AnsiConsole.Prompt(
        new TextPrompt<string>("Enter contact name"));
        return name;
    }

    internal static string GetPhoneNumber()
    {
        bool valid = false;
        string phoneNumber = String.Empty;
        while (!valid)
        {
            phoneNumber = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter contact phone number. Format must be X-XXX-XXX-XXXX "));

            if (ValidatePhoneNumber(phoneNumber))
            {
                valid = true;
            }
            else
            {
                AnsiConsole.Markup("[Red]Invalid phone number format.[/]\n");
            }
        }

        return phoneNumber;
    }

    internal static bool ValidatePhoneNumber(string phoneNumber)
    {
        if (Regex.IsMatch(phoneNumber, @"^\d-\d{3}-\d{3}-\d{4}$"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    internal static string GetEmail()
    {
        bool valid = false;
        string email = String.Empty;

        while (!valid)
        {
            email = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter contact email. Format must be username@domain.topleveldomain" +
            " For example: JSmith@gmail.com, John.Smith@EVU.edu, Smith.John@somedomain.net, ect."));
            if (ValidateEmail(email))
            {
                valid = true;
            }
            else
            {
                AnsiConsole.Markup("[Red]Invalid email format.[/]\n");
            }
        }

        return email;
    }

    internal static bool ValidateEmail(string email)
    {
        if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    internal static void Header()
    {
        Console.Clear();
        AnsiConsole.Write(new FigletText("PhoneBook App").Color(Color.Blue));
    }

    internal static bool ConfirmOperation()
    {
      
        Console.WriteLine("Are you sure you want to perform this operation? (enter y to confirm)");
        if (Console.ReadLine().ToLower() == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
