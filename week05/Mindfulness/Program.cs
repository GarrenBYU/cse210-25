using System;

class Program
{
    static void Main(string[] args)
    {
        // BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // a1.Run();
        // List<string> prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        // ListingActivity a2 = new ListingActivity(prompts);
        // a2.Run();
        // List<string> reflectingPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        // List<string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        // ReflectingActivity a3 = new ReflectingActivity(reflectingPrompts, questions);
        // a3.Run();
        int choice;
        public int Menu(){
            Console.WriteLine($"Menu Options:\n   1.Start breathing activity\n   2. Start reflecting activity\n   3.Start listing activity\n   4.Quit\nSelect a choice from the menu:")
            choice = int.Parse(Console.ReadLine())
            return choice;
        }
        while (Menu() !== 4)
        {
            switch (choice)
            {
                case 1:
                    BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    a1.Run();
                    break;
                case 2:
                    List<string> reflectingPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
                    List<string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
                    ReflectingActivity a3 = new ReflectingActivity(reflectingPrompts, questions);
                    a3.Run();
                    break;
                case 3:
                    List<string> prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
                    ListingActivity a2 = new ListingActivity(prompts);
                    a2.Run();
                    break;
            }
        }
    }
}