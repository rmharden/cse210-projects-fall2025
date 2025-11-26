/*
Checklist Goal must be accomplished a certain number of times to be complete. Each time the user records this goal, they gain some value, but when they achieve the desired amount, they get an extra bonus.
*/

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    /*
This is from the lessons from the CSE 210 7 Week course:

"Each goal needs to provide a way to record the event.
Each one needs to provide a check to see if it IS COMPLETE.
This method should do whatever necessary for each specific kind of goal, such as making a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event. (Keep in mind that it may contain a bonus in some cases if a checklist goal was just finished.)"
*/
    public override void RecordEvent() // this needs to be changed to int so it wouldn't have a string, right??
    {
        Console.WriteLine($"Congratulations! You have earned {_points}!");
    }

    /*
        This method should return true if the goal is gompleted. The way you determine if a goal scomplete is different for each type of goal.
    */
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*
    This method should return the details of a goal that could be shown in a LIST. It should include the checkbox, the short name, and description. Then in the case of ChecklistGoal, it should be overridden in the derived class as needed.
    */
    public string GetDetailString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description} - Currently completed: {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}- Currently completed: {_amountCompleted}/{_target})";
        }
    }
    /*
    This method should provide all the details of a goal in a way that is easy to save a file, and then load later.
    */
    public override string GetStringRepresentation()
    {
        // i think this is for the list. I need to go back and find out how to do this
        return $"{_shortName} ({_description}) {_amountCompleted} {_target} {_bonus}";
    }
}