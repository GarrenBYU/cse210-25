using System;

public class EternalQuest : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points){}

    public override void RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}|false";
    }
}