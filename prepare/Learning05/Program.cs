using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(4, "purple"));
        shapes.Add(new Rectangle(4, 7, "red"));
        shapes.Add(new Circle(4, "blue"));

        foreach(Shape shape in shapes)
        {     
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }



        // Square square = new Square(4);
        // square.SetColor("purple");
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        
        // Rectangle rectangle = new Rectangle(4 ,7);
        // rectangle.SetColor("red");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        // Circle circle = new Circle(4);
        // circle.SetColor("blue");
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
        
    }
}