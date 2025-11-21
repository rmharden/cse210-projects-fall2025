using System.Security.Cryptography.X509Certificates;

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
        Console.Clear();

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
        var choice = "";
        choice = Console.ReadLine();

        Console.WriteLine($"You have {_score} points.");

        Console.WriteLine("\nThe types of goals are: ");
        Console.WriteLine("1.   Simple Goal");
        Console.WriteLine("2.   Eternal Goal");
        Console.WriteLine("3.   Checklist Goal");

        Console.Write("\nWhich goal type would you like to create? ");


        if (choice == "1")
        {
            Console.Write("\nWhat is the name of your goal");
            string shortName = Console.ReadLine();

            Console.Write("\nWhat is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("\nWhat is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal s1 = new SimpleGoal(shortName, description, points);
        }
        else if (choice == "2")
        {
            EternalGoal e1 = new EternalGoal();
        }
        else if (choice == "3")
        {
            ChecklistGoal c1 = new ChecklistGoal();
        }      

    }
    // 2. List Goals
    public void ListGoalNames()
    {

    }
    // 2. List Goals
    public void ListGoalDetails()
    {

    }
    // 3. Save Goals
    public void SaveGoals()
    {

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