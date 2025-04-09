using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(0);
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
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;
                
                case 2:
                
                    break;

                default:
                    break;
            }

            
            Console.WriteLine(simpleGoal.GoalStringForDisplay());
        }
    }
}