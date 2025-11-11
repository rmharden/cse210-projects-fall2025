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
        //Console.WriteLine(_duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation();
        
        // ShowCountDownTimer();
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");

    }
    public void ShowSpinnerAnimation()
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

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

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
    public void ShowCountDownTimer()
    {
        for (int i = 5; i > 0; --i)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}