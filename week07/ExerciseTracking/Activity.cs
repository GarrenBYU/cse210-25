using System;

public class Activity
{
    private DateTime _date;
    private int _duration;
    protected int _distance;
    protected int _speed;
    protected int _pace;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duation = duration;
    }

    public abstract void distance();
    public abstract void speed();
    // {
    //     _speed = (_distance / minutes) * 60;
    // }
    public abstract void pace();
    // {
    //     _pace = 60 / speed;
    // }

    public virtual string GetSummary()
    {
        return $"{_date} {_activity} ({_duration} min): Distance {_distance}, Speed {_speed} mph, Pace: {_pace} per mile"
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}