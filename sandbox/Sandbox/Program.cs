using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();

        ReferenceTest referenceTest1 = new ReferenceTest("John", 3, 16);
        ReferenceTest referenceTest2 = new ReferenceTest("Proverbs", 3, 5, 6);


        WordTest _aWord = new WordTest("test");

        List<ReferenceTest> _scriptureChoices = new List<ReferenceTest>
        {
            referenceTest1,
            referenceTest2
        };

        ReferenceTest _chosenReference = _scriptureChoices[_random.Next(_scriptureChoices.Count)];

        Console.Clear();

        string userInput = "";
        while (userInput.ToLower() != "quit")
        {

            // Console.WriteLine($"\n{referenceTest1.DisplayReference()}\n");
            // Console.WriteLine($"\n{referenceTest2.DisplayReference()}\n");

            Console.WriteLine($"\n{_chosenReference.DisplayReference()}\n");
            Console.WriteLine(_aWord.DisplayWord());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
    }
}

/* 

Sites I used for help:
 
https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
https://video.byui.edu/media/t/1_sv3gxgzs
https://video.byui.edu/media/t/1_vmeovorz


 */