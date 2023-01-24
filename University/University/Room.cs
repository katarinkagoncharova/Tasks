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
        
    public override bool Equals(object? obj)
    {
        if (obj is Room other)
        {
            bool equalResult = (this.Purpose == other.Purpose);
            return equalResult;
        }
        return false;
    }
}

