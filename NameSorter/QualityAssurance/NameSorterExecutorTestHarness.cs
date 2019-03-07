using System.IO;
using NUnit.Framework;

namespace NameSorter.QualityAssurance
{
    [TestFixture]
    public class NameSorterExecutorTestHarness
    {
        [TestCase("TestCase1.txt", "ExpectedResult1.txt")]
        [TestCase("TestCase2.txt", "ExpectedResult2.txt")]
        [TestCase("TestCase3.txt", "ExpectedResult3.txt")]
        public void CanSortLargeList(string inputFile, string expectedOutputFile)
        {
            var expectedOutputFilePath = TestHelper.GetResourcePath(expectedOutputFile);
            var expectedFileContents = File.ReadAllText(expectedOutputFilePath);

            var inputFilePath = TestHelper.GetResourcePath(inputFile);
            var fileContents = NameSorterExecutor.ExecuteSort(inputFilePath, "foobar.txt");


            Assert.AreEqual(expectedFileContents, fileContents);
        }
    }
}
