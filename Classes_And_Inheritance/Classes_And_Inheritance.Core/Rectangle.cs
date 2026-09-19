namespace Classes_And_Inheritance.Core;

public class Rectangle : Square
{
    private double _b;
    public Rectangle(string nameof, double a, double b) : base(nameof, a)
    {
        Name = nameof;
        A = a;
        B = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception($"El lado: {b}, no es válido.");
        }
        return b;
    }
}