// This is not complete. There is something wrong when the program runs and it doesn't display the correct information. Fix this before submitting the assignment!



using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment anAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine();
        Console.WriteLine(anAssignment.GetSummary());


        // This is what I had before viewing the sample solution:
        // MathAssignment aMathAssignment = new MathAssignment("Roberto Rodriquez", "Fractions", "Section 7.3", "Problems 8-19");
        // Console.WriteLine($"\n{aMathAssignment.GetHomeWorkList()}\n");

        // This is what I changed after seeing the sample solution:
        MathAssignment aMathAssignment = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{anAssignment.GetSummary}\n{aMathAssignment.GetHomeWorkList()}\n");


        WritingAssignment aWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"{anAssignment.GetSummary}\n{aWritingAssignment.GetWritingInformation()}\n");
    }
}