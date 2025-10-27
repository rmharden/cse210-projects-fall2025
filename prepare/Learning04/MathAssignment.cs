public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeWorkList()
    {
        // This is what I had before seeing the sample solution:
        // return GetSummary() +"\n" + _textbookSection + " " + _problems;
        return $"Section {_textbookSection} Problems {_problems}";
    } 
}