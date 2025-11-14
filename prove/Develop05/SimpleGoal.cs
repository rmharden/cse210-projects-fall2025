public class SimpleGoal
{
    string _goalName;
    string _goalDescription;
    double _points;
    public SimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is the a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
    }
}