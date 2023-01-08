

namespace Employee
{
    internal class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        public UniversityEmployee (Person person, string taxid)
        {
            Person = person;
            TaxID = taxid;
        }

        public virtual string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is an Employee";
        }
    }
}
