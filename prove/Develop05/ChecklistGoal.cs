public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override bool isComplete()
    {
        // Return back wheter this goal is complete or not
        return false;
    }
    public override int RecordEvent()
    {
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}