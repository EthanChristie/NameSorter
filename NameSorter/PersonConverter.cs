using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class PersonConverter
    {
        public static List<Person> DeserializeFromFile(string fileName)
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

        public static string SerializeToFile(List<Person> peopleToSerialize, string fileName)
        {
            var names = peopleToSerialize.Select(p => $"{p.GivenNames} {p.LastName}");

            var sb = new StringBuilder();
            sb.AppendJoin(Environment.NewLine, names);

            var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            using (var file = new StreamWriter(path))
            {
                file.Write(sb.ToString());
            }

            return File.ReadAllText(path);
        }
    }
}