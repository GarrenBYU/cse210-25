using System;

public class Swimming : Activity
{
    private double _distance;
    public Swimming(int duration, int numOfLaps, DateTime date) : base (duration, date)
    {
        _distance = numOfLaps * 50 / 100 * .62;
    }

    public override int Speed()
    {
        double _speed = (_distance / GetDuration()) * 60;
        return (int) _speed;
    }

    public override int Pace()
    {
        double _pace = 60 / Speed();
        return (int) _pace;
    }

    public override int Distance()
    {
        return (int) _distance;
    }
}