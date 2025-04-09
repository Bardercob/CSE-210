class Goals
{
    private int _totalPoints;

    public Goals()
    {
        _totalPoints = 0;
    }

    public void AddPoints(int newPoints)
    {
        _totalPoints += newPoints;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}