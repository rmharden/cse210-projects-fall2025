using System.Dynamic;

public class ScriptureTest
{
    private List<WordTest> _words = new List<WordTest>();
    private ReferenceTest _referenceTest;
    private string _verse;

    public ScriptureTest(ReferenceTest referenceTest, string verse)
    {
        _referenceTest = referenceTest;
        _verse = verse;

        string[] _splitWords = _verse.Split(' ');
        for (int i = 0; i < _splitWords.Length; i++)
        {
            WordTest _aWord = new WordTest(_splitWords[i]);
            _words.Add(_aWord);
        }

    }
}

/*
Sites I used for help:

https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split


*/