

namespace Employee
{
    internal class DegreeTeacher: Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank { get; set; }
        public DegreeTeacher(Person person, string taxid, Course course, string sciencedegree, string rank) :
                            base(person, taxid, course)
        {
            ScienceDegree = sciencedegree;
            Rank = rank;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a Teacher. Course - {Course.CourseName}. Science degree - {ScienceDegree}";
        }
    }
}
