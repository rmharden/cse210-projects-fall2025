using System;
public class Entry
{
    string _date;
    string _prompt;
    string _entry;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);

    }
}