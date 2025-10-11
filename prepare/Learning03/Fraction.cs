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
    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    // Step 5:
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
    // Step 6:
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        // I did not how to do this and I didn't find it in our lesson. I looked at the example to find out how to do this:
        return (double)_top / (double)_bottom;
    }
}

// I looked up what this is and what I found is that the member variables are being converted to a double data type from the int data type.
// return (double)_top/(double)_bottom;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
// This site shows how to convert data types.