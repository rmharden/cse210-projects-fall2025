public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        
    }
}