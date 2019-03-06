using System;
using System.Collections.Generic;

namespace NameSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "input-file.txt";

            var persons = PersonConverter.DeserializeFromFile(fileName);

            var nameSorter = new PersonComparer();

            persons.Sort(nameSorter);

            var sortedPersons = PersonConverter.SerializeToFile("sorted-names-list.txt");
        }
    }
}
