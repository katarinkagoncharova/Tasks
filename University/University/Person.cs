

namespace MyApplication;

internal class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Address Address { get; set; }
    public Person(string name, string surname, Address address)
    { 
        Name = name; 
        Surname = surname;
        Address = address;
   
    }
    public override bool Equals(object? obj)
    {
        Person other = obj as Person;
        bool equalResult = (this.Name == other?.Name) && (this.Surname == other?.Surname);
        return equalResult;
    }

}
