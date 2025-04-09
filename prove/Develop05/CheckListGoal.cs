class ChecklistGoal : Goal
{
    private int _maxCompletions;
    private int _numberOfCompletions;
    private int _bonusPoints;

    public ChecklistGoal(int maxCompletions, int numberOfCompletions, int bonusPoints, string name, string description, int points, bool finished) : base(name, description, points, finished)
    {
        this._maxCompletions = maxCompletions;
        this._numberOfCompletions = numberOfCompletions;
        this._bonusPoints = bonusPoints;
    }

    public ChecklistGoal() : base()
    {

    }

    public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You got {GetPoints()} points!");
            return GetPoints();
        }

    public override string GoalStringForDisplay()
    {
        return $"{base.GoalStringForDisplay()} -- Currently Completed: {_numberOfCompletions}/{_maxCompletions}";
    }

    public override string GoalStringForFile()
    {
        return $"{base.GoalStringForFile()},{_numberOfCompletions},{_maxCompletions},{_bonusPoints}";
    }

}