// The Scripture class hides words and gets the rendered display of the text.

public class Scripture
{
    // Does this class need a list?
    // Do I put this here too??
    private List<Word> _words;
    private Reference _reference;
    private string _verse;

    public Scripture(Reference reference, string verse)
    {
        List<Word> _words = new List<Word>();
        _reference = reference;
        _verse = verse;

        // The guidance from a Mentor section says that I need to split the verse in the constructor.
        // Chad Macbeth walks through this example to split from last week's lesson:
        string name = "John Deere";
        string[] words = name.Split(" ");
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        // "split and then loop through each word"
            // "create a word object and put it into _words"

    }

    public void HideWords()
    {
        // I don't know if this method is void yet. I put it this way for now.
        // Is this were a random generator goes?

        // "Set the state of a randomly selected group of words to be hidden"

        // Step 1: Need to find a set of visible words by using the Word class, and the Word Method, IsHidden." "If it returns false, it is visible."

        // Step 2: "Randomly select 'numberToHide' of those word...." This video by Chad Macbeth and the 7 week class of CSE 210 passes the parameter "int numberToHide" in the "HideRandomWords" method in the Scripture class; but, I don't see this mentioned anywhere in the 14 week course of CSE 210. I don't know if we're supposed to do that or not. Is it necessary?

    }

    public bool IsCompletelyHidden()
    {
        // I'm guessing here. I don't know how to do this. Is this where an if statement goes. Also, I don't understand booleans very well, but I think a boolean goes here.
        return false;
    }

    // Is this method the same thing as "Get Rendered Text"?
    public string DisplayScripture()
    {
        return $"{_reference.DisplayReference()} {_verse}";
    }
}