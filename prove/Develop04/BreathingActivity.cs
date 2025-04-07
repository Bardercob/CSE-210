class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durration): base(name, description, durration)
    {
        
    }

    public void RunActivity()
    {
        DisplayActivityStart();
        SetDurration();
        MakeSpinner("Get Ready...", 5);
        DateTime rightNow = DateTime.Now;
        DateTime endTime = rightNow.AddSeconds(GetDurration());
        while(DateTime.Now < endTime)
        {
            RunCountDown("Breath in: ", 4);
            RunCountDown("Breath out: ", 6);
        }
        DisplayActivityEnd($"You have completed another {GetDurration()} seconds of the breathing activity.");
    }
}