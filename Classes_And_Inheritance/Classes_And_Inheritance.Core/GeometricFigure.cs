namespace Classes_And_Inheritance.Core;

public abstract class GeometricFigure
{
    public string Name { get; set; } = string.Empty;
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString() => $"{Name,-10}\t => Area.....:\t{GetArea(),15:N5}   Perimeter:\t{GetPerimeter(),15:N5}";
}
