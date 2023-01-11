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

}
