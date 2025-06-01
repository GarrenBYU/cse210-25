using System;

public class StationaryBicycles : Activity
{
    public StationaryBicycles(DateTime date, int duration, int speed) : base (date, duration)
    {
        _speed = speed;
    }

    public override int Distance()
    {
        _distance = (_speed / 60) * _duration;
        return _distance;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}