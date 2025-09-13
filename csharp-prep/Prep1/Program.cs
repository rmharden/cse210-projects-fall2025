/*
Rebekah Harden
CSE 210 - Programming with Classes
Brother Randall Booth
September 13, 2025

W01 Prove: Developer - C# Programming Parts 1 - 2
C# Prep 1 - Variables and Input/Output
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