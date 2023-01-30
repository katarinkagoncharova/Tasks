using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    internal class NameSurnameLenghtComparer : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee? x, UniversityEmployee? y)
        {
            return (y.Person.Name.Length + y.Person.Surname.Length).CompareTo(x.Person.Name.Length + x.Person.Surname.Length);
        }
    }
}
