public class ListingActivity : Activity
{
    int _count;
    List<string> _prompts;
    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}