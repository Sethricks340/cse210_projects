using System;

public class Circle : Shape
{
    public double _radius;

    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2) ;
    }
}