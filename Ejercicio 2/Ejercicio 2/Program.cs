using System;

class Program
{
    static void Main()
    {
        Console.Write("Hey broski enter a decimal number in string format (e.g., \"13.5\"): ");
        string input = Console.ReadLine();

        // Call the function to convert and round the number
        ConvertAndRound(input);
    }

    /// <param name="numberStr">Number in string format (e.g., "13.5")</param>
    static void ConvertAndRound(string numberStr)
    {
        if (double.TryParse(numberStr, out double number))
        {
            // Round the number to the nearest integer
            int roundedNumber = (int)Math.Round(number);

            // Print the result
            Console.WriteLine($"The rounded number is: {roundedNumber}");
        }
        else
        {
            // Error message if conversion fails
            Console.WriteLine("Error: Please enter a valid decimal number brudda.");
        }
    }
}