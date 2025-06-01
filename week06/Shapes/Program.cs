using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Green", 5);
        shapes.Add(s1);
        //Console.WriteLine($"The {s1.GetColor()} shape has an area of {s1.GetArea()}.");

        Rectangle s2 = new Rectangle("Blue", 6, 4);
        shapes.Add(s2);
        // Console.WriteLine($"The {s2.GetColor()} shape has an area of {s2.GetArea()}.");

        Circle s3 = new Circle("Red", 8);
        shapes.Add(s3);
        // Console.WriteLine($"The {s3.GetColor()} shape has an area of {s3.GetArea()}.");

        foreach(Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }
    }
}