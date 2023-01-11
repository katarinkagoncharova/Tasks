
namespace MyApplication
{
    internal class University
    {
        public Address Address { get; set;}
        public Rector Rector { get; set;}
        public List<UniversityEmployee> Employees { get; set;}
        public List<Building> Buildings { get; set;}

        public University(Address address, Rector rector, List<UniversityEmployee> employees,
                          List<Building> buildings)
        {
            Address = address;
            Rector = rector;
            Employees = employees;
            Buildings = buildings;
        }
    }
}
