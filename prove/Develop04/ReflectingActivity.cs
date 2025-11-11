using System.Security.Cryptography;

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
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");

        Console.Write("You may begin in: ");
        ShowCountDownTimer();
        Console.WriteLine(" ");

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write($"\n{GetRandomQuestion()} ");
                ShowSpinnerAnimation();
                Thread.Sleep(1000);
            }
        }
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random r1 = new Random();
        List<string> _prompts = new List<string>()
        { 
            "1. Think of a time when you stood up for someone else.",
            "2. Think of a time when you did something really difficult.",
            "3. Think of a time when you helped someone in need.",
            "4. Think of a time when you did something truly selfless."
        };
        int i1 = r1.Next(_prompts.Count);
        return _prompts[i1];
    }
    public string GetRandomQuestion()
    {
        Random r2 = new Random();
        List<string> _questions = new List<string>()
        {
            "> 1. Why was this experience meaningful to you?",
            "> 2. Have you ever done anything like this before?",
            "> 3. How did you get started?",
            "> 4. How did you feel when it was complete?",
            "> 5. What made this time different than other times when you were not as successful?",
            "> 6. What is your favorite thing about this experience?",
            "> 7. What could you learn from this experience that applies to other situations?",
            "> 8. What did you learn about yourself through this experience?",
            "> 9. How can you keep this experience in mind in the future?"
        };
        int i2 = r2.Next(_questions.Count);
        return _questions[i2];
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {

    }
}