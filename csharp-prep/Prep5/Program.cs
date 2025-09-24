using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PropmptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, userNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // I had this as a void, but I need it to be a string. It wouldn't return a value as a void.
    static string PropmptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;

        // this is the code I hade before I made functions:
        // string userName = Console.ReadLine();
    }

    // Also needed to remove void so I can return a value.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        return userNumber;
    }

    // In our lesson, it says we have to pass a reference type to change the value of that type by passing out as a parameter.
    static void PromptUserBirthYear(out int userYear)
    {
        Console.Write("Please enter the year you were born: ");
        string userInput2 = Console.ReadLine();
        userYear = int.Parse(userInput2);

        // This works too. //I'm not sure this goes here. it doesn't go here.
        // int userAge = 2025 - userYear;
    }

    // The main function is saying it doesn't like the void, changing it to int.
    static int SquareNumber(int userNumber)
    {
        // This works.
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }
    static void DisplayResult(string userName, int squaredNumber, int userYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {2025 - userYear} this year.");
    }
}