/*

Simple goals that can be marked complete and the user gains some value.

*/

public class SimpleGoal : Goal
{
    private List<Goal> _goals;
    private int _score;
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    /*
    This is from the lessons from the CSE 210 7 Week course:

    "Each goal needs to provide a way to record the event.
    Each one needs to provide a check to see if it IS COMPLETE.
    This method should do whatever necessary for each specific kind of goal, such as making a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event. (Keep in mind that it may contain a bonus in some cases if a checklist goal was just finished.)"
    */
    public override void RecordEvent() // this needs to be changed to an int, so it wouldn't have a string, right?
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
        _isComplete = true;
    }

    /*
        This method should return true if the goal is gompleted. The way you determine if a goal scomplete is different for each type of goal.
    */
    public override bool IsComplete()
    {
        return _isComplete;
    }
    /*
    This method should provide all the details of a goal in a way that is easy to save a file, and then load later.
    */
    public override string GetStringRepresentation()
    {
        return $"[ ] " + _shortName + " (" + _description + ")"; 
    }
}