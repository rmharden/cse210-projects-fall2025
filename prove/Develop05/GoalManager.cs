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
        } while (choice != "6");


    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}