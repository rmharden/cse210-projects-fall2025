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
    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
    }
    static void PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string userInput2 = Console.ReadLine();
        int userYear = int.Parse(userInput2);
        // This works too. //I'm not sure this goes here.
        int userAge = 2025 - userYear;
    }
    static void SquareNumber()
    {
        // This works.
        int squaredNumber = userNumber * userNumber;
    }
    static void DisplayResult()
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {userAge} this year.");
    }
}