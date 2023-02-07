using MyApplication;


namespace UniversityUnitTests
{
    [TestClass]
    public class RoomsUnitTests
    {
        [TestMethod]
        public void CheckRoomsNotEqual()
        {
            var room = new Room(101, "lecture");
            var room1 = new Room(101, "laboratory");
            Assert.AreNotEqual(room, room1);
        }

        [TestMethod]
        public void CheckRoomsEqual()
        {
            var room = new Room(101, "lecture");
            var room1 = new Room(101, "lecture");
            Assert.AreEqual(room, room1);
        }
    }
}
