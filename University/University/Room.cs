namespace MyApplication;

public class Room
{
    public int Number { get; set; }
    public string Purpose { get; set; }

    public Room(int number, string purpose)
    {
        Number = number;
        Purpose = purpose;
    }
        
    public override bool Equals(object? obj)
    {
        if (obj is Room other)
        {
            return (Purpose == other.Purpose) && (Number == other.Number);
        }
        return false;
    }
}

