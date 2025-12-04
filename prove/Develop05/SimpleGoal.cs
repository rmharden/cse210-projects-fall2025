public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isComplete) : base(goalName, goalDescription, goalPoints)
    {
        _isComplete = isComplete; // I need to do more than this but I don't know what.
    }
    public override void RecordGoal()
    {
        // This doesn't go here: 
        Console.Write("\nWhat is the name of the goal? ");
        string goalName = Console.ReadLine();

        Console.Write("\nWhat is a short description of the goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("\nWhat is the amount of points associated with this the goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
    }
    public override bool IsComplete()
    // I need to do more than this but I don't know what.
    {
        if (isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        // this might need a if statement for the [X] or [ ].
        return $"{_points}~|~{_goalName}~|~({_description})";
    }
}


// Can be marked complete and the user gains some value.
    // For example, the user ran a marathon and they get 1000 points.
