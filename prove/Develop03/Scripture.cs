public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private string _verse;
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;

        // I need to split the words from the paragraph.
        foreach (string word in verse.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }
}
// Creating instances of types - Objects:

// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects


// Encapsulation by Brother Nathan Parrish

// https://rumble.com/v26i1hk-object-oriented-programming-encapsulation.html


// Serilize and Deserialize by Brother Nathan Parrish
// https://rumble.com/v3qgul4-branches-iterative-coding-and-pull-requests.html?start=694


// Help with the Split Method:

// https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split


// Brother Chad Macbeth's video on the Split Method:
// https://video.byui.edu/media/t/1_sv3gxgzs