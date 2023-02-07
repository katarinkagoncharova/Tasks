using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class TeacherUnitTests
    {
        [TestMethod]
        public void CheckDutiesTeacher()
        {
            var teacher = new Teacher(new Person("Danilov", "Ivan", null), "21458hg", new Course("Math", "Probability theoty"));
            string message = teacher.GetOfficialDuties();
            Assert.AreEqual("Danilov Ivan is a Teacher. Course is Math", message);
        }
    }
}
