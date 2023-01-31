
namespace MyApplication
{
    public class Candidate
    {
        public Person Person { get; set; }
        public List<SubjectScore> SubjectScores { get; set; }

        public Candidate(Person person, List<SubjectScore> subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Candidate other)
            {
                bool equalResult = (this.Person.Equals(other.Person));
                return equalResult;
            }
            return false;
        }
               
        public bool AddSubject(SubjectScore subjectitem)
        {
            if (SubjectScores.Contains(subjectitem))
            {
                return false;
            }

            SubjectScores.Add(subjectitem);
            return true;
        }
    }
}
