namespace MyApplication;

internal class Room
{
    public int Number { get; set; }
    public string Purpose { get; set; }

    public Room(int number, string purpose)
    {
        Number = number;
        Purpose = purpose;
    }
}
