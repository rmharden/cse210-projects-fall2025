/*
Rebekah Harden
CSE 210 - Programming with Classes
Brother Randal Booth
September 13, 2025
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // adding this to create a space between questions asked to the user and the displayed message.
        Console.WriteLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}