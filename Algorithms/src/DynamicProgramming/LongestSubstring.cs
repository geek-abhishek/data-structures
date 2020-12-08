namespace DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var occurences = new Dictionary<char, int>();

            int i = 0;
            int length = 0;
            int maximumLength = 0;
            while (i < s.Length)
            {
                if (occurences.ContainsKey(s[i]))
                {
                    if (length >= s.Length)
                    {
                        break;
                    }

                    i = occurences[s[i]] + 1;
                    occurences.Clear();
                    length = 0;
                    continue;
                }

                occurences.Add(s[i], i);

                length++;
                maximumLength = Math.Max(maximumLength, length);
                i++;
            }

            return maximumLength;
        }
    }
}
