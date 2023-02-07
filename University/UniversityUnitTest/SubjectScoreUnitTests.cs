using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class SubjectScoreUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckHouseNumberLess1()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 0, 7);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckScoreLess1()
        {
            var subjectScore = new SubjectScore(-10, "Math");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckScoreMore100()
        {
            var subjectScore = new SubjectScore(101, "Math");
        }

        [TestMethod]
        public void CheckSubjectScoresNotEqual()
        {
            var subjectScore = new SubjectScore(70, "Math");
            var subjectScore1 = new SubjectScore(60, "Physics");
            Assert.AreNotEqual(subjectScore, subjectScore1);
        }

        [TestMethod]
        public void CheckSubjectScoresEqual()
        {
            var subjectScore = new SubjectScore(70, "Physics");
            var subjectScore1 = new SubjectScore(60, "Physics");
            Assert.AreEqual(subjectScore, subjectScore1);
        }

    }
}
