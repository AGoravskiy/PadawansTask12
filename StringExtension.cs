using System;
using System.Collections.Generic;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source == "")
            {
                throw new ArgumentException();
            }

            List<char> characters = new List<char>();
            foreach (var item in source)
            {
                if (characters.Contains(item))
                {
                    return false;
                }
                else
                {
                    characters.Add(item);
                }
            }
            return true;
        }
    }
}