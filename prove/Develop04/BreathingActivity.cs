class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durration): base(name, description, durration)
    {
        
    }

    public void RunActivity()
    {
        DisplayActivityStart();
        RunCountDown("Breath in: ", 4);
        RunCountDown("Breath out: ", 6);
        DisplayActivityEnd();
    }
}