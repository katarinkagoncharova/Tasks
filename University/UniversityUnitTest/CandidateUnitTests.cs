using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class CandidateUnitTests
    {
        [TestMethod]
        public void CheckCandidatesEqual()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)), null);

            var candidate1 = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)), null);
            Assert.AreEqual(candidate, candidate1);
        }

        [TestMethod]
        public void CheckCandidatesNotEqual()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)), null);

            var candidate1 = new Candidate(new Person("Olga", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)), null);
            Assert.AreNotEqual(candidate, candidate1);
        }

        [TestMethod]
        public void DontAddIfSubjectExist()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });
            var newSubject = new SubjectScore(90, "Math");
            Assert.IsFalse(candidate.AddSubject(newSubject));
            Assert.AreEqual(2, candidate.SubjectScores.Count());
        }

        [TestMethod]
        public void AddSubjectIfNotExist()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });
            var newSubject = new SubjectScore(90, "Language");
            Assert.IsTrue(candidate.AddSubject(newSubject));
            Assert.AreEqual(3, candidate.SubjectScores.Count());
            Assert.IsTrue(candidate.SubjectScores.Contains(newSubject));
        }
    }
}
