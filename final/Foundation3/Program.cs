/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
November 26, 2025

W13 Prove: Developer: Final Project

Program 3: Inheritance with Event Planning
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Program 3: Inheritance with Event Planning!");

        // 1st example:
        Console.WriteLine($"\nExample 1:");

        Console.WriteLine($"\nObject Oriented Programming - Inheritance\nJanuary 1, 2023 @ 9:00am\n123 Elm St\nNew York City, NY, USA\n");

        Console.WriteLine($"Type: Lecture\nObject Oriented Programming - Inheritance\nJanuary 1, 2023 @ 9:00am\n123 Elm St\nNew York City, NY, USA\nSpeaker: Bob the Builder\nCapacity: 100\n");

        Console.WriteLine($"Lecuture - Object Oriented Programming - January 1, 2023\n========================================");

        // 2nd example:
        Console.WriteLine($"\nExample 2:");

        Console.WriteLine($"Graduation - MSD 321 Graduation Party\nJune 1, 2023\n123 Elm St\nNew York City, NY, USA\n");

        Console.WriteLine($"\nType: Reception\nGraduation - MSD 321 Graduation Party\nJune 1, 2023 @ 7:00pm\n123 Elm St\nNew York City, NY, USA\nEmail: grad@msd321.com\n");

        Console.WriteLine($"\nReception - Graduation - June 1. 2023\n========================================");

        // 3rd example:
        Console.WriteLine($"\nExample 3:");

        Console.WriteLine($"\nBridge Tour - Tour the London Bridge\nOctober 13,2023 @ 11:30pm\n246 Oak Circle\nLondon, England, UK\n");

        Console.WriteLine($"Type: Outdoor Gathering\nBridge Tour - Tour the London Bridge\nOctober 13, 2023 @ 11:30am\n246 Oak Circle\nLondon, England, UK\nWeather: Chance of Rain and Wind\n");

        Console.WriteLine($"\nOutdoor Gathering: Bridge Tour - October 13, 2023\n========================================");
    }
}