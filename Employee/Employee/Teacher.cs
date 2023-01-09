

namespace Employee
{
    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }
        public Teacher(Person person, string taxId, Course course) : base(person, taxId)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.Name} {Person.Surname} is a Teacher. Course is {Course.CourseName}";
        }
    }
}
