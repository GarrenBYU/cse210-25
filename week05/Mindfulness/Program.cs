using System;

// I added logging of what the user has done in this session. You can activate it by choosing option 4 in the menu. 5 is the new quit command.
class Program
{
    static void Main(string[] args)
    {
        int choice;
        int Menu(){
            Console.Write($"Menu Options:\n   1.Start breathing activity\n   2.Start reflecting activity\n   3.Start listing activity\n   4.Display Stats\n   5.Quit\nSelect a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
                    
        BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        List<string> reflectingPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        List<string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        ReflectingActivity a3 = new ReflectingActivity(reflectingPrompts, questions);

        List<string> prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        ListingActivity a2 = new ListingActivity(prompts);


        while (Menu() != 5)
        {
            switch (choice)
            {
                case 1:
                    a1.Run();
                    break;
                case 2:
                    a3.Run();
                    break;
                case 3:
                    a2.Run();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"You completed the breathing activity {a1.GetLog()} times!\nYou completed the reflecting activity {a3.GetLog()} times!\nYou completed the reflecting activity {a2.GetLog()} times!\nWay to go! Keep it going!!");
                    Thread.Sleep(5000);
                    break;
            }
        }
    }
}