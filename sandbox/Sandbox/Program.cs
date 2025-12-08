using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your name? ");
        string _preparerName = Console.ReadLine();

        Console.Write("\nWhat is your relation to this relative? (example: son, daughter, grandson, granddaugher...) ");
        string _relation = Console.ReadLine();

        Console.Write("\nWhat is your your relative's given name? ");
        string _givenName = Console.ReadLine();

        Console.Write("\nWhat is your your relative's surname name? ");
        string _surname = Console.ReadLine();

        Console.Write("\nWhat is the year your relative was born? ");
        int _yearBorn = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the country is where your relative was born? ");
        string _countryBorn = Console.ReadLine();

        Console.Write("\nWhat is the year your relative died? ");
        int _yearDied = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the country is where your relative was died? ");
        string _countryDeath = Console.ReadLine();

        Console.Write("\nWas your relative married? (yes or no) ");
        string _married = Console.ReadLine();

        Console.Write("\nWhat is your your relative spouses's given name? ");
        string _spouseGivenName = Console.ReadLine();

        Console.Write("\nWhat is your your relative's spouse's surname name? ");
        string _spouseSurname = Console.ReadLine();


        Console.WriteLine($"Family Group Record");
        Console.WriteLine($"Prepared by {_preparerName}");
        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"");

    }
}