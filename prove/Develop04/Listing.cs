public class Listing : Activity
{
    private string _listing;

    public Listing(int seconds, string listing) : base (seconds)
    {
        _listing = listing;
    }

    public string GetListingActivity()
    {
        int seconds = GetSeconds();
        return $"You completed another {seconds} seconds of the {_listing}";
    }
}