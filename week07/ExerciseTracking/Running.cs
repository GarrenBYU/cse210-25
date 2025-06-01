using System;

public class Running : Activity
{
    public Running(DateTime date, int duration, int distance) : base (date, duration)
    {
        _distance = distance;
    }

    public override int Speed()
    {
        _speed = (_distance / _duration) * 60;
        return _speed;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}