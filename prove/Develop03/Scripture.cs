public class Scripture
{
    private string _verse;
    private Reference _reference;
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }
    public string DisplayScripture()
    {
        return $"{_reference} {_verse}";
    }
}