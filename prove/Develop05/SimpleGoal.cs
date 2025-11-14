public class SimpleGoal
{
    string _goalName;
    string _goalDescription;
    public SimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is the a short description of it? ");
        _goalDescription = Console.ReadLine();
    }
}