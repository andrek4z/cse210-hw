public class Receptions:Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail):base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetStandarDetails()
    {
        return GetTitle()+" - "+GetDescription()+" - "+GetDate()+" - "+GetTime()+" - "+GetAddress().GetAllAddress();
    }
    public string GetFullDetails()
    {
        return GetStandarDetails()+" - "+_rsvpEmail;
    }
    public string GetShortDescription()
    {
        return "Receptions: "+" - "+GetTitle()+" - "+GetDate();
    }
}