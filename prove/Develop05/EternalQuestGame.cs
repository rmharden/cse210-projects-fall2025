class EternalQuestGame
{
    private double _points;
    public EternalQuestGame(double points)
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
                    SimpleGoal s1 = new SimpleGoal();
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
                Console.WriteLine("The goals are:");
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{goal}");
                }

            }
            else if (choice == "3")
            {


            }
            else if (choice == "4")
            {


            }
            else if (choice == "5")
            {


            }
        } while (choice != "6");
    }
    public double GetScore()
    {
        return _points;
    }
}