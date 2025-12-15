public class Swimming : Activity
{
    protected double _laps;
    public Swimming(string date, string name, double minutes, double laps) : base(date, name, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;

    }
    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return "";
    }
}