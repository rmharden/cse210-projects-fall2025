// Step 4: Create the Square class
using System.Security.Cryptography.X509Certificates;

public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double _area = 0;
        _area = _side * _side;
        return _area;
    }   
}