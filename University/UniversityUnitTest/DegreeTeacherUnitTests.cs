using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class DegreeTeacherUnitTests
    {
        [TestMethod]
        public void CheckDutiesDegreeTeacher()
        {
            var dteacher = new DegreeTeacher(new Person("Danilov", "Ivan", null),
                "21458hg",
                new Course("Math", "Probability theoty"), 
                "Doctor of Sciences",
                "Docent");
            string message = dteacher.GetOfficialDuties();
            Assert.AreEqual("Danilov Ivan is a Teacher. Course - Math. Science degree - Doctor of Sciences", message);
        }
    }
}
