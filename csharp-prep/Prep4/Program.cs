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

        // Finding the sum:
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Finding the Average:
        int average = 0;
        

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {}");
        Console.WriteLine($"The largest number is: {}");
    }
}