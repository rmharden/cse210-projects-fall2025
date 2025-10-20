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

        //         // Test code for Word. Creating a word object:
        //         // Word w = new Word("truth");
        //         // Console.WriteLine(w.GetRenderedText());

        //         // making a random generator for any use:
        //         Random newRandom = new Random();

        //         string _john = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        //         Reference r1 = new Reference("John", 3, 6);
        //         Scripture s1 = new Scripture(r1, _john);

        //         string _proverbs = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknoledge him, and he shall direct thy paths.";
        //         Reference r2 = new Reference("Proverbs", 3, 5, 6);
        //         Scripture s2 = new Scripture(r2, _proverbs);

        //         // If we can handle different scriptures, what do we do for the two scriptures? Will it be a random scripture each time the user starts the program? If so, how do I do this? Is this like the random prompt generator in the Journal program?

        //         List<string> _chosenScipture = new List<string>();
        //         _chosenScipture.Add(_john);
        //         _chosenScipture.Add(_proverbs);


        //         Scripture chosenScripture = _chosenScipture[newRandom.Next(_chosenScripture.Count)];


        Random newRandom = new Random();

        Reference r1 = new Reference("John", 3, 16);
        Scripture _john = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture _proverbs = new Scripture(r2, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknoledge him, and he shall direct thy paths");

        List<Scripture> _scriptures = new List<Scripture>()
        {
            _john, _proverbs
        };

        Scripture _chosenScripture = _scriptures[newRandom.Next(_scriptures.Count)];

        // Console.WriteLine(_chosenScripture.DisplayScripture());

        // loop:
        // "display, hide, check if we need to quit"
        // "Use the functions in the Scripture class. We don't call anything else. Everything we need is in the Scripture class."

        string userInput = "";
        while (userInput.ToLower() != "quit")
        {
            Console.Clear();

            // Console.WriteLine($"{s1.DisplayScripture()}\n");

            // Console.WriteLine($"{s2.DisplayScripture()}\n");

            Console.WriteLine(_chosenScripture.DisplayScripture());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine(_chosenScripture.DisplayScripture());
        }
    }

// Used this site to learn how to make the user input all lower case:
// https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-9.0#system-string-tolower

// Brother Chad Macbeth sets up the stubs for the program, the Scripture Memorizer, in this BYU-Idaho video:
// https://video.byui.edu/media/t/1_sv3gxgzs
// This video offers help for the boolean operator.

// This site shows more information on random generators:

// https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-random