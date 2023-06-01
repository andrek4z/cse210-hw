public class Lectures: Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity):base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetStandarDetails()
    {
        return GetTitle()+" - "+GetDescription()+" - "+GetDate()+" - "+GetTime()+" - "+GetAddress().GetAllAddress();
    }
    public string GetFullDetails()
    {
        return GetStandarDetails()+" "+_speaker+" "+_capacity;
    }

    public string GetShortDescription()
    {
        return "Lectures: "+" - "+GetTitle()+" - "+GetDate();
    }
}