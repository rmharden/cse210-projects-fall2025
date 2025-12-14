public class Swimming : Activity
{
    protected double _distance;
    public Swimming(string date, string name, double minutes, double distance) : base(date, name, minutes)
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