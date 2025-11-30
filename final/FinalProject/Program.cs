using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Genealogy Program\nWhen finished, type 'quit'.");
        string country = "";
        EthnicityCalculator e1 = new EthnicityCalculator();
        do
        {
            Console.Write("What is the name of the country? ");
            country = Console.ReadLine();

            country = country.Trim().ToLower();
            if (country.ToLower() != "quit")
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                e1.AddCountry(ti.ToTitleCase(country));
            }
        }
        while (country.ToLower() != "quit");

        e1.GetEthnicityEstimate();
    }
}

// Sites I used for help:

/*
Trim()
https://learn.microsoft.com/en-us/dotnet/api/system.string.trim?view=net-10.0

ToLower()
https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-10.0

ToUpper()
https://learn.microsoft.com/en-us/dotnet/api/system.string.toupper?view=net-10.0

ToTitleCase()
https://learn.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-10.0
*/