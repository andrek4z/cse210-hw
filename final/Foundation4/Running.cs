public class Running:Activity
{
    private double _distance;
    public Running(string date, int lenght, double distance) : base(date, lenght)
    {
         _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / _lenght * 60;
    public override double GetPace() => _lenght / _distance;
}