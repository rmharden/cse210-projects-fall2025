public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    public Activity()
    {
        _activityName = "";
        _description = "";
        _duration = 0;

    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        string input = Console.ReadLine();
        int _duration = int.Parse(input);
        ShowSpinner(_duration);
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {
        
    }
}