using System;

class Program
{
    static void Main(string[] args)
    {
        
        int response = -1;

        while (response != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            response = int.Parse(Console.ReadLine());
        }
    }
}