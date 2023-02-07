using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class CourseUnitTests
    {
        [TestMethod]
        public void CheckCoursesEqual()
        {
            var course = new Course("Math", "Probability theoty");
            var course1 = new Course("Math", "Algebra");
            Assert.AreEqual(course, course1);
        }

        [TestMethod]
        public void CheckCoursesNotEqual()
        {
            var course = new Course("Math", "Probability theoty");
            var course1 = new Course("Language", "Belarusian language course");
            Assert.AreNotEqual(course, course1);
        }
    }
}
