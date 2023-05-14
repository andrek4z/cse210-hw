public class Reflecting : Activity
{
    private string _reflecting;

    public Reflecting(int seconds, string reflecting) : base (seconds)
    {
        _reflecting = reflecting;
    }

    public string GetReflectingActivity()
    {
        int seconds = GetSeconds();
        return $"You completed another {seconds} seconds of the {_reflecting}";
    }
}