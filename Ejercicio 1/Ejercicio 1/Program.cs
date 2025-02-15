using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number in words (e.g., 'twenty-five'): ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number in words (e.g., 'twelve'): ");
        string input2 = Console.ReadLine();

        int num1 = WordsToNumber(input1);
        int num2 = WordsToNumber(input2);

        if (num1 == -1 || num2 == -1)
        {
            Console.WriteLine("Error: Please enter valid numbers in words.");
        }
        else
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
    }

    static int WordsToNumber(string words)
    {
        try
        {
            return (int)ConvertWordsToNumbers(words);
        }
        catch
        {
            return -1; // Returns -1 if there is an error in the conversion
        }
    }

    static double ConvertWordsToNumbers(string numberString)
    {
        Dictionary<string, int> numberWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 },
            { "five", 5 }, { "six", 6 }, { "seven", 7 }, { "eight", 8 }, { "nine", 9 },
            { "ten", 10 }, { "eleven", 11 }, { "twelve", 12 }, { "thirteen", 13 }, { "fourteen", 14 },
            { "fifteen", 15 }, { "sixteen", 16 }, { "seventeen", 17 }, { "eighteen", 18 }, { "nineteen", 19 },
            { "twenty", 20 }, { "thirty", 30 }, { "forty", 40 }, { "fifty", 50 },
            { "sixty", 60 }, { "seventy", 70 }, { "eighty", 80 }, { "ninety", 90 },
            { "hundred", 100 }, { "thousand", 1000 }
        };

        double result = 0;
        double current = 0;

        string[] words = numberString.ToLower().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (numberWords.ContainsKey(word))
            {
                int num = numberWords[word];

                if (num == 100 || num == 1000)
                {
                    current *= num;
                }
                else
                {
                    current += num;
                }
            }
            else
            {
                throw new Exception("Invalid number.");
            }
        }
        result += current;
        return result;
    }
}