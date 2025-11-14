// Step 6: Create the Circle class

public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double _area = 0;
        double _radiusSquared = _radius * _radius;
        _area = _radiusSquared * Math.PI;
        return _area;
    }
}
// Site I used to know how to get Pi in C# .Net:
// https://learn.microsoft.com/en-us/dotnet/api/system.math.pi?view=net-9.0