public class Breathing : Activity
{
    private string _breathing;

    public Breathing(int seconds, string breathing) : base (seconds)
    {
        _breathing = breathing;
    }

    public string GetBreathingActivity()
    {
        int seconds = GetSeconds();
        return $"You completed another {seconds} seconds of the {_breathing}";
    }
}