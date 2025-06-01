using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    //public GoalManager(){}

    public void Start()
    {
        Console.WriteLine($"Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is {_score}!");
    }

    public void ListGoalNames()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g._shortName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write($"The types of Goals are: \n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhich type of goal would you like to create? ");
        private int _typeOfGoal = int.Parse(Console.ReadLine());
        swith (_typeOfGoal)
        {
            case 1:
                Console.Write($"What is the name of your goal? ");
                private string _name = Console.ReadLine();
                Console.Write($"What is a short description of it? ");
                private string _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                private string _points = Console.ReadLine();
                SimpleGoal _name = new SimpleGoal(_name, _description, _points);
                break;
            case 2:
                Console.Write($"What is the name of your goal? ");
                private string _name = Console.ReadLine();  
                Console.Write($"What is a short description of it? ");
                private string _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                private string _points = Console.ReadLine();
                EternalGoal _name = new EternalGoal(_name, _description, _points);
                break;
            case 3:
                Console.Write($"What is the name of your goal? ");
                private string _name = Console.ReadLine();  
                Console.Write($"What is a short description of it? ");
                private string _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                private string _points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                private string _target = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                private string _bonus = Console.ReadLine();
                ChecklistGoal _name = new ChecklistGoal(_name, _description, _points, _target, _bonus);
                break;
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}