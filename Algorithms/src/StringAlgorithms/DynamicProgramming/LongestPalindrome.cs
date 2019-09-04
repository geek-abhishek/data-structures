namespace StringAlgorithms
{
    public class LongestPalindrome
    {
        public string GetLongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }

            var palindromeTable = new bool[s.Length, s.Length];

            // Since a string with only 1 character is always a palindrome
            var maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                palindromeTable[i, i] = true;
            }

            // Check for substrings of length 2
            var start = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(s[i + 1]))
                {
                    palindromeTable[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for substrings of length > 2.
            for (int k = 3; k <= s.Length; k++)
            {
                for (int i = 0; i < s.Length - k + 1; i++)
                {
                    // Get the ending index of substring
                    // from starting index 'i' and length 'k'
                    var j = i + k - 1;

                    // Checking for substring from 'i'th index to 'j'th index
                    // iff s[i+1] to s[j-1] is a palindrome 
                    if (palindromeTable[i + 1, j - 1] && s[i].Equals(s[j]))
                    {
                        palindromeTable[i, j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}
