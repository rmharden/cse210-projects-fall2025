/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
December 8, 2025

W13 Final
Foundation 4: Polymorphism with Exercises Tracking
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running r1 = new Running("5/3/2023", "Running", 90, 3);
        Console.WriteLine(r1.GetSummary());

        Cycling c1 = new Cycling("5/4/2023", "Biking", 60, 15);
        Console.WriteLine(c1.GetSummary());

        // Need to figure out what is upsetting this:
        // Swimming s1 = new Swimming("5/5/2023", "Swimming", 20, 0.155);
        // Console.WriteLine(s1.GetSummary());
    }
}

/*
Sites I used for help:

Brother Chad Macbeth BYU-I Videos:
https://video.byui.edu/media/t/1_fnsp1qsi
*/