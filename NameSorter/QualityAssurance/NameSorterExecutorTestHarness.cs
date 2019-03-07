using System.IO;
using NUnit.Framework;

namespace NameSorter.QualityAssurance
{
    [TestFixture]
    public class NameSorterExecutorTestHarness
    {
        [TestCase("SmallTestCase.txt", "SmallExpectedResult.txt")]
        [TestCase("MediumTestCase.txt", "MediumExpectedResult.txt")]
        [TestCase("LargeTestCase.txt", "LargeExpectedResult.txt")]
        public void CanSortLargeList(string inputFile, string expectedOutputFile)
        {
            var expectedOutputFilePath = TestHelper.GetResourcePath(expectedOutputFile);
            var expectedFileContents = File.ReadAllText(expectedOutputFilePath);

            var inputFilePath = TestHelper.GetResourcePath(inputFile);
            var fileContents = NameSorterExecutor.ExecuteSort(inputFilePath);


            Assert.AreEqual(expectedFileContents, fileContents);
        }
    }
}
