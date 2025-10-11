using System.Diagnostics;

public class Fraction
{
    // Step 3:
    private int _top;
    private int _bottom;

    // Step 4:
    public Fraction()
    {
        // Constructor that has no parameters and initializes the number to 1/1.
        _top = 1;
        _bottom = 1;
    }
    // Constructor that has one parameters for the numerator and initializes the denominator as 1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Consturctor that has two parameters for both the numerator and the demominator.
    public Fraction(int bottom, int top)
    {
        _bottom = bottom;
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return "";
    }
    public double GetDecimalValue()
    {
        return 0;
    }
}