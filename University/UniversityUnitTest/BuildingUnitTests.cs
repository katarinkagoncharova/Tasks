using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class BuildingUnitTests
    {
        [TestMethod]
        public void CheckBuildingsEqual()
        {
            var building = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10), null);

            var building1 = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10), null);


            Assert.AreEqual(building, building1);
        }

        [TestMethod]
        public void CheckBuildingsNotEqual()
        {
            var building = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10), null);

            var building1 = new Building("Building", new Address("Minsk", "Bogdanova", 5, 10), null);

            Assert.AreNotEqual(building, building1);
        }
    }
}
