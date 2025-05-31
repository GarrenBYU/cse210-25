using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description){
    }

    public void Run()
    {
        DisplayStartingMesssage();
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());


        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}