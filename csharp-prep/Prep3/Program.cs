using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1:
        /*
        Console.Write("\nWhat is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        */

        // Test:
        // Console.WriteLine($"\nYou entered: {magicNumber}");

        // Step 3
        Random randomGenerator = new Random();
        // This is what I had but the example had (1, 101);
        // int magicNumber = randomGenerator.Next(1, 100);
        // changed 100 to 101 - is this because it won't display 100? if it won't, will the random generator never choose 1, then?
        int magicNumber = randomGenerator.Next(1, 101);


        int guess = -1;

        // Step 2:
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
     
    }
}