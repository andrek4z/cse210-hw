public class Swimming:Activity
{
    // I used double because If I use int, when I display the results distance and speed appear as 0 km
    private double _laps;
    public Swimming(string date, int lenght, double laps) : base(date, lenght)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000;
    public override double GetSpeed() => GetDistance() / _lenght * 60;
    public override double GetPace() => _lenght / GetDistance();
}