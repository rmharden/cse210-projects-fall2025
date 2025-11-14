// Step 4: Create the Square class
using System.Security.Cryptography.X509Certificates;

public class Square : Shape
{
    private float _side;
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }
    public override float GetArea()
    {
        float _area = 0;
        _area = _side * _side;
        return _area;
    }   
}