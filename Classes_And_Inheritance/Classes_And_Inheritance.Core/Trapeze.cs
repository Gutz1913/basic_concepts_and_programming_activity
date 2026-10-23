namespace Classes_And_Inheritance.Core;

public class Trapeze : Triangle
{
    private double _d;
    public Trapeze(string nameof, double a, double b, double c, double d, double h) : base(nameof, a, b, c, h)
    {
        Name = nameof;
        A = a;
        B = b;
        C = c;
        D = d;
        H = h;
    }

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public override double GetArea() => (B + D) * H / 2;
    public override double GetPerimeter() => A + B + C + D;
    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new Exception($"El lado: {d}, no es válido.");
        }
        return d;
    }
}