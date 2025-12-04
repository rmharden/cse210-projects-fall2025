using System;
using System.Collections.Generic;
public class EthnicityCalculator
{
    // DISPLAYED LIST OF ETHNICITY ESTIMATE IS NOT IN ORDER - NEED TO LEARN HOW TO SORT THIS!
    private List<string> _countries;
    public EthnicityCalculator()
    {
        _countries = new List<string>();
    }
    public void AddCountry(string country)
    {
        _countries.Add(country);
    }
    public void GetEthnicityEstimate()
    {
        int totalCountries = _countries.Count;

        List<string> uniqueCountries = new List<string>();
        List<int> numberOfCountries = new List<int>();

        foreach (string country in _countries)
        {
            int index = uniqueCountries.IndexOf(country);
            if (index == -1)
            {
                uniqueCountries.Add(country);
                numberOfCountries.Add(1);
            }
            else
            {
                numberOfCountries[index]++;
            }
        }

        Console.WriteLine("\nEthnicity Estimate based on data entered:");

        foreach (var country in uniqueCountries)
        {
            int index = uniqueCountries.IndexOf(country);
            double percentage = (double)numberOfCountries[index] / totalCountries * 100;
            Console.WriteLine($"{country}: {percentage:F2}%");
        }
        Console.WriteLine(" ");
    }
}

// Sites I used for help:

/*
IndexOf:
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?view=net-10.0&utm_source=chatgpt.com

*/
