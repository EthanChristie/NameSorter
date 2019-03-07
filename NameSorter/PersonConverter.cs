using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class PersonConverter
    {
        internal static List<Person> DeserializeFromFile(string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            var lines = File.ReadAllLines(path);

            var namesInFile = new List<Person>();

            foreach (var line in lines)
            {
                var indexes = line.AllIndexesOf(' ');
                var lastIndex = indexes[indexes.Count - 1];

                var givenNames = line.Substring(0, lastIndex);
                var lastName = line.Substring(lastIndex).Trim();

                namesInFile.Add(new Person(givenNames, lastName));
            }

            return namesInFile;
        }

        internal static object SerializeToFile(string v)
        {
            throw new NotImplementedException();
        }
    }
}