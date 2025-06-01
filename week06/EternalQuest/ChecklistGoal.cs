using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int _totalPoints = int.Parse(GetPoints());
        if(IsComplete() == true)
        {
            _totalPoints = _totalPoints + _bonus;
        }
        return _totalPoints;
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
        if(IsComplete() == true)
        {
            return $"[x]{GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[]{GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()}|{GetDescription()}|{GetPoints()}||{_amountCompleted}|{_target}|{_bonus}";
    }
}