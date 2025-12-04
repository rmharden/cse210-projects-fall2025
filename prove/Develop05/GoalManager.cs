public class GoalManager
{
    private int _scorePoints;
    List<Goal> _goals = new List<Goal>();
    Goal aGoal = new Goal();

    public GoalManager()
    {
        _goals.Add(aGoal);

    }
    public void Start()
    {
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");

        string userResponse = "";
        while (userResponse != "6")
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

            userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                // Create New Goal
                CreateGoal();
            }
            else if (userResponse == "2")
            {
                // List Goals
                ListGoals();
            }
        }
    }
    public void CreateGoal()
    {
        string choice = "";

        Console.WriteLine($"The types of Goals are:");
        Console.WriteLine($"1.  Simple Goal");
        Console.WriteLine($"2.  Eternal Goal");
        Console.WriteLine($"3.  Checklist Goal");

        Console.Write($"\nWhich type of goal would you like to create? ");

        if (choice == "1")
        {
            SimpleGoal sg1 = new SimpleGoal();
        }
        else if (choice == "2")
        {
            EternalGoal eg1 = new EternalGoal();
        }
        else if (choice == "3")
        {
            ChecklistGoal cg1 = new ChecklistGoal();
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
    public void ListGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.GetListDetails();
        }
    }
}

/* 

Displays the user's score. (Is this here or is this in Goal?)

User can create new goals of any type.

The user can record an event (meaning they have accomplished a goal and recieves points.)

Show a list of the goals. This will indicate if the goal has been accomplished or not (for example, [ ] or [X]), and the checklist goals show how many times the goal has been completed, (for example 2/5 times).

The user's goals and their current score are saved and loaded.


*/