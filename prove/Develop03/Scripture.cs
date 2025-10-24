public class Scripture
{
    private Reference _reference;
    private string _verse;
    private List<Word> _words;
    public Scripture(Reference reference, string verse)
    {
        // Split up the words in text and store each as a word object in the list _words:

        _verse = verse;
        _reference = reference;

        string name = "John Deere";
        string[] words = name.Split(" ");
        Console.WriteLine(words[0]);

        // Split and then loop each word
        // Create a word object and put it into _words
        string[] aWord = verse.Split(" ");
        foreach (string word in aWord)
        {
            _words.Add(new Word(word));
        }


    }
    public void HideWords(int numberToHide)
    {
        //Most difficult one.

        // Set a state of randomly selected group of words to be hidden.

        // Need to find a set of visible words = if ishidden in Word returns false it is hidden.

        // Need to randomly select 'numberToHide' of those words. 

        // To hide them, use the Hide function
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
    public string DisplayScripture()
    {
        // Display reference and all the words. The Word class has a job to make the word hidden or not
        return $"{_reference.DisplayReference()} ";
    }
}


// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators

// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-9.0