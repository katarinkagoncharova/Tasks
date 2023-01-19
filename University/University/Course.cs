
namespace MyApplication
{
    internal class Course
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
            Course other = obj as Course;
            bool equalResult = (this.CourseName == other?.CourseName);
            return equalResult;
        }


    }




 }


