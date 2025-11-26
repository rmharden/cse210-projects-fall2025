/*

1. Display the user's score.
2. Allow the user to create new goals of any type.
3. All the user to record an event where they record an event and they reveive points.
4. Show a list of the goals. This shows wheter the goal has been completed or not:
    [ ] compared to [X] and for the checklist goal: Completed 2/5 times.
5. Allow the user's score and the current score to be saved and loaded.

*/
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {

    }
    // This is the "main" function for this class/ It is called by Program.cs and then runs the menu loop.
    public void Start()
    {
        var choice = "";
        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Selecct a choice from the meun:");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
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

            Console.WriteLine();
        } while (choice != "6");
    }
    // This displays the player's current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You now have {_score} points!");
    }
    // This lists the names of each goal.
    // ***** WHY do we list the names separate from the goal details?? is the types of goals?? or is this the user given _shortName goals?? ****
    public void ListGoalNames()
    {

    }
    // This lists the details of each goal (including the checkbox of whether it is complete..... Do I call something here??)
    public void ListGoalDetails()
    {

    }
    // This asks the user for the information about a new goal. Then, it creates the goal and adds it to the list.
    // Is this the sub-menu??
    public void CreateGoal()
    {

    }
    // This asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    // Is this the sub-menu?
    public void RecordEvent()
    {

    }
    // Saves the list of goals to a file.
    public void SaveGoals()
    {

    }
    // Loads the lis of goals from a file.
    public void LoadGoals()
    {

    }
}