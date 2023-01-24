namespace MyApplication;

internal class Building:Assets
{
    public Address Address { get; set; }
    public List<Room> Rooms { get; set; }

    public Building(string nameAssets, Address address, List<Room> rooms) : base(nameAssets)
    {
        Address = address;
        Rooms = rooms;
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Building other)
        {
            bool equalResult = (this.Address.Equals(other.Address));
            return equalResult;
        }
        return false;
    }

}
