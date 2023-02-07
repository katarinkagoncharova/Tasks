using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class AddressUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckHouseNumberLess1()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 0, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckHouseNumberMore1000()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 1001, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckAddressApartmentNumberMore1000()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 1010);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckAddressApartmentNumberLess0()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, -1);
        }

        [TestMethod]
        public void CheckAddressEqual()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 10);
            Address address1 = new Address("Minsk", "Bogdanovicha", 10, 10);
            Assert.AreEqual(address, address1);
        }

        [TestMethod]
        public void CheckAddressNotEqual()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 10);
            Address address1 = new Address("Minsk", "Bogdanova", 10, 10);
            Assert.AreNotEqual(address, address1);
        }
    }
}
