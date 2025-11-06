public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        Run();
    }
    public void Run()
    {
        DisplayStartingMessage();
        // Activity will run for the length of the amount of seconds the user provided.
        // Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // I need a loop here:
        Console.WriteLine("Breathe in... ");
        // Pause and show countdown:
        Console.WriteLine("Breathe out... ");
        DisplayEndingMessage();
    }
}