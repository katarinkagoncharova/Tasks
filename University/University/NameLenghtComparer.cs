namespace MyApplication
{
    public class NameLenghtComparer : IComparer<UniversityEmployee>
    {
        public int Compare(UniversityEmployee x, UniversityEmployee y)
        {
            if (x == null || y == null)
            { 
                throw new ArgumentNullException("Can't compare to null");
            }
            return y.Person.FullNameLength().CompareTo(x.Person.FullNameLength());        
        }
    }
}
