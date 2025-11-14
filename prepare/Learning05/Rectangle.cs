// Step 6: Create the Rectangle class

public class Rectangle : Shape
{
    private float _length;
    private float _width;
    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override float GetArea()
    {
        float _area = 0;
        _area = _length * _width;
        return _area;
    }   
}