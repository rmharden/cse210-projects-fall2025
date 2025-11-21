public class GoalManager
{
    // What are the string goals??
    private string _goals;
    private int _score;
    public GoalManager(string goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    // display the main menu
    // call:
    // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent, Quit
    // Loop until user selects the quit option.
    {
        var choice = "";
        do
        {
            // This is probably going to be called from somewhere else. It's here temporarily.
            Console.WriteLine($"You have {_score} points.");


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

            }
            else if (choice == "2")
            {

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
    public void DisplayPlayerInfo()
    // Display the points
    {

    }
    public void ListGoalNames()
    // Loop through the list of goals and display the names (_shortName)
    // YOU NEED ANOTHER FUNCTION IN THE GOAL CLASS TO BE ABLE TO CALL THE NAMES FROM THE LIST IN GOAL.
    // Example:
    // 1. Read the Scriptures
    // 2. Give a Talk
    {

    }
    public void ListGoalDetails()
    // Loop through the list of goals and display the full details
    // Call the Get GetDetails string function
    {

    }
    public void CreateGoal()
    // Three possible goals we can create
    // Ask the user what type of goal they want to create.
    // Display a sub-menu to select a goal type.
    // Ask for the name, description, and points from the user.
    // Checklist goal needs more information from the user.
    // Create the object that the user selects and add it to the goal list.
    {
        /*
        You have 0 point.

    Menu Options:
    1.	Create New Goal
    2.	List Goals
    3.	Save Goals
    4.	Load Goals
    
    Select a choice from the menu: (cursor is here)1
    The types of Goals are:
    1.	Simple Goal
    2.	Eternal Goal
    3.	Checklist Goal
    Which type of goal would you like to create? (cursor is here) 1
    What is the name of your goal? (cursor is here) Give a talk
    What is a short description of it? (cursor is here) Speak in Sacrament meeting when asked.
    What is the amount of points associated with this goal? (cursor is here) 100
    (These answers are added to a list.)

    */

    var choice = "";
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1.  Simple Goal");
        Console.WriteLine(" 2.  Eternal Goal");
        Console.WriteLine(" 3.  Checklist Goal");


        Console.Write("Which type of goal woudl you like to create? ");
        choice = Console.ReadLine();

        if (choice == "1")
        {

        }
        else if (choice == "2")
        {

        }
        else if (choice == "3")
        {

        }
    }
    public void RecordEvent()
    // Display a list of all of the goal names. 
    // Use the function, ListGoalNames
    // Ask the user to select a goal
    // The user chooses one of the numbers associated with the displayed goal.
    // After they select the goal, call RecordEvent on the correct goal
    // RecordEvent returns integers so we need to update the score based on the points.
    // Display how many points the user currently has now
    {

    }
    public void SaveGoals()
    // Ask user for a file name
    // Loop through the goals and convert each goal to a string and then save the string. 
    // Use the GetStringRepresentation string to convert the goals to a string.
    {

    }
    public void LoadGoals()
    // Ask user for a file name
    // Read each line fot he file and split it up
    // Use the parts to re-create the Goal object

    /*
    Example in a goals.txt file:
    825 <-- Line 1 is the total number of points.
    SimpleGoal|Temple|Go to the temple|100|True
    EternalGoal|Prayer|Say morning prayers|25
    ChecklostGoal|Wake up| Wake up at 5am|10|5|5|500    
    */

    // After line 1, iterate to get the parts between each pipe?
    /* 
    
    Each line after line 1 has: the goal type|_shortName|_description|_points|
    SimpleGoal will show True or False if it is complete or not.
    EternalGoal only has the three atributes.
    ChecklistGoal also has the number of times the user wants to repeat the goal before it is accomplished and it will have bonus points.
    Q. Doesn't the ChecklistGoal also need to show if it was complete or not?

    */
    // If and else if statements.
    // Boolean
    // Based on the first detail in the line, the goal type, it tells the if statement how many things to read.

    {
        SimpleGoal g = new SimpleGoal("name", "description", 0);

        // Option 1: Create some Set Functions
        // Set isComplete, Set Target, Set Bonus

        // Option 2: Make a second constrcutor for SimpleGoal and CheckListGoal
        // The second constructor for SimpleGoal takes in if it was complete: if it was true or false - that way we can set it up to be whatever it was the way we saved it.
        // The second constructor for ChecklistGoal also includes the _isNowCompleted
    }
}