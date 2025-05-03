using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You're grade is {letterGrade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed the class. You got your next class for sure!");
        }
        else{
            Console.WriteLine("I am afraid you didnt make the cut. You are going to need to retake this course. You got this next time.");
        }
    }
}