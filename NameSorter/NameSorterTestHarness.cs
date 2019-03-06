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

            var janetBentley = new Person(new string[] { "Janet" }, "Bentley");
            var georgeArcher = new Person(new string[] {"George"}, "Archer");

            var unsortedList = new List<Person> { janetBentley, georgeArcher };

            var sortedNames = NameSorter.Sort(unsortedList);

            Assert.AreEqual(sortedNames[0], georgeArcher);
        }
    }
}
