/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
November 29, 2025

W13 Prove: Developer:Final Project
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Genealogy Program!");
        GenealogyManager gm = new GenealogyManager();
        
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

/*
I will write a program using abstraction, encapsulation, inheritance, and polymorphism. Right now the main purpose of the program is to display the percentages for each country entered. I want to add another purpose, which is keeping a text file record of ancestors entered into the program where it asks for things like surname, given name, relation to the user such as parent or grandma, gender, birth year, birth country, death year, death country, spouses surname, spouses given name, how many children they had. I want to put the data into a list and serialize it. I want a menu where the user can view what was entered into the list, enter more ancestors and their data, save the list as a text file, read the text file, display the contents of the text file, load the text file, quit the program. I want to be able to use the already created EthnicityCalculator to use the data entered for the Birth Country and the program will display the percentages of ancestors from those countries.*/

