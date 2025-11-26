
using System.IO; 
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    // Display the main menu:
    // Call:
    // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent, and quit
    {
        var choice = "";

        do
        {
            Console.WriteLine($"You have {_score} points.");

            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1.   Create New Goal");
            Console.WriteLine("2.   List Goals");
            Console.WriteLine("3.   Save Goals");
            Console.WriteLine("4.   Load Goals");
            Console.WriteLine("5.   Record Event");
            Console.WriteLine("6.   Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalNames();
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        } while (choice != "6");
    }
    // 1. Create New Goal
    public void CreateGoal()
    {
        Console.WriteLine($"You have {_score} points.");

        Console.WriteLine("\nThe types of goals are: ");
        Console.WriteLine("1.   Simple Goal");
        Console.WriteLine("2.   Eternal Goal");
        Console.WriteLine("3.   Checklist Goal");

        Console.Write("\nWhich goal type would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What are the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            // Console.Write("\nWhat is the name of your goal? ");
            // string shortName = Console.ReadLine();

            // Console.Write("\nWhat is a short description of your goal? ");
            // string description = Console.ReadLine();

            // Console.Write("\nWhat are the amount of points associated with this goal? ");
            // int points = int.Parse(Console.ReadLine());

            SimpleGoal s1 = new SimpleGoal(shortName, description, points);
            _goals.Add(s1);
        }
        else if (choice == "2")
        {
            // Console.Write("\nWhat is the name of your goal? ");
            // string shortName = Console.ReadLine();

            // Console.Write("\nWhat is a short description of your goal? ");
            // string description = Console.ReadLine();

            // Console.Write("\nWhat are the amount of points associated with this goal? ");
            // int points = int.Parse(Console.ReadLine());

            EternalGoal e1 = new EternalGoal(shortName, description, points);
            _goals.Add(e1);
        }
        else if (choice == "3")
        {
            // Console.Write("\nWhat is the name of your goal? ");
            // string shortName = Console.ReadLine();

            // Console.Write("\nWhat is a short description of your goal? ");
            // string description = Console.ReadLine();

            // Console.Write("\nWhat are the amount of points associated with this goal? ");
            // int points = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it in that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            // For amount completed - what is that? Where do I get that?

            ChecklistGoal c1 = new ChecklistGoal(shortName, description, points, 0, target, bonus);
            _goals.Add(c1);
        }

    }
    // 2. List Goals
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }

    }
    // 2. List Goals
    public void ListGoalDetails()
    {

    }
    // 3. Save Goals
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
    

            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }
    // 4. Load Goals
    public void LoadGoals()
    {

    }
    // 5. Record Event
    public void RecordEvent()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
}