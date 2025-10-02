using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!");


        string _userChoice = "";
        // Menu
        while (_userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            _userChoice = Console.ReadLine();

            // 1. Write
            if (_userChoice == "1")
            {

            }

            // 2. Display
            else if (_userChoice == "2")
            {
                Console.WriteLine($"You chose option {_userChoice}");
            }

            // 3. Load
            else if (_userChoice == "3")
            {
                Console.WriteLine($"You chose option {_userChoice}");
            }

            // 4. Save
            else if (_userChoice == "4")
            {
                Console.WriteLine($"You chose option {_userChoice}");
            }

            // 5. Quit
            else if (_userChoice == "5")
            {
                Console.WriteLine("Thanks for using the Journal Program!");
            }
            else
            {
                Console.WriteLine("Invalid number\n");
            }
        }
    }
}