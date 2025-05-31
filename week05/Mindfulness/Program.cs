using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        a1.Run();
        List<string> prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        ListingActivity a2 = new ListingActivity(,,prompts);
        a2.Run();
    }
}