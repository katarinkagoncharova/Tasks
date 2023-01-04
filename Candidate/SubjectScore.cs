using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SubjectScore
    {
        public int Score;
        public string SubjectName;
        public SubjectScore(int score, string subjectname)   
        {
            Score = score;
            SubjectName = subjectname;  
        }
    }
}
