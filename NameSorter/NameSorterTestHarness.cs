using System.Collections.Generic;
using NUnit.Framework;

namespace NameSorter
{
    [TestFixture]
    public class NameSorterTestHarness
    {
        [Test]
        public void CanSortWhenGivenTwoNames()
        {

            var janetBentley = new Person("Janet", "Bentley");
            var georgeArcher = new Person("George", "Archer");

            var actualList = new List<Person> { janetBentley, georgeArcher };
            var expectedList = new List<Person> { georgeArcher, janetBentley };

            var nameSorter = new PersonComparer();

            actualList.Sort(nameSorter);

            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void CanSortWhenGivenThreeNames()
        {

            var janetJacksonBentley = new Person("Janet Jackson", "Bentley");
            var janetAardvarkBentley = new Person("Janet Aardvark", "Bentley");
            var georgeArcher = new Person("George", "Archer");

            var actualList = new List<Person> {  janetJacksonBentley, janetAardvarkBentley, georgeArcher };

            var expectedList = new List<Person> { georgeArcher, janetAardvarkBentley, janetJacksonBentley };

            var nameSorter = new PersonComparer();

            actualList.Sort(nameSorter);

            Assert.AreEqual(expectedList, actualList);
        }
    }
}
