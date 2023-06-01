public class OutdoorGathering:Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather):base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetStandarDetails()
    {
        return GetTitle()+" - "+GetDescription()+" - "+GetDate()+" - "+GetTime()+" - "+GetAddress().GetAllAddress();
    }
    public string GetFullDetails()
    {
        return GetStandarDetails()+" - "+_weather;
    }
    public string GetShortDescription()
    {
        return "Outdoor Gathering: "+" - "+GetTitle()+" - "+GetDate();
    }
}