/*

Eternal goals are never complete, but each time the user recoreds them, they gain some value.

*/
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    /*
    This is from the lessons from the CSE 210 7 Week course:

    "Each goal needs to provide a way to record the event.
    Each one needs to provide a check to see if it IS COMPLETE.
    This method should do whatever necessary for each specific kind of goal, such as making a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event. (Keep in mind that it may contain a bonus in some cases if a checklist goal was just finished.)"
    */
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
       // Console.WriteLine($"You now have {_score}");
    }

    /*
        This method should return true if the goal is gompleted. The way you determine if a goal scomplete is different for each type of goal.
    */
    public override bool IsComplete()
    {
        return false;
    }
    /*
    This method should provide all the details of a goal in a way that is easy to save a file, and then load later.
    */
    public override string GetStringRepresentation()
    {
        return $"[ ] " + _shortName + " (" + _description + ")"; 
    }
}