using System;
using System.Collections.Generic;
public class EthnicityCalculator
{
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
        for (int i = 0; i < numberOfCountries.Count - 1; i++)
        {
            for (int j = 1 + 1; j < numberOfCountries.Count; j++)
            {
                int tempCount = numberOfCountries[i];
                numberOfCountries[i] = numberOfCountries[j];
                numberOfCountries[j] = tempCount;

                string tempCountry = uniqueCountries[i];
                uniqueCountries[i] = uniqueCountries[j];
                uniqueCountries[j] = tempCountry;
            }
        }
        Console.WriteLine("Ethnicity Estimate based on data entered:");
        foreach (var country in uniqueCountries)
        {
            int index = uniqueCountries.IndexOf(country);
            double percentage = (double)numberOfCountries[index] / totalCountries * 100;
            Console.WriteLine($"{country}: {percentage:F2}%");
        }
    }    
}