

namespace Employee
{
    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }
        public Teacher(Person person, string taxid, Course course) : base(person, taxid)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a Teacher. Course is {Course.CourseName}";
        }
    }
}
