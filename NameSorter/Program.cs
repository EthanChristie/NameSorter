using System;

namespace NameSorter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputFile = args[0];
            const string outputFile = "sorted-names-list.txt";

            var fileContents = NameSorterExecutor.ExecuteSort(inputFile, outputFile);

            Console.Write(fileContents);
        }
    }
}
