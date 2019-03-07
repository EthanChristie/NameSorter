using System;
using System.Collections.Generic;

namespace NameSorter
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var compareName = string.Compare(x.LastName, y.LastName, StringComparison.OrdinalIgnoreCase);

            if (compareName == 0)
            {
                return string.Compare(x.GivenNames, y.GivenNames, StringComparison.OrdinalIgnoreCase);
            }

            return compareName;
        }
    }
}
