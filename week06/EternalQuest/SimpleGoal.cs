using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal (string name, string description, string points) : base (name, description, points){}

    public override void RecordEvent()
    {
        IsComplete();
        return points;
    }

    public override bool IsComplete()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}|{_isComplete}";
    }
}