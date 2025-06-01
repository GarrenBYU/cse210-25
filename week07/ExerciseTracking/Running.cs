using System;

public class Running : Activity
{
    public Running(DateTime date, int duration, int distance) : (date, duration)
    {
        _distance = distance;
    }

    public override void speed()
    {
        _speed = (_distance / _duration) * 60;
    }

    public override void pace()
    {
        _pace = 60 / _speed;
    }
}