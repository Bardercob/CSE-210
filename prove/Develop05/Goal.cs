 abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    private bool _finished;

    public Goal(string name, string description, int points, bool finished)
    {
        this._goalType = base.ToString();
        this._name = name;
        this._description = description;
        this._points = points;
        this._finished = finished;
    }

    public Goal()
    {
        this._goalType = base.ToString();
        SetName();
        SetDescription();
        SetPoints();
        this._finished = false;
    }

    public void SetName()
    {
        Console.Write("What is the name of your goal? ");
        this._name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("What is a short description for your goal? ");
        this._description = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        this._points = int.Parse(Console.ReadLine());
    }

    public void SetFinish(bool finished)
    {
        _finished = finished;
    }

    public string GetName()
    {
        return this._name;
    }

    public string GetDescription()
    {
        return this._description;
    }

    public int GetPoints()
    {
        return this._points;
    }

    public bool GetFinished()
    {
        return this._finished;
    }

    public abstract int RecordEvent();

    public virtual string GoalStringForDisplay()
    {
        if (_finished)
        {
            string goalString = $"[X] {_name} ({_description})";
            return goalString;
        }
        else
        {
            string goalString = $"[ ] {_name} ({_description})";
            return goalString;
        }
        
        
    }

    public virtual string GoalStringForFile()
    {
        string fileString = $"{_goalType}:{_name},{_description},{_points},{_finished}";
        return fileString;
    }

}