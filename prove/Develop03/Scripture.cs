public class Scripture
{
    private Reference _reference;
    private string _verse;
    private List<Word> _words;
    public Scripture(Reference reference, string verse)
    {
        // Split up the words in text and store each as a word object in the list _words:

        string name = "John Deere";
        string[] words = name.Split(" ");
        Console.WriteLine(words[0]);

        // Split and then loop each word
            // Create a word object and put it into _words

    }
    public void HideWords(int numberToHide)
    {
        //Most difficult one.

        // Set a state of randomly selected group of words to be hidden.

        // Need to find a set of visible words = if ishidden in Word returns false it is hidden.

        // Need to randomly select 'numberToHide' of those words. 

    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
    public string DisplayScripture()
    {
        return "";
    }
}