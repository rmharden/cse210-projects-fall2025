using System.Runtime.InteropServices;

public class Running : Activity
{
    protected double _distance;
    protected double _stepOne;
    public Running(string date, string name, double minutes, double distance) : base(date, name, minutes)
    {

    }
    public override double GetDistance()
    {

    }
    public override double GetSpeed()
    {

    }
    public override double GetPace()
    {
        double minutes = base._minutes();
        _pace = minutes / _distance;
        return _pace;
    }
    public override string GetSummary()
    {
    }
}
