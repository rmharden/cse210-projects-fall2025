class EternalQuestGame
{
    private List<Goal> _goals;
    private int _points;
    public EternalQuestGame(int points)
    {
        points = _points;
    }

    public void Menu()
    {
        List<Goal> _goals = new List<Goal>();
        Console.Clear();
        var choice = "";
        do
        {
            Console.WriteLine($"You have {GetScore()} points.");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1.  Create New Goal");
            Console.WriteLine(" 2.  List Goals");
            Console.WriteLine(" 3.  Save Goals");
            Console.WriteLine(" 4.  Load Goals");
            Console.WriteLine(" 5.  Record Event");
            Console.WriteLine(" 6.  Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                var userInput = "";
                Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine(" 1.  Simple Goal");
                Console.WriteLine(" 2.  Eternal Goal");
                Console.WriteLine(" 3.  Checklist Goal");

                Console.Write("\nWhich type of goal would you like to create? ");

                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.Write("\nWhat is the name of the goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("\nWhat is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("\nWhat is the amount of points associated with this goal?  ");
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal s1 = new SimpleGoal(goalName, goalDescription, points);
                    
                }
                else if (userInput == "2")
                {
                    EternalGoal e1 = new EternalGoal();
                }
                else if (userInput == "3")
                {
                    ChecklistGoal c1 = new ChecklistGoal();
                }
            }
            else if (choice == "2")
            {
                LoadGoals();
            }
            else if (choice == "3")
            {
                ListGoalNames();
            }
            else if (choice == "4")
            {
                SaveGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        } while (choice != "6");
    }
    public double GetScore()
    {
        return _points;
    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetals()
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
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal}");
        }
    }
}