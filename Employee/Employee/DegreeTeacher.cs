

namespace Employee
{
    internal class DegreeTeacher: Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank { get; set; }
        public DegreeTeacher(Person person, string taxId, Course course, string scienceDegree, string rank) :
                            base(person, taxId, course)
        {
            ScienceDegree = scienceDegree;
            Rank = rank;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a Teacher. Course - {Course.CourseName}. Science degree - {ScienceDegree}";
        }
    }
}
