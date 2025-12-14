public class Swimming : Activity
{
    protected double _laps;
    public Swimming(string date, string name, double minutes, double laps) : base(date, name, minutes)
    {
        _laps = laps;
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