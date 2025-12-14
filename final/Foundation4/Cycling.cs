public class Cycling : Activity
{
    protected double _distance;
    protected double _speed;
    public Cycling(string date, string name, double minutes, double distance, double speed) : base(date, name, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
}