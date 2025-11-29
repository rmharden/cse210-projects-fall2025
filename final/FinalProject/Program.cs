using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        List<string> countries = new List<string>();

        Person p1 = new Person("great grandmother", "Madsen", "Sidse", 1820, "Denmark", 1900, "United States of America");
        Console.WriteLine(p1.GetPersonString());

        var choice = "";
        do
        {
            Console.WriteLine("Please choose the type of relative you would like to add: ");
            Console.WriteLine("1. Ancestor");
            Console.WriteLine("2. Decendant");
            Console.WriteLine("3. Other Realtive");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();
            if (choice == "1")
            {
                
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
        }
        while (choice != "4");
    }
}