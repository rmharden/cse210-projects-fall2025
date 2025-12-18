/*
This is going to be the base class.
*/

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        //Lists
        return _eventTitle + "\n" + _description + "\n" + _date + "\n" + "at" + _time + "\n" + _address;
    }
    public void FullDetails()
    {
        //Lists
        Console.WriteLine(StandardDetails());
        Console.WriteLine($"");
    }
    public string GetShortDescription()
    {
        return _eventTitle + _description + _date + _address;
    }
}


/*       
        Output Examples from Chad Macbeth's BYU-I Video:

        Object Oriented Programming - Inheritance
        January 1, 2023 @ 9:00am
        123 Elm St
        New York City, NY, USA
        Speaker: Bob the Builder
        Capacity: 100

        Lecture - Object Oriented Programming - January 1, 2023
        =======================================================

        Lecture - Object Oriented Programming - January 1, 2023
        Console.WriteLine($"\nObject Oriented Programming - Inheritance\nJanuary 1, 2023 @ 9:00am\n123 Elm St\nNew York City, NY, USA\n");

        Console.WriteLine($"Type: Lecture\nObject Oriented Programming - Inheritance\nJanuary 1, 2023 @ 9:00am\n123 Elm St\nNew York City, NY, USA\nSpeaker: Bob the Builder\nCapacity: 100\n");

        Console.WriteLine($"Lecuture - Object Oriented Programming - January 1, 2023\n========================================");

        // 2nd example:
        Console.WriteLine($"\nExample 2:");

        Console.WriteLine($"Graduation - MSD 321 Graduation Party\nJune 1, 2023\n123 Elm St\nNew York City, NY, USA\n");

        Console.WriteLine($"\nType: Reception\nGraduation - MSD 321 Graduation Party\nJune 1, 2023 @ 7:00pm\n123 Elm St\nNew York City, NY, USA\nEmail: grad@msd321.com\n");

        Console.WriteLine($"\nReception - Graduation - June 1. 2023\n========================================");

        // 3rd example:
        Console.WriteLine($"\nExample 3:");

        Console.WriteLine($"\nBridge Tour - Tour the London Bridge\nOctober 13,2023 @ 11:30pm\n246 Oak Circle\nLondon, England, UK\n");

        Console.WriteLine($"Type: Outdoor Gathering\nBridge Tour - Tour the London Bridge\nOctober 13, 2023 @ 11:30am\n246 Oak Circle\nLondon, England, UK\nWeather: Chance of Rain and Wind\n");

        Console.WriteLine($"\nOutdoor Gathering: Bridge Tour - October 13, 2023\n========================================");
        */