// This is going to be the base class:
public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // This is from the sample solution:
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    // I used this without the getters and setters and it works without the getters.
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}