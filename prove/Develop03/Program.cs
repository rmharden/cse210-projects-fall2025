/*
Rebekah Harden
Brother Randall Booth
CSE 210: Programming with Classes
October 11, 2025

W06 Prove: Developer
Unit 03 Develop: Scripture Memorizer
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string _john = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference r1 = new Reference("John", 3, 6);
        Scripture s1 = new Scripture(r1, _john);

        Console.Clear();
        
        Console.WriteLine($"{s1.DisplayScripture()}\n");
    }
}