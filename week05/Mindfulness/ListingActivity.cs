using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(List<string> prompts, string name = "Listing Activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base (name, description){
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMesssage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($" ---{GetRandomPrompt()}--- ");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, _prompts.Count);
        string _firstPrompt = _prompts[initialNumber];
        return _firstPrompt;
    }

    public void GetListFromUser()
    {
        Console.Write("> ");
        Console.ReadLine();
        _count++;
    }
}