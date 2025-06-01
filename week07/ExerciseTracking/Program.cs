using System;

class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running(30, 3, default);
        Console.WriteLine(r1.GetSummary());

        StationaryBicycles b1 = new StationaryBicycles(20, 15, 4/30/2025);
        Console.WriteLine(b1.GetSummary());

        Swimming s1 = new Swimming(60, 10, 5/28/2025);
        Console.WriteLine(s1.GetSummary());
    }
}