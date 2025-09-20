using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1:

        List<int> numbers;
        numbers = new List<int>();
        
        int response = -1;

        while (response != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            response = int.Parse(Console.ReadLine());
        }
    }
}