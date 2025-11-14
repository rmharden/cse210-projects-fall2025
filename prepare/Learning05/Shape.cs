// Step 3: Create the base Shape class:
public class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor()
    {

    }
    // I am unsure if the datatype needs to be float or int or something else.
    public virtual double GetArea()
    {
        // I am guessing here.
        return 0;
    }
}
