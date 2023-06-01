public class Bicycles:Activity
{
    private double _speed;
    public Bicycles(string date, int lenght, double speed) : base(date, lenght)
    {
         _speed = speed;
     }

    public override double GetDistance() => _lenght * _speed;
    public override double GetSpeed() => _speed;
    public override double GetPace() => _lenght / _speed;
}