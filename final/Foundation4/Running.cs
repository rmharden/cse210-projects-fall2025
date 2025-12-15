public class Running : Activity
{
    protected double _distance;
    public Running(string date, string name, double minutes, double distance) : base(date, name, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
}
