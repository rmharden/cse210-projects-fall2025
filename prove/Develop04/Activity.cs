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
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage(string activityName, string description, int duration)
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {activityName}!");

        Console.WriteLine($"This activity will help you {description}\n");

        Console.WriteLine("How long, in seconds, would you like your session? ");
        string input = Console.ReadLine();
        int userSeconds = int.Parse(input);
        userSeconds = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(duration);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");

        ShowSpinner(_duration);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity.");

        ShowSpinner(_duration);

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
        // foreach (string s in _animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write("\b \b");
        }
    }
}


/*
Left off at 16:36 of 35:48
https://video.byui.edu/media/t/1_f4017z1d/259941952


*/