using System;

public class Fraction
{
    private double _top;
    private double _bottom;

    public Fraction()
    {
        _top = 1;

        _bottom = 1;
    }
    public Fraction(double wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }
    public Fraction(double top, double bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // public GetTop()
    // {

    // }
    // public SetTop(top : int)
    // {
    //     int _top = top;
    // }
    // public GetBottom()
    // {

    // }
    // public SetBottom(bottom : int)
    // {

    // }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        return _top / _bottom;
    }

}