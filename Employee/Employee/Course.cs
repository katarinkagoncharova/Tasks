

namespace Employee
{
    internal class Course
    {
      public string CourseName { get; set; } 
      public string CourseDescripsion { get; set; }
      public Course(string coursename, string coursedescripsion)
        {
            CourseName = coursename;
            CourseDescripsion = coursedescripsion;
        }
    }
}
