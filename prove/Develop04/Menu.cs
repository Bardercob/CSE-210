class Menu
{
    public Menu()
    {

    }

    public int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int menuValue = int.Parse(Console.ReadLine());
        return menuValue;
    }
    
}