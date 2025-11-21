public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override int RecordEvent()
    {
        // If we previously were not complete, then mark complete and return points.

        // What if we previously were complete? 
        return 0;
    }
    public override bool isComplete()
    {
        // Return back wheter this goal is complete or not
        return false;
    }
    public override string GetStringRepresentation()
    {
        // Test:
        return $"You have {_points} points.\n [X] {_shortName} ({_description})";
    }
}

/*
    Console.Writeline("Which type of goal would you like to create?");
    Console.Writeline("What is the name of your goal?");
    Console.Writeline("What is a short description of it?");
    Console.Writeline("What is the amount of points associated with this goal?");
    
*/