using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());


    }
}