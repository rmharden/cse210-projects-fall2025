public class Scripture
{
    private string _verse;
    public Scripture(string verse)
    {
        _verse = verse;
    }
    public string DisplayScripture()
    {
        return _verse;
    }
}