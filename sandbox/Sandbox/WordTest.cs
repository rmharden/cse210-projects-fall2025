using System.Data;

public class WordTest
{
    private bool _isHidden;
    private string _verse;

    public WordTest(string verse)
    {
        _verse = verse;
    }
    public string DisplayWord()
    {
        return _verse;
    }
}