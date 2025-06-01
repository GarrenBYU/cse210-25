using System;

public class Swimming : Activity
{
    public Swimming(DateTime date, int duration, int numOfLaps) : base (date, duration)
    {
        _distance = numOfLaps * 50 / 100 * .62;
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