

namespace Employee
{
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        public UniversityEmployee (Person person, string taxId)
        {
            Person = person;
            TaxID = taxId;
        }

        public virtual string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is an Employee";
        }
    }
}
