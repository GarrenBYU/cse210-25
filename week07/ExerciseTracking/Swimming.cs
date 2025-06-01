using System;

public class Swimming : Activity
{
    public Swimming(DateTime date, int duration, int numOfLaps) : (date, duration)
    {
        _distance = numOfLaps * 50 / 100 * .62;
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