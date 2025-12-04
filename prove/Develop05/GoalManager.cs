public class GoalManager
{
    int _scorePoints;
    public GoalManager()
    {
        Console.WriteLine();

    }
    public void Start()
    {
        Console.WriteLine($"You have {_scorePoints}.");
        Console.WriteLine($"\nMenu Options:");
        Console.WriteLine($"1.  Create New Goal");
        Console.WriteLine($"2.  List Goals");
        Console.WriteLine($"3.  Save Goals");
        Console.WriteLine($"4.  Load Goals");
        Console.WriteLine($"5.  Record Event");
        Console.WriteLine($"6.  Quit");
        Console.Write($"Select a choice from the menu: ");
    }
}

/* 

Displays the user's score. (Is this here or is this in Goal?)

User can create new goals of any type.

The user can record an event (meaning they have accomplished a goal and recieves points.)

Show a list of the goals. This will indicate if the goal has been accomplished or not (for example, [ ] or [X]), and the checklist goals show how many times the goal has been completed, (for example 2/5 times).

The user's goals and their current score are saved and loaded.


*/