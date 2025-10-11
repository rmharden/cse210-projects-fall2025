using System.Diagnostics;

public class Fractions
{
    private int _top;
    private int _bottom;

    private void Fraction()
    {

    }
    private void Fraction(int wholeNumber)
    {
        wholeNumber = 1;
    }

    private void Fraction(int bottom, int top)
    {
        _bottom = bottom;
        _top = top;
    }

    private int GetTop()
    {
        return _top;
    }
    private void SetTop(int top)
    {
        _top = top;
    }
    private int GetBottom()
    {
        return _bottom;
    }
    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    private string GetFractionString()
    {
        return "";
    }
    private double GetDecimalValue()
    {
        return 0;
    }
}