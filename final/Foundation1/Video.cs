public class Videos
{
    public string _tittle;
    public string _author;
    public int _length;
    public List<Comments> _comment = new List<Comments>();
    public void Display()
    {
        Console.WriteLine($"Tittle: {_tittle}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Time: {_length} seconds");

        foreach(Comments comments in _comment)
        {
            comments.Display();
        }
    }
}