/*
Rebekah Harden
Brother Randall Booth
CSE 210: Programming with Classes
October 11, 2025

W06 Prove: Developer
Unit 03 Develop: Scripture Memorizer
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();

        Reference referenceTest1 = new Reference("John", 3, 16);
        Reference referenceTest2 = new Reference("Proverbs", 3, 5, 6);


        //WordTest _aWord = new WordTest("test");

        Scripture _john316 = new Scripture(referenceTest1, "For God so loved the world, that He gave his only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");

        Scripture _proverbs356 = new Scripture(referenceTest2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknoledge Him, and He shall direct thy paths.");


        List<Scripture> _scriptureChoices = new List<Scripture>()
        {
            _john316,
            _proverbs356
        };

        Scripture _chosenScripture = _scriptureChoices[_random.Next(_scriptureChoices.Count)];

        Console.Clear();

        string userInput = "";
        while (_chosenScripture.IsCompletelyHidden() == false && userInput.ToLower().Trim() != "quit")
        {
            // Console.Clear();

            // Console.WriteLine($"\n{referenceTest1.DisplayReference()}\n");
            // Console.WriteLine($"\n{referenceTest2.DisplayReference()}\n");

            Console.WriteLine($"\n{_chosenScripture.DisplayScripture()}\n");
            // Console.WriteLine(_aWord.DisplayWord());

            _chosenScripture.HideWords();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
        // Console.WriteLine(_chosenScripture.DisplayScripture());
    }
}

/* 
// Sites I used for help:
 
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
// https://video.byui.edu/media/t/1_sv3gxgzs
// https://video.byui.edu/media/t/1_vmeovorz
//  */

// Used this site to learn how to make the user input all lower case:
// https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-9.0#system-string-tolower

// Brother Chad Macbeth sets up the stubs for the program, the Scripture Memorizer, in this BYU-Idaho video:
// https://video.byui.edu/media/t/1_sv3gxgzs
// This video offers help for the boolean operator.

// This site shows more information on random generators:

// https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-random