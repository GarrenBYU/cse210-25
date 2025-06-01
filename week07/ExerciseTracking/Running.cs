using System;

public class Running : Activity
{
    public Running(DateTime date, int duration, int distance) : (date, duration)
    {
        _distance = distance;
    }

    public override void Speed()
    {
        _speed = (_distance / _duration) * 60;
    }

    public override void Pace()
    {
        _pace = 60 / _speed;
    }
}