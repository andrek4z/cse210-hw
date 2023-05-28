public class Comments
{
    public string _name;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"{_name} has commented: ");
        Console.WriteLine(_text);
    }
}