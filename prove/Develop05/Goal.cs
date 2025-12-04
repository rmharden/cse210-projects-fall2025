public class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _points;
    public Goal()
    {

    }
    public void GetListDetails()
    {
        // This may need to have an if statement for [X] or [ ].
        Console.WriteLine($"[ ] {_goalName} ({_description})");
    }
}


/* 

Displays the user's score. (Is this here or is this in goal manager?)


*/
