using System;

namespace ReverseString
{
    public static class StringReverser
    {
        public static string ReverseString(string input)
        {
            if(input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if(input == string.Empty)
            {
                return string.Empty;
            }

            var tempString = "";

            for(int i = input.Length -1; i >= 0; i--)
            {
                tempString += input[i];
            }

            return tempString;
        }
    }
}
