class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points, bool finished) : base(name, description, points, finished)
    {

    }

    public EternalGoal() : base()
    {

    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You got {GetPoints()} points!");
        return GetPoints();
    }
}