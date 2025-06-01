using System;

public class StationaryBicycles : Activity
{
    public StationaryBicycles(int duration, int speed, DateTime date) : base (duration, date)
    {
        _speed = speed;
    }

    public override int Distance()
    {
        _distance = (_speed / 60) * GetDuration();
        return (int) _distance;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return (int) _pace;
    }
}