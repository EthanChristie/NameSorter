using System;
using System.Collections.Generic;

namespace NameSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "input-file.txt";

            var persons = PersonDeserializer.DeserializeFromFile("input-file.txt");

            var names = new List<Person>();



            var sortedNames = NameSorter.Sort(names);
        }
    }
}
