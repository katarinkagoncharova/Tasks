using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class RectorUnitTests
    {
        [TestMethod]
        public void CheckDutiesRector()
        {
            var rector = new Rector(new Person("Danilov", "Ivan", null), "21458hg");
            string message = rector.GetOfficialDuties();
            Assert.AreEqual("Danilov Ivan is a Rector", message);
        }
    }
}
