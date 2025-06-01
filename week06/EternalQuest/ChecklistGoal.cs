using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if(IsComplete() == true)
        {
            _points = _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        if(_target <= _amountCompleted)
        {
            return true;
        }
        else{
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if(IsComplete() = true)
        {
            return $"[x]{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[]{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}||{_amountCompleted}|{_target}|{_bonus}";
    }
}