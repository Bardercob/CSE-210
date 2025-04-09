class CheckListGoal : Goal
{
    private int _maxCompletions;
    private int _currentCompletions;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, bool finished, int maxCompletions, int currentCompletions, int bonusPoints) : base(name, description, points, finished)
    {
        this._maxCompletions = maxCompletions;
        this._currentCompletions = currentCompletions;
        this._bonusPoints = bonusPoints;
    }

    public CheckListGoal() : base()
    {
        SetMaxCompletions();
        SetBonusPoints();
    }

    public void SetMaxCompletions()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        this._maxCompletions = int.Parse(Console.ReadLine());
    }

    public void SetBonusPoints()
    {
        Console.Write("What are the bonus points for accomplishing it that many times? ");
        this._bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetMaxCompletions()
    {
        return _maxCompletions;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You got {GetPoints()} points!");
            return GetPoints();
        }

    public override string GoalStringForDisplay()
    {
        return $"{base.GoalStringForDisplay()} -- Currently Completed: {_currentCompletions}/{_maxCompletions}";
    }

    public override string GoalStringForFile()
    {
        return $"{base.GoalStringForFile()},{_currentCompletions},{_maxCompletions},{_bonusPoints}";
    }

}