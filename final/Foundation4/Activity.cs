public abstract class Activity
{
    protected string _date;
    private string _name;
    protected double _minutes;

    public Activity(string date, string name, double minutes)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}