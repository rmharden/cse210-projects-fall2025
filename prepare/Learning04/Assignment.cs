// This is going to be the base class:
public class Assignment
{
    private string _studentName;
    private string _type;
    public Assignment(string studentName, string type)
    {
        _studentName = studentName;
        _type = type;
    }
    public string GetSummary()
    {
        return _studentName + "-" + _type;
    }
}