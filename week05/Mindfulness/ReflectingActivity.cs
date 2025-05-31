using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = List<string> {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private List<string> _questions = List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public ReflectingActivity(string name = "Reflecting Activity", string description = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base (name, description){}

    public void Run()
    {
        DisplayStartingMesssage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\nYou may begin in:");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, _prompts.Count);
        string _nextPrompt = _prompts[initialNumber];
        return _nextPrompt;
    }

    public string GetRandomQuestion(){
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, _questions.Count);
        string _nextquestion = _prompts[initialNumber];
        return _nextquestion;
    }

    public void DisplayPrompt(){
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(15);
    }

}