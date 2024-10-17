using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(5);
        Fraction c = new Fraction(3, 4);
        Fraction d = new Fraction(1, 3);
        Console.WriteLine(a.GetFractionString() + " " + a.GetDecimal());
        Console.WriteLine(b.GetFractionString() + " " + b.GetDecimal());
        Console.WriteLine(c.GetFractionString() + " " + c.GetDecimal());
        Console.WriteLine(d.GetFractionString() + " " + d.GetDecimal());
    }
}

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public Fraction(int whole)
    {
        _top = whole;
        _bottom = 1;
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
        return $"{_top}/{_bottom}";
    }
    public double GetDecimal()
    {
        return (double)_top/(double)_bottom;
    }
}