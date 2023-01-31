namespace MyApplication
{
    public abstract class UniversityEmployee:IComparable
    { 
        private string _taxId; 
        public Person Person { get; set; }
        public string TaxId 
        {
            get 
            { 
                return _taxId; 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect taxId");
                }
                else
                {
                    _taxId = value;  
                }
            }
        }

        public UniversityEmployee (Person person, string taxId)
        {
                Person = person;
                TaxId = taxId;
        }

        public abstract string GetOfficialDuties();
       
        public override bool Equals(object? obj)
        {
            if (obj is UniversityEmployee other)
            {
                return TaxId == other.TaxId;
            }
            return false;
        }

        public int CompareTo(object? obj)
        {
            if (obj is UniversityEmployee other)
            {
                return other.Person.FullNameLength() - Person.FullNameLength();
            } 
                throw new ArgumentException("Obj isn't UniversityEmployee");
        }
        
    }
}
