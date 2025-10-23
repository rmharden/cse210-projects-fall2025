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
        _words = new List<Word>();
        _reference = reference;
        _verse = verse;

        // The guidance from a Mentor section says that I need to split the verse in the constructor.

        // Chad Macbeth walks through this example to split from last week's lesson:

        // string name = "John Deere";
        // string[] words = name.Split(" ");
        // Console.WriteLine(words[0]);
        // Console.WriteLine(words[1]);

        // "split and then loop through each word"
        // "create a word object and put it into _words"

        /*
        This splits the scripture verse into string objects between spaces. It then adds each new Word object made from the split words by removing spaces and adds them to the _words list as Word objects.
        */
        foreach (string word in verse.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int numberToHide)
    {
        // I don't know if this method is void yet. I put it this way for now.
        // Is this were a random generator goes?

        // "Set the state of a randomly selected group of words to be hidden"

        // Step 1: Need to find a set of visible words by using the Word class, and the Word Method, IsHidden." "If it returns false, it is visible."

        // Step 2: "Randomly select 'numberToHide' of those word...." This video by Chad Macbeth and the 7 week class of CSE 210 passes the parameter "int numberToHide" in the "HideRandomWords" method in the Scripture class; but, I don't see this mentioned anywhere in the 14 week course of CSE 210. I don't know if we're supposed to do that or not. Is it necessary?
        // "Think about if-statements, call the IsVisible function, select a random set of words to hide and then go and hide just visible words."

        Random randomWord = new Random();
        //int i = randomWord.Next(); // What goes in the parentheses for this method? 

        // "Hide them with the Hide function."
        // Is this an if statement?

        List<int> _wordsNotHidden = new List<int>();
        for (int index = 0; index < _words.Count; index++)
        {
            if (!_words[index].IsHidden())
            {
                _wordsNotHidden.Add(index);
            }
        }
        if (_wordsNotHidden.Count == 0)
        {
            Console.Clear();
            Console.Write(_words + " ");
        }
        for (int index = 0; index < numberToHide; index++)
        {
            int randomWordIndex = randomWord.Next(_wordsNotHidden.Count);
            int _wordsNotHiddenIndex = _wordsNotHidden[randomWordIndex];

            _words[_wordsNotHiddenIndex].Hide();
            _wordsNotHidden.RemoveAt(randomWordIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        // I'm guessing here. I don't know how to do this. Is this where an if statement goes. Also, I don't understand booleans very well, but I think a boolean goes here.
        foreach (Word _word in _words)
        {
            if (!_word.IsHidden()) return false;
        }
        return true;
    }

    // Is this method the same thing as "Get Rendered Text"?
    public string DisplayScripture()
    {
        // So, Brother Chad Macbeth is saying that the job of the Word class is to return the word as underscores or as a visible word. Does this mean that we call the Word class and make an instance in the Scripture class? If so, do I do that here? Would I need to iterate through the list here too, so it displays each word of the scripture verse? If so, does Word have another list that it is replaces words with underscores? I'm not sure how this works yet.

        string _outputDisplay = _reference.DisplayReference() + " ";
        foreach (Word _word in _words)
        {
            _outputDisplay = _outputDisplay + _word.GetRenderedText() + " ";
        }
        return _outputDisplay;
    }
}

// This website shows how to create instances of types like objects.
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects


/*

Old Code:

using System.Net.Http.Headers;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private string _verse;
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
        List<Word> _words = new List<Word>();

        // I need to split the words from the scripture parameter for the string verse:

        /*
        This is an example from Microsoft Learn:

        string phrase = "The quick brown fox jumps over the lazy dog.";
        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            Console.WriteLine($"<{word}>");
        }

        This is using an array and "var" as a data type. They're also displaying it to the console - I don't want to do that - I want to added it to my _words list.... 

        "string phrase" in the example is declaring the variable named "phrase". my "string verse" is a parameter passed from the Scripture instance created in the main program with the scripture verse.

        "string[] words = phrase.Split(' '); is making an array of characters, because (' ') instead of (" ") changes the data type, right? and it is taking the phrase which is the sentence and splitting it by each space.


        This example doesn't work as it is because I need a custom data type for word. This seems to work 
        */
        /*
        foreach (string word in verse.Split(" "))
{
    _words.Add(new Word(word));
}

    }
    public void HideWords(int numberToHide)
    {
        // I don't know if this method is void yet. I put it this way for now.
        // Is this were a random generator goes?

        // "Set the state of a randomly selected group of words to be hidden"

        // Step 1: Need to find a set of visible words by using the Word class, and the Word Method, IsHidden." "If it returns false, it is visible."

        // Step 2: "Randomly select 'numberToHide' of those word...." This video by Chad Macbeth and the 7 week class of CSE 210 passes the parameter "int numberToHide" in the "HideRandomWords" method in the Scripture class; but, I don't see this mentioned anywhere in the 14 week course of CSE 210. I don't know if we're supposed to do that or not. Is it necessary?
        // "Think about if-statements, call the IsVisible function, select a random set of words to hide and then go and hide just visible words."

        Random randomWord = new Random();
        //int i = randomWord.Next(); // What goes in the parentheses for this method? 

        // "Hide them with the Hide function."
        // Is this an if statement?

        List<int> _wordsNotHidden = new List<int>();
        for (int index = 0; index < _words.Count; index++)
        {
            if (!_words[index].IsHidden())
            {
                _wordsNotHidden.Add(index);
            }
        }
        if (_wordsNotHidden.Count == 0)
        {
            Console.Clear();
            Console.Write(_words + " ");
        }
        for (int index = 0; index < numberToHide; index++)
        {
            int randomWordIndex = randomWord.Next(_wordsNotHidden.Count);
            int _wordsNotHiddenIndex = _wordsNotHidden[randomWordIndex];

            _words[_wordsNotHiddenIndex].Hide();
            _wordsNotHidden.RemoveAt(randomWordIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        // I'm guessing here. I don't know how to do this. Is this where an if statement goes. Also, I don't understand booleans very well, but I think a boolean goes here.
        foreach (Word _word in _words)
        {
            if (!_word.IsHidden()) return false;
        }
        return true;
    }

    // Is this method the same thing as "Get Rendered Text"?
    public string DisplayScripture()
    {
        // So, Brother Chad Macbeth is saying that the job of the Word class is to return the word as underscores or as a visible word. Does this mean that we call the Word class and make an instance in the Scripture class? If so, do I do that here? Would I need to iterate through the list here too, so it displays each word of the scripture verse? If so, does Word have another list that it is replaces words with underscores? I'm not sure how this works yet.

        string _outputDisplay = _reference.DisplayReference() + " ";
        foreach (Word _word in _words)
        {
            _outputDisplay = _outputDisplay + _word.GetRenderedText() + " ";
        }
        return _outputDisplay;
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
*/