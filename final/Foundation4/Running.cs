class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return base.GetPace() / _distance;
    }

    public override double GetSpeed()
    {
        return _distance / base.GetSpeed() * 60;
    }
}