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
        string _john = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference r1 = new Reference("John", 3, 6);
        Scripture s1 = new Scripture(r1, _john);

        string _proverbs = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknoledge him, and he shall direct thy paths.";
        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(r2, _proverbs);

        string userInput = "";
        while (userInput.ToLower() != "quit")
        {
            Console.Clear();

            Console.WriteLine($"{s1.DisplayScripture()}\n");

            Console.WriteLine($"{s2.DisplayScripture()}\n");

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
        }
        Console.Clear();
    }
}

// Used this site to learn how to make the user input all lower case:
// https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-9.0#system-string-tolower

// Brother Chad Macbeth sets up the stubs for the program, the scripture memorizer, in this BYU-Idaho video:
// https://video.byui.edu/media/t/1_sv3gxgzs