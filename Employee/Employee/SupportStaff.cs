

namespace Employee
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Function;
        public SupportStaff(Person person, string taxid, string function): base(person, taxid)
        {
            Function = function;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a {Function}";
        }
    }

}

