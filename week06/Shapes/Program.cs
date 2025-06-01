using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Green", 5);
        Console.WriteLine($"The {s1.GetColor()} shape has an area of {s1.GetArea()}.");

        Rectangle s2 = new Rectangle("Blue", 6, 4);
        Console.WriteLine($"The {s2.GetColor()} shape has an area of {s2.GetArea()}.");

        Circle s3 = new Circle("Red", 8);
        Console.WriteLine($"The {s3.GetColor()} shape has an area of {s3.GetArea()}.");
    }
}