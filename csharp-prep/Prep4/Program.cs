using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1:
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int response = -1;

        while (response != 0)
        {
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
        // This is originally what I had, but it didn't show the decimal:
        // float average = sum / numbers.Count;
        // I used the example from our lesson:
        float average = ((float)sum) / numbers.Count;

        // Finding the Largest Number
        // place holder:
        int largest = 0;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}