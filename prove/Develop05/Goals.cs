class Goals
{
    private int _totalPoints;
    private List<Goal> _goalList ;

    public Goals()
    {
        _totalPoints = 0;
        _goalList = new List<Goal>();
    }

    public void AddPoints(int newPoints)
    {
        _totalPoints += newPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach(Goal goal in _goalList)
        {
            Console.WriteLine($"{goal.GoalStringForDisplay()}");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}