using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(int duration, DateTime date = default)
    {
        _date = date == default ? DateTime.Now : date;
        _duration = duration;
    }

    public abstract int Distance();
    public abstract int Speed();
    public abstract int Pace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType()} ({_duration} min): Distance {Distance()}, Speed {Speed()} mph, Pace: {Pace()} per mile";
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}