using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter a number, convert it to double
        Console.Write("Enter a number: ");
        double userInput1 = Convert.ToDouble(Console.ReadLine());

        // Multiply the input by 50 and print the result
        double result1 = userInput1 * 50;
        Console.WriteLine($"Result 1: {result1}");

        // Prompt user to enter another number, convert it to double
        Console.Write("Enter another number: ");
        double userInput2 = Convert.ToDouble(Console.ReadLine());

        // Add 25 to the input and print the result
        double result2 = userInput2 + 25;
        Console.WriteLine($"Result 2: {result2}");

        // Prompt user to enter another number, convert it to double
        Console.Write("Enter another number: ");
        double userInput3 = Convert.ToDouble(Console.ReadLine());

        // Divide the input by 12.5 and print the result
        double result3 = userInput3 / 12.5;
        Console.WriteLine($"Result 3: {result3}");

        // Prompt user to enter another number, convert it to double
        Console.Write("Enter another number: ");
        double userInput4 = Convert.ToDouble(Console.ReadLine());

        // Check if the input is greater than 50 and print the result
        bool isGreaterThan50 = userInput4 > 50;
        Console.WriteLine($"Result 4: {isGreaterThan50}");

        // Prompt user to enter another number, convert it to double
        Console.Write("Enter another number: ");
        double userInput5 = Convert.ToDouble(Console.ReadLine());

        // Divide the input by 7 and print the remainder
        double remainder = userInput5 % 7;
        Console.WriteLine($"Result 5: {remainder}");

        // Keep the console window open
        Console.ReadLine();
    }
}
