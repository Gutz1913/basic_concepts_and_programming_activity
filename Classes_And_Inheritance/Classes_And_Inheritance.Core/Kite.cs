namespace Classes_And_Inheritance.Core;

public class Kite : Rhombus
{
    private double _b;
    public Kite(string nameof, double a, double d1, double d2, double b) : base(nameof, a, d1, d2)
    {
        Name = nameof;
        D1 = d1;
        D2 = d2;
        A = a;
        B = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public override double GetArea() => D1 * D2 / 2;
    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new Exception($"El lado: {b}, no es válido.");
        }
        return b;
    }
}