namespace MyApplication;

public class Address
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
            else
            {
                throw new ArgumentOutOfRangeException("Incorrect house number");
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
                throw new ArgumentOutOfRangeException("Incorrect apartment number"); 
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
            bool equalResult = (City == other.City) && 
                               (Street == other.Street) &&
                               (HouseNumber == other.HouseNumber) && 
                               (ApartmentNumber == other.ApartmentNumber);
            return equalResult;
        }
        return false;
    }




}