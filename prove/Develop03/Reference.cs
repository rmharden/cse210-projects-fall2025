public class Reference
{
    private string _book;
    private int _startVerse;
    private int _endVerse;
    public Reference(string book, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = _startVerse;
    }
    public Reference(string book, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string DisplayReference()
    {
        if (_endVerse != _startVerse)
        {
            return $"{_book}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book}:{_startVerse}";
        }
    }
}