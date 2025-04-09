using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(0);
        Goals goalList = new Goals();
        int menuvalue = 0;
        while (menuvalue != 6)
        {
            menuvalue = menu.DisplayMainMenu();
            switch (menuvalue)
            {
                case 1:
                    int subValue = menu.DisplaySubMenu();
                    switch (subValue)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal();
                            goalList.AddGoal(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal();
                            goalList.AddGoal(eternalGoal);
                            break;
                        case 3:
                            CheckListGoal checkListGoal = new CheckListGoal();
                            goalList.AddGoal(checkListGoal);
                            break;
                    }
                    break;
                
                case 2:
                    goalList.DisplayGoals();
                    break;

                default:
                    break;
            }

        }
    }
}