public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    // Do I need to do the getters and setters if I call the GetSummary method from the Base class?
    public string GetWritingInformation()
    {
        return GetSummary() + "\n" + _title;
    }
}