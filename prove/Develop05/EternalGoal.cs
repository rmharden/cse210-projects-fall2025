public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override int RecordEvent()
    {
        return 0;
    }
    public override bool isComplete()
    {
        return false;
    }
    public string GetDetailsString()
    {
        // This one is going to be virtual.
        return "details for list";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}