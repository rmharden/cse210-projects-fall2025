using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1:
        Console.Write("\nWhat is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        // Test:
        Console.WriteLine($"\nYou entered: {magicNumber}");
    }
}