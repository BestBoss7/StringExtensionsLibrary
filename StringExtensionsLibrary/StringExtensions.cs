using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if a string starts with an uppercase letter.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>True if the string starts with an uppercase letter; false otherwise.</returns>
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}
