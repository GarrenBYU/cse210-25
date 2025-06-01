using System;

public class Running : Activity
{
    public Running(int duration, int distance, DateTime date) : base (duration, date)
    {
        _distance = distance;
    }

    public override int Speed()
    {
        _speed = (_distance / GetDuration()) * 60;
        return (int)_speed;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return (int) _pace;
    }
}