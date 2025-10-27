using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment anAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(anAssignment.GetSummary());
    }
}