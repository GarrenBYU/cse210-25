using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm1 = new GoalManager();
        while(gm1.GetEnd() != 6)
        {
            gm1.Start();
        }


    }
}