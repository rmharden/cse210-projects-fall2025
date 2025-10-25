using System;

class Program
{
    static void Main(string[] args)
    {
        ReferenceTest referenceTest1 = new ReferenceTest("John", 3, 16);
        ReferenceTest referenceTest2 = new ReferenceTest("Proverbs", 3, 5, 6);

        List<ReferenceTest> _scriptureChoice = new List<ReferenceTest>
        {
            referenceTest1,
            referenceTest2
        };
        
        string userInput = "";
        while (userInput != "quit")
        {

            Console.WriteLine($"\n{referenceTest1.DisplayReference()}\n");
            Console.WriteLine($"\n{referenceTest2.DisplayReference()}\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
    }
}