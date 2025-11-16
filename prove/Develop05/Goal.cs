public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;

    public Goal(string goalName, string goalDescription, int points)
    {
        goalName = _goalName;
        goalDescription = _goalDescription;
        points = _points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
}