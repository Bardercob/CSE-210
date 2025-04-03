class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durration): base(name, description, durration)
    {
        
    }

    public void RunActivity()
    {
        DisplayActivityStart();
    }
}