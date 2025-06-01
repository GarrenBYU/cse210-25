using System;

public class StationaryBicycles : Activity
{
    private int _speed;
    public StationaryBicycles(int duration, int speed, DateTime date) : base (duration, date)
    {
        _speed = speed;
    }

    public override int Distance()
    {
        double _distance = (_speed / 60) * GetDuration();
        return (int) _distance;
    }

    public override int Pace()
    {
        double _pace = 60 / _speed;
        return (int) _pace;
    }

    public override int Speed()
    {
        return _speed;
    }
}