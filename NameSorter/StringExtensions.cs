using System.Collections.Generic;

namespace NameSorter
{
    public static class StringExtensions
    {
        public static List<int> AllIndexesOf(this string str, char value)
        {
            var indexes = new List<int>();
            for (var index = 0; index < str.Length; index++)
            {
                if (str[index] == value)
                {
                    indexes.Add(index);
                }
            }
            return indexes;
        }
    }
}
