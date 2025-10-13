// The Scripture class hides words and gets the rendered display of the text.

public class Scripture
{
    private Reference _reference;
    private string _verse;
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public void HideWords()
    {
        // I don't know if this method is void yet. I put it this way for now.
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