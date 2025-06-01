using System;

public class Swimming : Activity
{
    public Swimming(int duration, int numOfLaps, DateTime date) : base (duration, date)
    {
        _distance = numOfLaps * 50 / 100 * .62;
    }

    public override int Speed()
    {
        _speed = (_distance / GetDuration()) * 60;
        return (int) _speed;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return (int) _pace;
    }
}