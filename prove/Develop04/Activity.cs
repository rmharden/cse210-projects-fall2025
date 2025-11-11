public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    // public string GetActivityName()
    // {
    //     return _activityName;
    // }
    // public string GetDescription()
    // {
    //     return _description;
    // }
    public int GetDuration()
    {
        Console.Write("\nHow long in seconds would like your session for? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine($"\nThis activity will help you {_description}");
        GetDuration();
        Console.WriteLine(_duration);
    }
    public void DisplayEndMessage()
    {

    }
    public void ShowSpinnerAnimation()
    {

    }
    public void ShowCountDownTimer()
    {

    }
}