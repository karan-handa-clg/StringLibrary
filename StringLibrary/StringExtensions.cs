using System;

namespace StringLibrary
{
    public static class StringExtension
    {
        // Extension method to check if string starts with an uppercase letter
        public static bool StartsWithUpperCase(this string str)
        {
            // Check if the string is null or empty
            if (string.IsNullOrEmpty(str))
                return false;

            // Check if the first character is uppercase
            return Char.IsUpper(str[0]);
        }
    }
}
