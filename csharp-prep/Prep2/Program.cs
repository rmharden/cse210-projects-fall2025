/*
Rebekah Harden
CSE 210 - Programming with Classes
Brother Randall Booth
September 13, 2025

W01 Prove: Developer - C# Programming Parts 1 - 2
C# Prep 2 - Conditionals
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Asks the user for their grade percentage and stores their input into a string varible. Then the string variable is converted into an interger by using the int.Parse() function.
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        // Test to be sure the user interaction and variable works.
        Console.WriteLine($"{gradePercentage}");
    }
}