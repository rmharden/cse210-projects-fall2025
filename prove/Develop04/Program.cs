/*
Rebekah Harden
Brother Randall Booth
CSE 210: Programming with Classes
November 3, 2025

W08 Prove: Developer
Unit 04 Develop: Mindfulness Program
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //Test code for the Activity base class:
        // Activity a1 = new Activity("test", "test", 0);
        // a1.DisplayStartMessage();
        var choice = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1.  Start Breathing Activity");
            Console.WriteLine(" 2.  Start Reflecting Activity");
            Console.WriteLine(" 3.  Start Listing Activity");
            Console.WriteLine(" 4.  Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity b1 = new BreathingActivity("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                b1.Run();
            }
            else if (choice == "2")
            {

                ReflectingActivity r1 = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                r1.Run();
            }
            else if (choice == "3")
            {

                ListingActivity l1 = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area", 0);
                l1.Run();
            }
        } while (choice != "4");
    }
}

/*
Sites I Used for help:

https://video.byui.edu/media/t/1_f4017z1d

*/