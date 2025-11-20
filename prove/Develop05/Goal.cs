public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool isComplete();
    public string GetDetailsString()
    {
        // This one is going to be virtual.
        return "details for list";
    }
    public abstract string GetStringRepresentation();
}