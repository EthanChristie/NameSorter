using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NameSorter.QualityAssurance
{
    [TestFixture]
    public class PersonConverterTestHarness
    {
        [Test]
        public void CanDeserializeOneName()
        {
            var johnSmith = new Person("John", "Smith");
            var expectedList = new List<Person> { johnSmith };

            var filePath = TestHelper.GetResourcePath("SinglePersonTest.txt");
            var actualList = PersonConverter.DeserializeFromFile(filePath);

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void CanDeserializeManyNames()
        {
            var johnSmith = new Person("John", "Smith");
            var johnAardvarkJones = new Person("John Aardvark", "Jones");
            var bobBarrymoreFredDylan = new Person("Bob Barrymore Fred", "Dylan");

            var expectedList = new List<Person> { johnSmith, johnAardvarkJones, bobBarrymoreFredDylan };

            var filePath = TestHelper.GetResourcePath("MultiplePersonTest.txt");
            var actualList = PersonConverter.DeserializeFromFile(filePath);

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void CanSerializeOneName()
        {
            var johnSmith = new Person("John", "Smith");
            var listToSerialize = new List<Person> { johnSmith };

            var filePath = TestHelper.GetResourcePath("SinglePersonDeserializationTest.txt");
            var fileContents = PersonConverter.SerializeToFile(listToSerialize, filePath);

            Assert.AreEqual("John Smith", fileContents);
        }

        [Test]
        public void CanSerializeManyNames()
        {
            var johnSmith = new Person("John", "Smith");
            var johnAardvarkJones = new Person("John Aardvark", "Jones");
            var bobBarrymoreFredDylan = new Person("Bob Barrymore Fred", "Dylan");

            var listToSerialize = new List<Person> { johnSmith, johnAardvarkJones, bobBarrymoreFredDylan };

            var filePath = TestHelper.GetResourcePath("SinglePersonDeserializationTest.txt");
            var fileContents = PersonConverter.SerializeToFile(listToSerialize, filePath);

            Assert.AreEqual($"John Smith{Environment.NewLine}John Aardvark Jones{Environment.NewLine}Bob Barrymore Fred Dylan", fileContents);
        }
    }
}
