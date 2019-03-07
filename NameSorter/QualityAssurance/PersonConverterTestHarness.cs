using System.Collections.Generic;
using NUnit.Framework;

namespace NameSorter
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
    }
}
