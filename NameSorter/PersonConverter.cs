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
                var indexesOfDelimiter = line.AllIndexesOf(' ').ToList();
                var lastIndexOfDelimiter = indexesOfDelimiter.Last();

                var givenNames = line.Substring(0, lastIndexOfDelimiter);
                var lastName = line.Substring(lastIndexOfDelimiter).Trim();

                namesInFile.Add(new Person(givenNames, lastName));
            }

            return namesInFile;
        }

        public static string SerializeToFile(List<Person> peopleToSerialize, string fileName)
        {
            var names = peopleToSerialize.Select(p => $"{p.GivenNames} {p.LastName}");

            var sb = new StringBuilder();
            sb.AppendJoin(Environment.NewLine, names);
            var fileContents = sb.ToString();

            if (fileName != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                using (var file = new StreamWriter(path))
                {
                    file.Write(fileContents);
                }
            }
            
            return fileContents;
        }
    }
}