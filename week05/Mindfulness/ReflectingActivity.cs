using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(List<string> prompts, List<string> questions, string name = "Reflecting Activity", string description = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base (name, description){
        _prompts = prompts;
        _questions = questions;
    }

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
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();
        LogNumOfTimes();
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
        string _nextquestion = _questions[initialNumber];
        return _nextquestion;
    }

    public void DisplayPrompt(){
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(15);
        Console.WriteLine("");
    }

}