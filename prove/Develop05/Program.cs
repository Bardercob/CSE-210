class Program
{
    static void Main(string[] args)
    {
        Goals goals = new Goals();
        Menu menu = new Menu();
        int menuvalue = 0;
        while (menuvalue != 6)
        {
            menuvalue = menu.DisplayMainMenu(goals.GetTotalPoints());
            switch (menuvalue)
            {
                case 1:
                    int subValue = menu.DisplaySubMenu();
                    switch (subValue)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal();
                            goals.AddGoal(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal();
                            goals.AddGoal(eternalGoal);
                            break;
                        case 3:
                            CheckListGoal checkListGoal = new CheckListGoal();
                            goals.AddGoal(checkListGoal);
                            break;
                    }
                    break;
                
                case 2:
                    goals.DisplayGoals();
                    break;

                case 3:
                    goals.SaveGoals();
                    break;

                case 4:
                    goals.LoadGoals();
                    break;

                case 5:
                    goals.RecordEvent();
                    break;
            }

        }
    }
}