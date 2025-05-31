using System;

public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public void Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMesssage(){
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
    }

    public void DisplayEndingMessage(){
        Console.WriteLine($"Well done!!\n\nYou have completed another {ToString(_duration)} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++

            if(i >= animationStrings.Count)
            {
                i=0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\B \B");
        }
    }
}