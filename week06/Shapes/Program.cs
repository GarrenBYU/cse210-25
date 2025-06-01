using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square s1 = new Square("Green", 5);
        Console.WriteLine($"The {s1.GetColor()} shape has an area of {s1.GetArea()}.");
    }
}