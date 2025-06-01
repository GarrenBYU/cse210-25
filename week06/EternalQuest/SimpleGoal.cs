using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal (string name, string description, string points) : base (name, description, points){}

    public override int RecordEvent()
    {
        _isComplete = true;
        return int.Parse(GetPoints());
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
        return $"{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}||||";
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}