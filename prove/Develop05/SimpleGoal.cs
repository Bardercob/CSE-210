class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool finished) : base(name, description, points, finished)
    {

    }

    public SimpleGoal() : base()
    {

    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You got {GetPoints()} points!");
        SetFinish(true);
        return GetPoints();
    }
    
}