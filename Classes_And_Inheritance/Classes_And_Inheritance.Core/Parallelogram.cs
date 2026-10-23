namespace Classes_And_Inheritance.Core;

public class Parallelogram : Rectangle
{
    private double _h;

    public Parallelogram(string nameof, double a, double b, double h) : base(nameof, a, b)
    {
        Name = nameof;
        A = a;
        B = b;
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception($"La altura: {h}, no es válida.");
        }
        return h;
    }
}