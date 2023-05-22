public class SimpleGoal : TypeGoal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int amount, bool _completed): base (name, description, amount)
    {
        _completed = false;
    }

    public void Complete()
    {
        _completed = true;
    }
    
    public override string GetTypeGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int amount = GetAmount();
        return $"Simple Goal:{name},{description},{amount},{_completed}";
    }
}