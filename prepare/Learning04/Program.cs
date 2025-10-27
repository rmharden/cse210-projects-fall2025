using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment anAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(anAssignment.GetSummary());

        MathAssignment aMathAssignment = new MathAssignment("Roberto Rodriquez", "Fractions", "Section 7.3", "problems 8-19");
    }
}