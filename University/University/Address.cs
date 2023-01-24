
namespace MyApplication;

internal class Address
{
    private int _houseNumber;
    private int _apartmentNumber;
    public string City { get; set; }
    public string Street { get; set; }
    public int HouseNumber 
    {
        get  
        {
            return _houseNumber; 
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                _houseNumber = value;
            }
        }   
    }
    public int ApartmentNumber 
    {
        get 
        {
            return _apartmentNumber;
        }
        set
        {
            if (value >= 0 && value < 1000)
            {
                _apartmentNumber = value;
            }
            else
            {
                Console.WriteLine("Incorrect input ApartmentNumber");
            }
        }   
    }
    public Address(string city, string street, int housenumber, int apartmentnumber)
    {
        City = city;
        Street = street;
        HouseNumber = housenumber;
        ApartmentNumber = apartmentnumber;
    }
          
    public override bool Equals(object? obj)
    {
        if (obj is Address other)
        {
            bool equalResult = (this.City == other.City) && 
                               (this.Street == other.Street) &&
                               (this.HouseNumber == other.HouseNumber) && 
                               (this.ApartmentNumber == other.ApartmentNumber);
            return equalResult;
        }
        return false;
    }




}