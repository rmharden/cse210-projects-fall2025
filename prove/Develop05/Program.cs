/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
November 14, 2025

W10 Prove: Developer
Unit 05 Develop: Eternal Quest Program
*/


using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    // Create a GoalManager object
    // Call the Start function on that object
    {
        // Test
        // List<Goal> goals = new List<Goal>();

        // Console.Write("What is the name of your goal? ");
        // string shortName = Console.ReadLine();
        // Console.Write("What is a short description of it? ");
        // string description = Console.ReadLine();
        // Console.Write("What is the amount of points associated with this goal? ");
        // int points = int.Parse(Console.ReadLine());

        // SimpleGoal sg = new SimpleGoal(shortName, description, points);
        // goals.Add(sg);

        // // cannot do the simplegoal one. Use goal.
        // // This doesn't work though - it displays the name of the object.
        // Goal g = goals[0];
        // Console.WriteLine(g.GetStringRepresentation());


        // I'm not sure what to do here because - What did they want specifically with 
        // List<Goal> goals = new List<Goal>();

        GoalManager gm = new GoalManager("goals", 0);
        gm.Start();
    }
}

// Sites I used for help:

/*

BYU-Idaho Videos
Chad Macbeth CSE:210 Week 5 Assignment
https://video.byui.edu/media/t/1_6lpgm7dz



*/