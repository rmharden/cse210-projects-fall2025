using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();
        ReferenceTest referenceTest1 = new ReferenceTest("John", 3, 16);
        ReferenceTest referenceTest2 = new ReferenceTest("Proverbs", 3, 5, 6);

        List<ReferenceTest> _scriptureChoices = new List<ReferenceTest>
        {
            referenceTest1,
            referenceTest2
        };

        ReferenceTest _chosenReference = _scriptureChoices[_random.Next(_scriptureChoices.Count)];

        Console.Clear();

        string userInput = "";
        while (userInput != "quit")
        {

            // Console.WriteLine($"\n{referenceTest1.DisplayReference()}\n");
            // Console.WriteLine($"\n{referenceTest2.DisplayReference()}\n");

            Console.WriteLine($"\n{_chosenReference.DisplayReference()}\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
    }
}