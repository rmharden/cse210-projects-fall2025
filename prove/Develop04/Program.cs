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

        BreathingActivity b1 = new BreathingActivity("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        b1.Run();

    }
}

/*
Sites I Used for help:

https://video.byui.edu/media/t/1_f4017z1d

*/