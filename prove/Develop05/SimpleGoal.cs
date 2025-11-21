public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override int RecordEvent()
    {
        // If we previously were not complete, then mark complete and return points.

        // What if we previously were complete? 
        return 0;
    }
    public override bool isComplete()
    {
        // Return back wheter this goal is complete or not
        return false;
    }
    public override string GetStringRepresentation()
    {
        // Test:
        return $"You have {_points} points.\n [X] {_shortName} ({_description})";
    }
}