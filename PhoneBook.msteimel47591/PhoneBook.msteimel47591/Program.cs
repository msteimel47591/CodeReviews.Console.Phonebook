using Spectre.Console;

namespace PhoneBook;
internal class Program
{
    static void Main(string[] args)
    {
        using(var db = new Database.Instance())
        {
            db.Database.EnsureCreated();

            Console.WriteLine("Do you want to seed the database? (Enter y for yes)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                new Database.SeedDatabase().Seed();
            }
        }

        View.MainMenu mainMenu = new();
    }
}
