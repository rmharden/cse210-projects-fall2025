using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        Console.Write("Please enter your the year you were born: ");
        string userInput2 = Console.ReadLine();
        int userYear = int.Parse(userInput2);

        // This works.
        int squaredNumber = userNumber * userNumber;

        // This works too.
        int userAge = 2025 - userYear;
        
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {userAge} this year.");

    }
}