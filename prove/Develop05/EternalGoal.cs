public class EternalGoal : TypeGoal
{
    private bool _completed;

    public EternalGoal(string name, string description, int amount): base (name, description, amount)
    {
        _completed = false;
    }

    public override string GetTypeGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int amount = GetAmount();
        return $"Eternal Goal:{name},{description},{amount}";
    }
}