using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string name;
        string number;
        int square;
        static void DisplayMessage ()
        {
        Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName ()
        {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
        }
        static string PromptUserNumber ()
        {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        return number;
        }
        static int SquareNumber (string number)
        {
        int square = int.Parse(number) * int.Parse(number);
        return square;
        }
        static void DisplayResult (string name, int square)
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
        DisplayMessage();
        name = PromptUserName();
        number = PromptUserNumber();
        square = SquareNumber(number);
        DisplayResult(name, square);
    }
}