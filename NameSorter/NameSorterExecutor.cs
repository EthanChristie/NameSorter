namespace NameSorter
{
    public class NameSorterExecutor
    {
        public static string ExecuteSort(string inputFile, string outputFile)
        {
            var persons = PersonConverter.DeserializeFromFile(inputFile);

            var nameSorter = new PersonComparer();
            persons.Sort(nameSorter);

            var fileContents = PersonConverter.SerializeToFile(persons, outputFile);
            return fileContents;
        }
    }
}