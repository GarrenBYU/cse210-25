using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        string guess;
        int guessNumber;
        //Console.WriteLine($"The magic number is {number}.");  //For debugging to see what the number is uncomment this line.
        do{
            Console.Write("What is your guess of the number? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if(guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if(guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it! ");
            }
        } while(guessNumber != number);
    }
}