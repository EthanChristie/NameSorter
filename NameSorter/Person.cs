namespace NameSorter
{
    public class Person
    {
        public Person(string givenNames, string lastName)
        {
            GivenNames = givenNames;
            LastName = lastName;
        }

        public string GivenNames { get; internal set; }
        public string LastName { get; internal set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var personToCompare = obj as Person;

            return GivenNames == personToCompare.GivenNames && LastName == personToCompare.LastName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}