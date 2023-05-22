public abstract class TypeGoal
{
    private string _name;
    private string _description;
    private int _amount;

    public TypeGoal(string name, string description, int amount)
    {
        _name = name;
        _description = description;
        _amount = amount;
    }

    public void SetName(string name)
    {
        _name = name; 
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetAmount (int amount)
    {
        _amount = amount;
    }

    public int GetAmount()
    {
        return _amount;
    }
    
    public abstract string GetTypeGoal();
}