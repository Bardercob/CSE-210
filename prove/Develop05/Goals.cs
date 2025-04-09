using System.IO;
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

    public void SaveGoals()
    {
        Console.Write("What is the name of the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach(Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GoalStringForFile());
            }
            
        }
    }

    public void LoadGoals()
    {
        _goalList = [];
        Console.Write("What is the name of the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (line.Contains(":"))
            {
                string[] mainParts = line.Split(":");
                string[] subParts = mainParts[1].Split(",");
                switch (mainParts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(subParts[0], subParts[1], int.Parse(subParts[2]), bool.Parse(subParts[3]));
                        _goalList.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(subParts[0], subParts[1], int.Parse(subParts[2]), bool.Parse(subParts[3]));
                        _goalList.Add(eternalGoal);
                        break;

                    case "CheckListGoal":
                        CheckListGoal checkListGoal = new CheckListGoal(subParts[0], subParts[1], int.Parse(subParts[2]), bool.Parse(subParts[3]), int.Parse(subParts[4]), int.Parse(subParts[5]), int.Parse(subParts[6]));
                        _goalList.Add(checkListGoal);
                        break;
                }
            }
            else
            {
                _totalPoints = int.Parse(line);
            }
            
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}