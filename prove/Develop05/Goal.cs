public class Goal
{
    public string _goalName;
    public string _description;
    public string _points;
    public Goal()
    {

    }
    public void GetListDetails()
    {
        // This may need to have an if statement for [X] or [ ].
        Console.WriteLine($"[ ] {_goalName} ({_description})");
    }
    public string GetStringRepresentation()
    {
        // this might need a if statement for the [X] or [ ].
        return $"{_points}~|~{_goalName}~|~({_description})";
    }
}


/* 

Displays the user's score. (Is this here or is this in goal manager?)


*/
