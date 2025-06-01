using System;

//The above and beyond in this program is that there are levels. Every 250 points adds another level to your status.
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