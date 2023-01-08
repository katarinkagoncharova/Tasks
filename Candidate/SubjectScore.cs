
namespace ConsoleApp2
{
    internal class SubjectScore
    {
        private int _score;
        public int Score 
        {
            get
            {
                return _score;
            }
            set
            {
                if (value > 0 && value < 101)
                { 
                    _score = value;
                }
            }
         }
        public string SubjectName { get; set; }
        public SubjectScore(int score, string subjectname)   
        {
            Score = score;
            SubjectName = subjectname;  
        }
    }
}
