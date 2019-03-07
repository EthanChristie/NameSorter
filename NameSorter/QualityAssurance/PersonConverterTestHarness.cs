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

            var actualList = PersonConverter.DeserializeFromFile("QualityAssurance\\Resources\\SinglePersonTest.txt");

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void CanDeserializeManyNames()
        {
            var johnSmith = new Person("John", "Smith");
            var johnAardvarkJones = new Person("John Aardvark", "Jones");
            var bobBarrymoreFredDylan = new Person("Bob Barrymore Fred", "Dylan");

            var expectedList = new List<Person> { johnSmith, johnAardvarkJones, bobBarrymoreFredDylan };

            var actualList = PersonConverter.DeserializeFromFile("QualityAssurance\\Resources\\MultiplePersonTest.txt");

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void CanSerializeOneName()
        {
            var johnSmith = new Person("John", "Smith");
            var listToSerialize = new List<Person> { johnSmith };

            var fileContents = PersonConverter.SerializeToFile(listToSerialize, "QualityAssurance\\Resources\\SinglePersonDeserializationTest.txt");

            Assert.AreEqual("John Smith", fileContents);
        }

        [Test]
        public void CanSerializeManyNames()
        {
            var johnSmith = new Person("John", "Smith");
            var johnAardvarkJones = new Person("John Aardvark", "Jones");
            var bobBarrymoreFredDylan = new Person("Bob Barrymore Fred", "Dylan");

            var listToSerialize = new List<Person> { johnSmith, johnAardvarkJones, bobBarrymoreFredDylan };

            var fileContents = PersonConverter.SerializeToFile(listToSerialize, "QualityAssurance\\Resources\\MultiplePersonDeserializationTest.txt");

            Assert.AreEqual($"John Smith{Environment.NewLine}John Aardvark Jones{Environment.NewLine}Bob Barrymore Fred Dylan", fileContents);
        }
    }
}
