using System;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry anEntry)
    {
        // This is a guess. I'm trying to add our details entries from the main Program.cs to the list of entries.
        _entries.Add(anEntry);
    }
    public void SaveToFile(string file)
    {

    }
    public void DisplayAll()
    {

    }
    public void LoadFromFile(string file)
    {

    }
}