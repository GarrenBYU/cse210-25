using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _end;
    private int _level;

    //public GoalManager(){}

    public void Start()
    {
        DisplayPlayerInfo();
        Console.Write($"Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
        int playerChoice = int.Parse(Console.ReadLine());
        switch (playerChoice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalDetails();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                _end = 6;
                break;
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points and you are a level {_level}.");
    }

    public void ListGoalNames()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetName());
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
        int _target;
        int _bonus;

        Console.Write($"What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.ReadLine();
        switch (_typeOfGoal)
        {
            case 1:
                SimpleGoal newSimpleGoal = new SimpleGoal(_name, _description, _points);
                _goals.Add(newSimpleGoal);
                break;
            case 2:
                EternalGoal newEternalGoal = new EternalGoal(_name, _description, _points);
                _goals.Add(newEternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                _target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                _bonus = int.Parse(Console.ReadLine());
                ChecklistGoal newChecklistGoal = new ChecklistGoal(_name, _description, _points, _target, _bonus);
                _goals.Add(newChecklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine($"The Goals are: ");
        int _count = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{_count}. {g.GetName()}");
            _count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int _selectedGoal = int.Parse(Console.ReadLine());
        _score = _score + _goals[_selectedGoal - 1].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.Write($"What is the filename for the goal file? ");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName)){
            outputFile.WriteLine($"{_score}");

            foreach(Goal g in _goals)
            {
                outputFile.Write($"{g.GetType()}|");
                outputFile.WriteLine(g.GetStringRepresentation());
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
            if (line == lines[0])
            {
                _score = int.Parse(line);
            }
            else
            {
            string[] parts = line.Split("|");

            string classType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            string isComplete = parts[4];
            string amountCompleted = parts[5];
            string target = parts[6];
            string bonus = parts[7];
            
            switch (classType){
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    bool result;
                    simpleGoal.SetIsComplete(bool.TryParse(isComplete, out result));
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, int.Parse(target), int.Parse(bonus));
                    checklistGoal.SetAmountCompleted(int.Parse(amountCompleted));
                    _goals.Add(checklistGoal);
                    break;
            }
            }
        }
    }
    public int GetEnd()
    {
        return _end;
    }

    public int Getlevel()
    {
        _level = _score / 250;
        return _level;
    }
}