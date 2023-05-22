public class ChecklistGoal : TypeGoal
{
    private int _times;
    private int _bonus;
    private int _timescompleted;
    private bool _completed;

    public ChecklistGoal(string name, string description, int amount, int bonus, int times, int timescompleted): base (name, description, amount)
    {
        _times = times;
        _bonus = bonus;
        _timescompleted = timescompleted;
        _completed = false;
    }

    public void Complete()
    {
        _completed = true;
        _timescompleted++;
    }

    public override string GetTypeGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int amount = GetAmount();
        return $"Checklist Goal:{name},{description},{amount},{_bonus},{_times},{_timescompleted},{_completed}";
    }
}