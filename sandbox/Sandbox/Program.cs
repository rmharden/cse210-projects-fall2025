using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();

        ReferenceTest referenceTest1 = new ReferenceTest("John", 3, 16);
        ReferenceTest referenceTest2 = new ReferenceTest("Proverbs", 3, 5, 6);


        //WordTest _aWord = new WordTest("test");

        ScriptureTest _john316 = new ScriptureTest(referenceTest1, "For God so loved the world, that He gave his only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");

        ScriptureTest _proverbs356 = new ScriptureTest(referenceTest2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknoledge Him, and He shall direct thy paths.");


        List<ScriptureTest> _scriptureChoices = new List<ScriptureTest>()
        {
            _john316,
            _proverbs356
        };

        ScriptureTest _chosenScripture = _scriptureChoices[_random.Next(_scriptureChoices.Count)];

        Console.Clear();

        string userInput = "";
        while (userInput.ToLower() != "quit")
        {

            // Console.WriteLine($"\n{referenceTest1.DisplayReference()}\n");
            // Console.WriteLine($"\n{referenceTest2.DisplayReference()}\n");

            Console.WriteLine($"\n{_chosenScripture.DisplayScripture()}\n");
            // Console.WriteLine(_aWord.DisplayWord());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
        Console.WriteLine(_chosenScripture.DisplayScripture());
    }
}

/* 

Sites I used for help:
 
https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
https://video.byui.edu/media/t/1_sv3gxgzs
https://video.byui.edu/media/t/1_vmeovorz


 */