using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class SupportStaffUnitTests
    {
        [TestMethod]
        public void CheckDutiesSupportStaff()
        {
            var staff = new SupportStaff(new Person("Danilov", "Ivan", null), "21458hg", "driver");
            string message = staff.GetOfficialDuties();
            Assert.AreEqual("Danilov Ivan is a driver", message);
        }
    }
}
