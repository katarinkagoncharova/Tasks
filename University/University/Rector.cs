using MyApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication;

internal class Rector : UniversityEmployee
{
    public Rector(Person person, string taxId) : base(person, taxId)
    {

    }

    public override string GetOfficialDuties()
    {
        return $"{Person.Name} {Person.Surname} is a Rector";
    }
}
