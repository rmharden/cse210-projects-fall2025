public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
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
    public override string GetStringRepresentation()
    {
        return "";
    }
}