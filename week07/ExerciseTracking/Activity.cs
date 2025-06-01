using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity(int duration, DateTime date = default)
    {
        _date = date == default ? DateTime.Now : date;
        _duration = duration;
    }

    public virtual int Distance()
    {
        return (int)_distance;
    }
    public virtual int Speed()
    {
        return (int)_speed;
    }
    public virtual int Pace()
    {
        return (int)_pace;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType()} ({_duration} min): Distance {_distance}, Speed {_speed} mph, Pace: {_pace} per mile";
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}