/*

1. Use inheritance and have a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
2. Use polymorphism by having dervived classes override base class methods where appropriate.
3. Follow the principles of encapsulation and abstraction by having private member variables and putting reltated items in the same class.

*/
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    /*
    This is from the lessons from the CSE 210 7 Week course:

    "Each goal needs to provide a way to record the event.
    Each one needs to provide a check to see if it IS COMPLETE.
    This method should do whatever necessary for each specific kind of goal, such as making a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event. (Keep in mind that it may contain a bonus in some cases if a checklist goal was just finished.)"
    */
    public abstract void RecordEvent();

    /*
        This method should return true if the goal is gompleted. The way you determine if a goal scomplete is different for each type of goal.
    */
    public abstract bool IsComplete();

    /*
    This method should return the details of a goal that could be shown in a LIST. It should include the checkbox
    */
    public string GetDetailString()
    {
        // if (IsComplete == true)
        // {
        //     return $"[X] {_shortName} ({_description})";
        // }
        // else
        // {
            return $"[ ] {_shortName} ({_description})";
        // }
    }
    public abstract string GetStringRepresentation();
}