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
        _isHidden = true;

    }
    public bool IsHidden()
    {
        // I am not sure about this.
        // return true;
        // Chad Macbeth has this set to false:
        // return false;
        return _isHidden;

    }
    public string GetRenderedText()
    {
        // Does this have an if statement too?
        // return "";

        // Testing bool _isHidden:

        // Returns the word if visible or returs underscores ___ if hidden.
        //return _verse;

        // This is a guess... I'm not sure how to do this yet.
        if (_isHidden)
        {
            return "_";
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

// This shows how to use String Contructors. It "initializes a new instance of the String class." 
// https://learn.microsoft.com/en-us/dotnet/api/system.string.-ctor?view=net-9.0#system-string-ctor(system-char*-system-int32-system-int32)


