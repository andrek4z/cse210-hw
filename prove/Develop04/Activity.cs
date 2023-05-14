public class Activity 
{
    private string _seconds;

    public Activity(string seconds)
    {
        _seconds = seconds;
    }

    public string GetSeconds()
    {
        return _seconds;
    }

    public string GetBreathingActivity()
    {
        return $"Well Done!! \n\nYou have completed another {_seconds} seconds of the Breathing Activity";
    }
}