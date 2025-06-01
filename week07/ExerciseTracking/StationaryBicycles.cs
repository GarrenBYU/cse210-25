using System;

public class StationaryBicycles : Activity
{
    public StationaryBicycles(DateTime date, int duration, int speed) : (date, duration)
    {
        _speed = speed;
    }

    public override void Distance()
    {
        _distance = (_speed / 60) * _duration;
    }

    public override void Pace()
    {
        _pace = 60 / _speed;
    }
}