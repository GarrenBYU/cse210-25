using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers;
        numbers = new List<int>();
        string newNumber;
        int addNumber;
        int total = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            newNumber = Console.ReadLine();
            addNumber = int.Parse(newNumber);
            numbers.Add(addNumber);
        }while(newNumber != "0");
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (largest < numbers[i])
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {total}");
        float average = ((float)total) / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}