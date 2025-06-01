using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal (string name, string description, string points) : base (name, description, points){}

    public override void RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        if(_isComplete == true)
        {
            return true;
        }
        else{
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}