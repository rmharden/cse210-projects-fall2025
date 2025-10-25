using System;

class Program
{
    static void Main(string[] args)
    {
        ReferenceTest referenceTest = new ReferenceTest("Proverbs", 3, 5, 6);

        string userInput = "";
        while (userInput != "quit")
        {

            Console.WriteLine($"{referenceTest.DisplayReference()}/n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
    }
}