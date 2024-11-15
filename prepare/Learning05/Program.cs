using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();
        Square square= new Square("blue", 6);
        Rectangle rectangle= new Rectangle("red", 9, 12.2);
        Circle circle= new Circle("green", 14.8);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Color);
            Console.WriteLine(shape.GetArea());
        }
    }
}