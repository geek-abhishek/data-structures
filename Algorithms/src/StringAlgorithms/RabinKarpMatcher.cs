namespace StringAlgorithms
{
    using System.Collections.Generic;

    public class RabinKarpMatcher : IStringMatcher
    {
        public List<int> GetMatchingIndexes(string text, string pattern)
        {
            if (string.IsNullOrWhiteSpace(text)
                || string.IsNullOrWhiteSpace(pattern)
                || text.Length < pattern.Length)
            {
                return new List<int>();
            }

            return GetRabinKarpMatchingIndexes(text.ToCharArray(), pattern.ToCharArray());
        }

        private List<int> GetRabinKarpMatchingIndexes(char[] text, char[] pattern)
        {
            var matchingIndexes = new List<int>();

            var @base = 10; // Base of the numeral system
            var prime = 97; // Big prime number

            // Calculate the hash value of the pattern
            var patternHash = 1;
            for (var i = 0; i < pattern.Length; i++)
            {
                patternHash = GetHashModulus(patternHash * @base + pattern[i], prime);
            }

            var rollingIndex = 0;
            while (rollingIndex < text.Length - pattern.Length)
            {
                // Calculate the hash value of the first segment of the text
                var textHash = 1;
                for (var i = rollingIndex; i < (pattern.Length + rollingIndex); i++)
                {
                    textHash = GetHashModulus(textHash * @base + text[i], prime);
                }

                if (textHash.Equals(patternHash) && DoesTextSubstringMatchPattern(text, pattern, rollingIndex))
                {
                    matchingIndexes.Add(rollingIndex);
                }

                rollingIndex++;
            }

            return matchingIndexes;
        }

        private int GetHashModulus(int number1, int number2)
        {
            return (number1 % number2 + number2) % number2;
        }

        private bool DoesTextSubstringMatchPattern(char[] text, char[] pattern, int startIndex)
        {
            for (var i = 0; i < pattern.Length; i++)
            {
                if (text[startIndex].Equals(pattern[i]) == false)
                {
                    return false;
                }

                startIndex++;
            }

            return true;
        }
    }
}
