using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> countries = new List<string>();
        Person p1 = new Person("great grandmother", "Madsen", "Sidse", 1820, "Denmark", 1900, "United States of America");
        Console.WriteLine(p1.GetPersonString());
        Console.WriteLine("Please choose the type of relative you would like to add: ");
    }
}