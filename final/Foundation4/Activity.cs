class Activity
{
    private string _date;
    private int _lengthInMinutes;
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int GetMinutes()
    {
        return _lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        double distance = 50 / 1000 * 0.62;
        return distance;
    }

    public virtual double GetSpeed()
    {
        double speed = _lengthInMinutes;
        return speed;
    }

    public virtual double GetPace()
    {
        double pace = _lengthInMinutes;
        return pace;
    }

    public string GetSummery()
    {
        return $"{_date} {base.ToString()} ({_lengthInMinutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}