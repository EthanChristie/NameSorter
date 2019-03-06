using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var compareName = x.LastName.CompareTo(y.LastName);

            if (compareName == 0)
            {
                return x.GivenNames.CompareTo(y.GivenNames);
            }

            return compareName;
        }
    }
}
