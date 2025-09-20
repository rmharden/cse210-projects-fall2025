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
        // Console.WriteLine($"\nYou entered: {magicNumber}");

        Console.WriteLine("What is your guess? ");
        string userpInput2 = Console.ReadLine();
        int guess = int.Parse(userpInput2);

        do
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("\nLower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
     
    }
}