
namespace MyApplication
{
    internal class Candidate
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
            Candidate other = obj as Candidate;
            bool equalResult = this.Person.Equals(other?.Person);
            return equalResult;
        }

        public bool AddSubject(SubjectScore subjectitem)
        {
            foreach (var subjectScore in SubjectScores) 
            {
                if (subjectScore.Equals(subjectitem))
                {
                    return false;
                }
             
            }
            SubjectScores.Add(subjectitem);
            return true;
        }

    }

}
