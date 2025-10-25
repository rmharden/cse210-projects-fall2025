public class ReferenceTest
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ReferenceTest(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }
    public ReferenceTest(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;        
    }
}