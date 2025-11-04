/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
October 31, 2025

W08 Prove: Developer
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity b1 = new BreathingActivity("Breathing Activity", "", 5);
                b1.Run();
                b1.DisplayStartingMessage();
                b1.ShowSpinner(5);
                b1.DisplayEndingMessage();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                ListingActivity l1 = new ListingActivity("Listing Activity", "", 5);
                l1.Run();
            }
        } while (choice != "4");
    }
}

/*

BYU-Idaho Video - Brother Chad Macbeth's CSE 210: Week 4 Assignment Video:
https://video.byui.edu/media/t/1_f4017z1d/259941952


*/