class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int lengthInMinutes, int numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (double)_numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return base.GetPace() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / base.GetSpeed() * 60;
    }

}