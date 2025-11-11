public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation();

        Console.WriteLine("Consider the folowing prompt:");
        Console.WriteLine($"\n{GetRandomPrompt()}");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            

        }
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {

    }
}