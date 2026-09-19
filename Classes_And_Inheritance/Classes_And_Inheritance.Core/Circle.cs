namespace Classes_And_Inheritance.Core;

public class Circle : GeometricFigure
{
    private double _r;

    public Circle(string nameof, double r)
    {
        Name = nameof;
        R = r;
    }

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public override double GetArea() => Math.PI * Math.Pow(R,2);
    public override double GetPerimeter() => 2 * Math.PI * R;

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new Exception($"El radio: {r} no es válido.");
        }
        return r;
    }
}