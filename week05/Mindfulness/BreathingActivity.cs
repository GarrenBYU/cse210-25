using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description){
    }

    public void Run()
    {
        DisplayStartingMesssage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());


        while (DateTime.Now < futureTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        LogNumOfTimes();
    }
}