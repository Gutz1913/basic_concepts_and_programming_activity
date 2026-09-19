namespace Classes_And_Inheritance.Core;

public class Rhombus : Square
{
    private double _d1;
    private double _d2;

    public Rhombus(string nameof, double a, double d1, double d2) : base(nameof, a)
    {
        Name = nameof;
        D1 = d1;
        D2 = d2;
        A = a; 
    }

    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    public override double GetArea() => D1 * D2 / 2;
    public override double GetPerimeter() => 4 * A;
    private double ValidateD1(double d1)
    {
        if (D1 < 0)
        {
            throw new Exception($"La diagonal: {d1}, no es válida.");
        }
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (D2 < 0 || D2 > D1)
        {
            throw new Exception($"La diagonal: {d2}, no es válida.");
        }
        return d2;
    }
}