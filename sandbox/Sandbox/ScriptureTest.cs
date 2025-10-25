using System.Dynamic;

public class ScriptureTest
{
    private List<WordTest> _words;
    private ReferenceTest _referenceTest;
    private string _verse;

    public ScriptureTest(ReferenceTest referenceTest, string verse)
    {
        _referenceTest = referenceTest;
        _verse = verse;
        _words = new List<WordTest>();


        // The Mircorsoft Learn site had ' ' instead of " " in the example, does that matter? I thought " " was a string and ' ' is a Char data type. If I have ' ' will there be problems in my code later?

        string[] _splitWords = _verse.Split(' ');
        for (int i = 0; i < _splitWords.Length; i++)
        {
            WordTest _aWord = new WordTest(_splitWords[i]);
            _words.Add(_aWord);
        }
    }
    public void HideWords()
    {
        /*
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
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }

    public string DisplayScripture()
    {
        // Displays Reference, all the Words. It doesn't worry if it is hidden, that is a job in the Word class.
        // This going to call the DisplayWord from the WordTest class.
        string _displayedRefScripture = _referenceTest.DisplayReference() + "\n";
        foreach (WordTest _aWord in _words)
        {
            _displayedRefScripture = _displayedRefScripture + _aWord.DisplayWord() + " ";
        }
        return _displayedRefScripture;
    }
}

/*
Sites I used for help:

https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split

https://video.byui.edu/media/t/1_sv3gxgzs

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements



*/