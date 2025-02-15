using System;

class Program
{
    static void Main()
    {
        // Asks the user for a decimal number
        Console.Write("Yoooo dude enter a decimal number: ");
        string input = Console.ReadLine();

        // Trys to convert the input to double
        if (double.TryParse(input, out double number))
        {
            // Truncates the decimals without rounding
            int truncatedNumber = (int)number;

            // Displays the original and truncated values
            Console.WriteLine($"Original value: {number}");
            Console.WriteLine($"Truncated value: {truncatedNumber}");
        }
        else
        {
            // Error message if conversion fails, keyword IF else it'll not work at-all.
            Console.WriteLine("Duude you got an error: Please enter a valid decimal number.");
        }
    }
}