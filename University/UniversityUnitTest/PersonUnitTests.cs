using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class PersonUnitTests
    {
        [TestMethod]
        public void CheckFullNameLenght()
        {
            var person = new Person("Ivanov", "Aliaksandr", null);
            Assert.AreEqual(person.FullNameLength(), 16);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckFullNameForPersonOver20Symbol()

        {
            var person = new Person("Antonovskaya", "Aliaksandra", null);
        }

        [TestMethod]
        public void CheckPersonsEqual()
        {
            var person = new Person("Irina", "Smirnova", null);
            var person1 = new Person("Irina", "Smirnova", null);
            Assert.AreEqual(person, person1);
        }

        [TestMethod]
        public void CheckPersonsNotEqual()
        {
            var person = new Person("Anna", "Smirnova", null);
            var person1 = new Person("Irina", "Smirnova", null);
            Assert.AreNotEqual(person, person1);
        }

    }
}
