using System;

namespace NameSorter
{
    public class Program
    {
        /// <summary>
        /// Usage: dotnet run path_to_file
        /// Outputs: A file called "sorted-names-list.txt" into the current directory
        /// Also writes to console the sorted list of names
        /// </summary>
        /// <param name="args">Path to file</param>
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a path to a file containing a newline separated list of unsorted names");
                return;
            }

            var inputFile = args[0];
            const string outputFile = "sorted-names-list.txt";

            var fileContents = NameSorterExecutor.ExecuteSort(inputFile, outputFile);

            Console.Write(fileContents);
        }
    }
}
