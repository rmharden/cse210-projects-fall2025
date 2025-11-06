public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    public Activity(string activityName, string description, int duration)
    {
        _activityName = "";
        _description = "";
        _duration = 0;
    }
    // public string GetActivityName()
    // {
    //     return _activityName;
    // }
    // public string GetDescription()
    // {
    //     return _description;
    // }
    // public int GetDuration()
    // {
    //     return _duration;
    // }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}! {_description}");
        Console.WriteLine();
        string input = Console.ReadLine();
        //int _duration = _duration.Parse(input);
        ShowSpinner(_duration);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> _animationStrings = new List<string>();
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        foreach (string s in _animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {

    }
}


/*
Left off at 16:36 of 35:48
https://video.byui.edu/media/t/1_f4017z1d/259941952


*/