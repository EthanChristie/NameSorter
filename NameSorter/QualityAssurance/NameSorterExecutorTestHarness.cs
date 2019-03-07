using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace NameSorter.QualityAssurance
{
    [TestFixture]
    public class NameSorterExecutorTestHarness
    {
        [TestCase("QualityAssurance//Resources//TestCase1.txt", "QualityAssurance//Resources//ExpectedResult1.txt")]
        [TestCase("QualityAssurance//Resources//TestCase2.txt", "QualityAssurance//Resources//ExpectedResult2.txt")]
        public void CanSortLargeList(string inputFile, string expectedOutput)
        {
            var fileContents = NameSorterExecutor.ExecuteSort(inputFile, "foobar.txt");

            var expectedFileContents = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), expectedOutput));

            Assert.AreEqual(expectedFileContents, fileContents);
        }
    }
}
