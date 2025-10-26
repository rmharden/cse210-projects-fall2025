public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private string _verse;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
        _words = new List<Word>();


        // The Mircorsoft Learn site had ' ' instead of " " in the example, does that matter? I thought " " was a string and ' ' is a Char data type. If I have ' ' will there be problems in my code later?

        string[] _splitWords = _verse.Split(" ");
        for (int i = 0; i < _splitWords.Length; i++)
        {
            Word _aWord = new Word(_splitWords[i]);
            _words.Add(_aWord);
        }
    }
    public void HideWords()
    {
        /*
        My notes from Brother Chad Macbeth's video on BYUI Videos:
        Step 1: Need to find a set of visible words with WordTest IsHidden. If returns false it's visible.

        Step 2: Randomly select number to hide. Loops, if statements, call isvisible function, start a randomly selected group of owrds and it doesn't matter if they are hidden at first.

        Step 3: How do you hide them? Use the Hide Function.

        Step 4:

        Call GetDisplayText()
        */
        Random _aNewRandom = new Random();

        List<int> _wordsNotHidden = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                _wordsNotHidden.Add(i);
            }
        }
        if (_wordsNotHidden.Count == 0)
        {
            Console.Clear();
            Console.Write(_words + " ");
        }
        // The 3 is giving the error: The number 5 worked better for the John scripture.
        // I don't like this whole section here: I'm not sure how to do this bettter:
        for (int i = 0; i < 5; i++)
        {
            int randomAvailableWordIndex = _aNewRandom.Next(_wordsNotHidden.Count);
            // This gets a CLR/System.ArgumentOutOfRangeExeption for the John scripture. I don't know how to fix this. Now I get it on the Proverb scripture and not the John scripture when I changed it from 3 to 5.
            // Now I am getting an error with proverbs when I changed it to 5 instead.
            int _wordIndex = _wordsNotHidden[randomAvailableWordIndex];
            _words[_wordIndex].Hide();
            _wordsNotHidden.RemoveAt(randomAvailableWordIndex);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word _aWord in _words)
        {
            if (_aWord.IsHidden() == false) return false;
        }
        return true;
    }

    public string DisplayScripture()
    {
        // Displays Reference, all the Words. It doesn't worry if it is hidden, that is a job in the Word class.
        // This going to call the DisplayWord from the WordTest class.
        string _displayedRefScripture = _reference.DisplayReference() + "\n";
        foreach (Word _aWord in _words)
        {
            _displayedRefScripture = _displayedRefScripture + _aWord.DisplayWord() + " ";
        }
        return _displayedRefScripture.Trim();
    }
}

/* 
Sites I used for help:
 
https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
https://video.byui.edu/media/t/1_sv3gxgzs
https://video.byui.edu/media/t/1_vmeovorz
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-9.0
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-9.0
*/
