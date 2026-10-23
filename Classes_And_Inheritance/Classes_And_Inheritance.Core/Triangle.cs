namespace Classes_And_Inheritance.Core;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public Triangle(string nameof, double a, double b, double c, double h) : base(nameof, a, b)
    {
        Name = nameof;
        A = a;
        B = b;
        C = c;
        H = h;
    }

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea() => B * H / 2;
    public override double GetPerimeter() => A + B + C;
    private double ValidateC(double c)
    {
        if (c < 0)
        {
            throw new Exception($"El lado: {c}, no es válido.");
        }
        return c;
    }
    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new Exception($"La altura: {h}, no es válida.");
        }
        return h;
    }
}