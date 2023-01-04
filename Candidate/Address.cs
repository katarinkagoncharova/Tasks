using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Address
    {
        public string City;
        public string Street;
        public int HouseNumber;
        public int ApartmentNumber;
        public Address(string city, string street, int housenumber, int apartmentnumber)
        {
            City = city;
            Street = street;
            HouseNumber = housenumber;
            ApartmentNumber = apartmentnumber;

        }
    }
}