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
        int _typeOfGoal = int.Parse(Console.ReadLine());
        string _name;
        string _description;
        string _points;
        string _target;
        string _bonus;
        switch (_typeOfGoal)
        {
            case 1:
                Console.Write($"What is the name of your goal? ");
                _name = Console.ReadLine();
                Console.Write($"What is a short description of it? ");
                _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                _points = Console.ReadLine();
                SimpleGoal newGoal = new SimpleGoal(_name, _description, _points);
                break;
            case 2:
                Console.Write($"What is the name of your goal? ");
                _name = Console.ReadLine();  
                Console.Write($"What is a short description of it? ");
                _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                _points = Console.ReadLine();
                EternalGoal newGoal = new EternalGoal(_name, _description, _points);
                break;
            case 3:
                Console.Write($"What is the name of your goal? ");
                _name = Console.ReadLine();  
                Console.Write($"What is a short description of it? ");
                _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                _points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                _target = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                _bonus = Console.ReadLine();
                ChecklistGoal newGoal = new ChecklistGoal(_name, _description, _points, _target, _bonus);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine($"The Goals are: ");
        int _count = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{_count}. {g._shortName}");
            _count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int _selectedGoal = int.Parse(Console.ReadLine());
        _score = _score + _goals[_selectedGoal].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.Write($"What is the filename for the goal file? ");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName)){
            outputFile.WriteLine(_score);

            foreach(Goal g in _goals)
            {
                g.GetStringRepresentation();
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines (_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string name = parts[0];
            string description = parts[1];
            string points = parts[2];
            string isComplete = parts[3];
            string amountCompleted = parts[4];
            string target = parts[5];
            string bonus = parts[6];
        }
    }
}