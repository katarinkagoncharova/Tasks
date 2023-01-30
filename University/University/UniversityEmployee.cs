

using System.Reflection.Metadata.Ecma335;

namespace MyApplication
{
    internal abstract class UniversityEmployee:IComparable
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        public UniversityEmployee (Person person, string taxId)
        {
            if (taxId != String.Empty )
            {
                Person = person;
                TaxID = taxId;
            }
            else
            {
                throw new ArgumentException("Tax ID cannot be an empty string");
            }
             

        }

        public abstract string GetOfficialDuties();
       
        public override bool Equals(object? obj)
        {
            if (obj is UniversityEmployee other)
            {
                bool equalResult = (this.TaxID == other.TaxID);
                return equalResult;
            }
            return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj is UniversityEmployee other)
            {
                if ((this.Person.Name.Length + this.Person.Surname.Length) >
                   (other.Person.Name.Length + other.Person.Surname.Length))
                {
                    return -1;
                }
                else if ((this.Person.Name.Length + this.Person.Surname.Length) <
                   (other.Person.Name.Length + other.Person.Surname.Length))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            } 
                throw new ArgumentNullException(nameof(other));
        }
        
    }
}
