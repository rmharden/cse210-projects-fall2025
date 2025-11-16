public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is the a short description of it? ");
        goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }
    public override void RecordEvent()
    {

    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override bool IsComplete()
    {
        return false;
    }
}