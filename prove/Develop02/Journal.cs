using System;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    Entry anEntry = new Entry();

    public void AddEntry(Entry anEntry)
    {
        // This is a guess. I'm trying to add the details of the entries from the main Program.cs to the list of entries.
        _entries.Add(anEntry);
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // I don't think this is correct. How do I know how to do this? The lesson doesn't explain.
            // foreach (Entry entry in _entries)
            // {
            //     outputFile.WriteLine(entry);
            // }            

            // This is another guess, based on the need to split files:
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void DisplayAll()
    {
        // This displays the current list, but it doesn't actually display the items in the file... How do I get the items in the file in this list?? ** I forgot to add items to the list in the LoadFromFile method.
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(string filename)
    {
        // I'm not sure this is right. I am using the example from the lesson on reading a text file in C# from our lesson.
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry anEntry = new Entry();
            anEntry._date = parts[0];
            anEntry._promptText = parts[1];
            anEntry._entryText = parts[2];


            // I forgot to add the items to the list once they are loaded.
            _entries.Add(anEntry);
        }
    }
}