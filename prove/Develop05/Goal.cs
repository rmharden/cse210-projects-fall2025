public abstract class Goal
{
    protected bool isComplete = false;
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _description = goalDescription;
        _points = goalPoints;
    }
    public string GetName()
    {
        return _goalName;
    }
    public abstract void RecordGoal();
    public abstract bool IsComplete();
    public string GetListDetails()
    {
        if (IsComplete())
        {
            // This may need to have an if statement for [X] or [ ].
            return $"[X] {_goalName} ({_description})";
        }
        else
        {
            return $"[ ] {_goalName} ({_description})";
        }
    }
    public abstract string GetStringRepresentation();
    // {
    //     // this might need a if statement for the [X] or [ ].
    //     return $"{_points}~|~{_goalName}~|~({_description})";
    // }
}




/* 

Displays the user's score. (Is this here or is this in goal manager?)


*/
