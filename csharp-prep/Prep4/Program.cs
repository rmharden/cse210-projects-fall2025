using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1:
        List<int> numbers = new List<int>();

        int response = -1;

        while (response != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");

            response = int.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);
            }
        }
        Console.WriteLine($"The sun is: {}");
        Console.WriteLine($"The Average is: {}");
        Console.WriteLine($"The largest number is: {}");
    }
}