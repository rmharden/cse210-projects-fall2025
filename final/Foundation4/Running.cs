using System.Runtime.InteropServices;

public class Running : Activity
{
    protected double _distance;
    public Running(string date, string name, double minutes, double distance) : base(date, name, minutes)
    {

    }
    public override double GetDistance()
    {
        return 0;

    }
    public override double GetSpeed()
    {
        return 0;
    }
    public override double GetPace()
    {
        return 0;
    }
    public override string GetSummary()
    {
        return "";
    }
}
