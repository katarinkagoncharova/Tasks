

namespace MyApplication
{
    internal abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        public UniversityEmployee (Person person, string taxId)
        {
            Person = person;
            TaxID = taxId;
        }

        public abstract string GetOfficialDuties();
        //{
            //return $"{Person.Name} {Person.Surname} is an Employee";
        //}
    }
}
