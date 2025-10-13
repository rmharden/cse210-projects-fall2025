public class Scripture
{
    private Reference _reference;
    private string _verse;
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }
    public string DisplayScripture()
    {
        return $"{_reference.DisplayReference()} {_verse}";
    }
}