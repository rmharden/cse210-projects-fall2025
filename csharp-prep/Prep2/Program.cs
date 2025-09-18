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
        // Console.WriteLine($"{gradePercentage}");

        // Step 3:
        string letter = "";


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("I'm sorry. You did not pass.");
        }

        // Step 3"
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        

        // Step 1 & 2:
        /*
        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else
        {
            Console.WriteLine("Your grade is a F.");
        }
        */
    }
}