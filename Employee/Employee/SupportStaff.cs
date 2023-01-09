

namespace Employee
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Function { get;set;}
        public SupportStaff(Person person, string taxId, string function): base(person, taxId)
        {
            Function = function;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a {Function}";
        }
    }

}

