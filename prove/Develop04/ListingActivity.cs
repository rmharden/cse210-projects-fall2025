public class ListingActivity : Activity
{
    int _count;
    List<string> _prompts;
    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        int duration = GetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnerAnimation();

        Console.WriteLine("\nList as many responses to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountDownTimer();

        List<string> _usersList = GetListFromUser();  

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n> ");
            _usersList.Add(Console.ReadLine());
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You listed {_usersList.Count} items!");
        DisplayEndMessage();
    }
    public string GetRandomPrompt()
    {
        Random r1 = new Random();
        List<string> _prompts = new List<string>()
        {
            "> 1. Who are people that you appreciate?",
            "> 2. What are personal strengths of yours?",
            "> 3. Who are people that you have helped this week?",
            "> 4. When have you felt the Holy Ghost this month?",
            "> 5. Who are some of your personal heroes?"
        };
        int i = r1.Next(_prompts.Count);
        return _prompts[i];
    }
    public List<string> GetListFromUser()
    {
        List<string> _usersList = new List<string>();
        return _usersList;
    }
}