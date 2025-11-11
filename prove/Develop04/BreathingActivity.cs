public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreathe in... ");
            ShowCountDownTimer();
            Console.Write($"\nNow breathe out... ");
            ShowCountDownTimer();
            Console.WriteLine(" ");
        }
        DisplayEndMessage();
    }
}