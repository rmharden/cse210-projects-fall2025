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