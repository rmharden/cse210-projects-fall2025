// Step 4: Create the Square class
public class Square : Shape
{
    private float _side;
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }    
}