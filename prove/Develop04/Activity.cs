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
    public void DisplayStartMessage()
    {

    }
    public void DisplayEndMessage()
    {

    }
    public void ShowSpinnerAnimation()
    {

    }
    public void ShowCountDownTimer()
    {

    }
}