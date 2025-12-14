using System.Runtime.InteropServices;

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
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        // this says it is unreachable code. I don't know why.
        
        //return $"{_date}" { GetName()} { _minutes};
        return "";
    }
}