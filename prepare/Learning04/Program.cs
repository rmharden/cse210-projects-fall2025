using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment anAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(anAssignment.GetSummary());

        MathAssignment aMathAssignment = new MathAssignment("Roberto Rodriquez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine($"\n{aMathAssignment.GetHomeWorkList()}\n");

        WritingAssignment aWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"\n{aWritingAssignment.GetWritingInformation()}\n");
    }
}