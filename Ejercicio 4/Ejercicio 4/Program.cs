using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Asks the user for a date in dd/MM/yyyy format
        Console.Write("Enter a date in dd/MM/yyyy format: ");
        string inputDate = Console.ReadLine();

        // Trys to convert the string to DateTime
        if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            // Displays the date in long format
            Console.WriteLine($"Date in long format: {date.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-US"))}");
        }
        else
        {
            // Error message if the format is incorrect. IF
            Console.WriteLine("Error: Please enter a valid date in dd/MM/yyyy format.");
        }
    }
}