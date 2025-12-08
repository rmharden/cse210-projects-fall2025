using System.Reflection.Metadata;

public class GoalManager
{
    private int _scorePoints;
    List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {

    }
    public void DisplayUserScore()
    {
        Console.WriteLine($"You have {_scorePoints}");
    }
    public void Start()
    {
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");

        string userResponse = "";
        while (userResponse != "6")
        {
            DisplayUserScore();

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
            else if (userResponse == "3")
            {
                // Save Goals
                SaveGoals();
            }
            else if (userResponse == "4")
            {
                // Load Goals
                LoadGoals();
            }
            else if (userResponse == "5")
            {
                // Record Event
                RecordEvent();
            }
            else if (userResponse == "6")
            {
                Console.WriteLine("Thank you for using the Eternal Quest Program!");
            }
            else
            {
                Console.WriteLine("Invalid number.\n");
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
            // SimpleGoal sg1 = new SimpleGoal();
            // _goals.Add(aGoal); // Not sure this is right
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
        ListGoalDetails();
    }
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name of the file? ");
        string fileName = Console.ReadLine();

        // is this the Goal class with the GetStringRepresentation?
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_scorePoints);
            foreach (Goal goal in _goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine($"{fileName} saved.");
    }
    public void LoadGoals()
    {
        Console.WriteLine("\nWhat is the name of the file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            // I'm not sure this is correct.
            string[] parts = line.Split("~|~");
            int _points = int.Parse(parts[0]);
            string _goalName = parts[1];
            string _description = parts[2];

            _goals.Add(/*I need an object of goal, right?*/);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("\nWhich goal did you accomplish? ");
        string userInput = Console.ReadLine();


    }
    public void ListGoalNames()
    {
        int numbersCount = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numbersCount}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetListDetails}");
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