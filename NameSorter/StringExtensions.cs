using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public static class StringExtensions
    {
        public static List<int> AllIndexesOf(this string str, char value)
        {
            var indexes = new List<int>();
            for (int index = 0; index < str.Length; index++)
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
