using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public Address Address;
        public Person(string name, string surname, Address address)
        { 
            Name = name; 
            Surname = surname;
            Address = address;
       
        }
 
    }
}
