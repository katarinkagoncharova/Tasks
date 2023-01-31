
namespace MyApplication
{
    public class Course
    {
      public string CourseName { get; set; } 
      public string CourseDescripsion { get; set; }
      public Course(string courseName, string courseDescripsion)

        {
            CourseName = courseName;
            CourseDescripsion = courseDescripsion;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Course other)
            {
                bool equalResult = (this.CourseName == other.CourseName);
                return equalResult;
            }
            return false;
        }
    }
 }


