// Step 3: Create the base Shape class:
// This was my code:
// public class Shape

// This is the code from the sample - forgot to add the "abstract" part:
public abstract class Shape
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
    // This was my code before looking at the sample"
    // public virtual double GetArea()
    // {
    //     // I am guessing here.
    //     return 0;
    // }
    // my code didn't have this part. This is from the sample too:
    public abstract double GetArea();
}
