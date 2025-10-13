// The Word class keeps track of a single word and whether it is shown or hidden... Is this where a random generator goes??

// How do you hide words and display them with the underscore, _, per letter? It would go here, in this class, right?

public class Word
{
    // Does this class need constuctors and/or a list?
    // I don't know what attributes should be in this class yet.
    private string _verse;
    private bool _isHidden;

    public Word(string verse)
    {
        // I think this would need a string parameter of the scripture verse to pass through so it can split the words and display the words of the scripture verse.
        _verse = verse;
        // does this go here?
        _isHidden = false;
    }
    public void Hide()
    {

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        // I am not sure about this.
        return true;
    }
    public string GetRenderedText()
    {
        // Does this have an if statement too?
        return "";
    }

}