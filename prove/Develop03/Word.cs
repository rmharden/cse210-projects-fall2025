// The Word class keeps track of a single word and whether it is shown or hidden... Is this where a random generator goes??

// How do you hide words and display them with the underscore, _, per letter? It would go here, in this class, right?

public class Word
{
    // Does this class need constuctors and/or a list?
    // I don't know what attributes should be in this class yet.
    private string _verse;
    // This doesn't like this: It's telling me I'm not using. Do I need getters and setters?
    private bool _isHidden;

    public Word(string verse)
    {
        // I think this would need a string parameter of the scripture verse to pass through so it can split the words and display the words of the scripture verse. I'm not sure this is where we split the scripture verse because the design activity says that we split it in the Scripture class.
        _verse = verse;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        // I am not sure about this.
        // return true;
        // Chad Macbeth has this set to false:
        // return false;
        return _isHidden;
    }
    public string DisplayWord()
    {
        // Does this have an if statement too?
        // return "";

        // Testing bool _isHidden:

        // Returns the word if visible or returns underscores ___ if hidden.
        //return _verse;

        // This is a guess... I'm not sure how to do this yet.
        if (_isHidden)
        {
            return new string ('_', _verse.Length);
        }
        else
        {
            return _verse;
        }
    }
}

// How to code boolean operators:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool

// Brother Chad Macbeth from BYU-I Videos shows how to work with boolean operators in this video:
// https://video.byui.edu/media/t/1_sv3gxgzs

/* This shows how to use String Contructors. It "initializes a new instance of the String class." The examples make a string from the  "Char" data type. From my understanding, '_' is a Char data type and in order for the program to change each Word data type that's split from strings, we have to get the length of that Word data type and return it as a string, so we make a new String constructor like:

String(Char, Int32)


This works for what I need because, Int32 is allocating memory, right?, and I'm trying to get the length of the word... right? so the following is how I write this because it makes a new string constructor and it tells the program that the underscores are a Char data type, but it changes it to a string data type, right?, and then I am going to return the number of letters in the word but allocating the length of the _verse to memory, right?
return new string ('_', _verse.Length); 
*/
// https://learn.microsoft.com/en-us/dotnet/api/system.string.-ctor?view=net-9.0#system-string-ctor(system-char*-system-int32-system-int32)


// This one shows an example of the char data type with an array or a list of letters. It sets it up like an instance of a class... But I don't think it is... I'm not sure I completely understand. It looks like this:
/*
// Use the String constructor only when creating
// a string from a char*, char[], or sbyte*. See
// System.String documentation for details.
char[] letters = { 'A', 'B', 'C' };
string alphabet = new string(letters);
*/
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/


// This site shows the String.Length Property:
// https://learn.microsoft.com/en-us/dotnet/api/system.string.length?view=net-9.0