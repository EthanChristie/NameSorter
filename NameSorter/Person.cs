namespace NameSorter
{
    public class Person
    {

        public Person(string[] givenNames, string lastName)
        {
            GivenNames = givenNames;
            LastName = lastName;
        }

        public string[] GivenNames { get; internal set; }
        public string LastName { get; internal set; }
    }
}