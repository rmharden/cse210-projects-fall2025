using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string country = "";
        EthnicityCalculator e1 = new EthnicityCalculator();
        do
        {
            Console.WriteLine("When finished, type 'quit'.");
            Console.Write("What is the name of the country? ");
            country = Console.ReadLine();

            if (country.ToLower() != "quit")
            {
                e1.AddCountry(country);
            }
        }
        while (country.ToLower() != "quit");

        e1.GetEthnicityEstimate();
    }
}

        //     List<string> countries = new List<string>();

    //     Person p1 = new Person("great grandmother", "Madsen", "Sidse", 1820, "Denmark", 1900, "United States of America");
    //     Console.WriteLine(p1.GetPersonString());

    //     var choice = "";
    //     do
    //     {
    //         Console.WriteLine("Please choose the type of relative you would like to add: ");
    //         Console.WriteLine("1. Ancestor");
    //         Console.WriteLine("2. Decendant");
    //         Console.WriteLine("3. Other Realtive");
    //         Console.WriteLine("4. Quit");

    //         choice = Console.ReadLine();
    //         if (choice == "1")
    //         {

    //         }
    //         else if (choice == "2")
    //         {

    //         }
    //         else if (choice == "3")
    //         {

    //         }
    //     }
    //     while (choice != "4");
    // }
    // public class Anscestor
    // {
    //     public Anscestor()
    //     {

    //     }
    //     public void AncestorMenu()
    //     {
    //         var ancestorChoice = "";
    //         do
    //         {
    //             Console.WriteLine("1. Enter vital information for Geneology records.");
    //             Console.WriteLine("2. Enter basic information of a direct ancestor to estimate your ethnicity.");
    //             Console.WriteLine("3. Quit");
    //             Console.Write("\nDo you want to enter in vital information or enter in information to only estimate your ethnicity? ");


    //             ancestorChoice = Console.ReadLine();

    //             if (ancestorChoice == "1")
    //             {
    //                 UserInterface();
    //             }
    //             else if (ancestorChoice == "2")
    //             {
    //                 Console.Write("What is the name of the country your ancestor came from?");
    //                 string ancestorBirthCountry = Console.ReadLine();
    //                 EthnicityCalculator e1 = new EthnicityCalculator();

    //                 Console.Write("\nHave you added this ancestor to your records yet? (1 for yes, 2 for no). ");
    //                 string userInput = Console.ReadLine();
    //                 if (userInput == "1")
    //                 {
    //                     // Search list for ancestors name and data.
    //                     Console.Write("What is your ancestor's surname?");
    //                     string ancestorSurname = Console.ReadLine();
    //                     Console.WriteLine("What is your ancestor's given name");
    //                     string ancestorGivenName = Console.ReadLine();
    //                     Console.WriteLine("What is your ancestor's year of birth?");
    //                     int ancestorBirthYear = int.Parse(Console.ReadLine());
    //                     // search list to find ancestor
    //                     // if ancestor is in list:
    //                     Console.WriteLine("Your ancestor was found.");
    //                     e1.GetEthnicityEstimate();
    //                 }
    //                 else if (userInput == "2")
    //                 {
    //                     Console.WriteLine("What is the relation to you of this ancestor?");
    //                     string relation = Console.ReadLine();

    //                     Console.WriteLine("What is the gender of this ancestor?");
    //                     string gender = Console.ReadLine();

    //                     Console.WriteLine("What is your ancestor's surname?");
    //                     string surname = Console.ReadLine();

    //                     Console.WriteLine("What is your ancestor's given name?");
    //                     string givenName = Console.ReadLine();

    //                     Console.WriteLine("What is your ancestor's birth year?");
    //                     int birthYear = int.Parse(Console.ReadLine());

    //                     Console.WriteLine("What is your ancestor's birth country?");
    //                     string birthCountry = Console.ReadLine();

    //                     e1.GetEthnicityEstimate();
    //                 }
    //                 else if (userInput != "1" && userInput != "2")
    //                 {
    //                     Console.WriteLine("Please enter either 1 or 2");
    //                 } 

    //             }
    //             else if (ancestorChoice != "1" && ancestorChoice != "2" && ancestorChoice != "3")
    //             {
    //                 Console.WriteLine("Please choose a number from 1 to 3.");
    //             }
    //         }
    //         while (ancestorChoice != "3");
    //     }
    //     public void UserInterface()
    //     {
    //         // This will only prompt the user if the user wants to do more than enter in the basic information and actually keep a record of vital information.
    //         Console.WriteLine("What is the relation to you of this ancestor?");
    //         string relation = Console.ReadLine();

    //         Console.WriteLine("What is the gender of this ancestor?");
    //         string gender = Console.ReadLine();

    //         Console.WriteLine("What is your ancestor's surname?");
    //         string surname = Console.ReadLine();

    //         Console.WriteLine("What is your ancestor's given name?");
    //         string givenName = Console.ReadLine();

    //         Console.WriteLine("What is your ancestor's birth year?");
    //         int birthYear = int.Parse(Console.ReadLine());

    //         Console.WriteLine("What is your ancestor's birth country?");
    //         string birthCountry = Console.ReadLine();

    //         Console.WriteLine("What is your ancestor's death year?");
    //         int deathYear = int.Parse(Console.ReadLine());

    //         Console.WriteLine("What is your ancestor's death country?");
    //         string deathCountry = Console.ReadLine();


    //         // this is going to do a if statement to search the database for the spouse. 

    //         Console.WriteLine("What is the surname of the your direct ancestor who was a child of ?");
    //         string spouseSurname = Console.ReadLine();

    //         Console.WriteLine("What is the given name of the spouse?");
    //         string spousGivenName = Console.ReadLine();


    //         Console.WriteLine("How many children did your ancestor have?");
    //         int childrenNumber = int.Parse(Console.ReadLine());

    //         // this is going to do a if statement to search the database for the spouse. 

    //         Console.WriteLine($"What is the surname of the your direct ancestor who was a child of {givenName} {surname}?");
    //         string directAncestorSurname = Console.ReadLine();

    //         Console.WriteLine("What is the given name of the spouse?");
    //         string directAncestorGivenName = Console.ReadLine();

    //         Console.WriteLine($"How are they related to {givenName} {surname}?\n1. daughter\n2. son");
    //         string directRelation = Console.ReadLine();

    //         if (directRelation == "1")
    //         {
    //             directRelation = "daughter";
    //         }
    //         else
    //         {
    //             directRelation = "son";
    //         }
    //     }
// }
// }
