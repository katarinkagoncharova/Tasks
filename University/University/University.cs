
namespace MyApplication
{
    internal class University
    {
        public Address Address { get; set; }
        public Rector Rector { get; set; }
        public List<UniversityEmployee> Employees { get; set; }
        public List<Building> Buildings { get; set; }

        public University(Address address, Rector rector, List<UniversityEmployee> employees,
                          List<Building> buildings)
        {
            Address = address;
            Rector = rector;
            Employees = employees;
            Buildings = buildings;
        }

        public override bool Equals(object? obj)
        {
            University other = obj as University;
            bool equalResult = this.Rector.Equals(other?.Rector);
            return equalResult;
        }

        public bool AddEmployee(UniversityEmployee newEmployee)
        {
            foreach (var employee in Employees)
            {
                if (employee.Equals(newEmployee))
                {
                    return false;
                }

            }
            Employees.Add(newEmployee);
            return true;

        }
    }
}
