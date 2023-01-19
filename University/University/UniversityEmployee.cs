

namespace MyApplication
{
    internal abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        public UniversityEmployee (Person person, string taxId)
        {
            Person = person;
            TaxID = taxId;
        }

        public abstract string GetOfficialDuties();
        
        
        public override bool Equals(object? obj)
        {
            UniversityEmployee other = obj as UniversityEmployee;
            bool equalResult = (this.TaxID == other?.TaxID);
            return equalResult;
        }

    }
}
