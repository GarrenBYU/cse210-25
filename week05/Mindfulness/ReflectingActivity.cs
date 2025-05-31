using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description) : base (name, description){}

    public Run()
    {
        DisplayStartingMesssage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("Consider the following prompt:\n");
        GetRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.")
        Console.ReadLine()
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\nYou may begin in:");
        ShowCountDown(5);
    }

}