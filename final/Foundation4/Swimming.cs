public class Swimming : Activity
{
    protected int _laps;
    public Swimming(string date, string name, double minutes, int laps) : base(date, name, minutes)
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