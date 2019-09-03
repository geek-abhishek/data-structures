namespace StringAlgorithms
{
    using System.Collections.Generic;

    public class KMPMatcher : IStringMatcher
    {
        public List<int> GetMatchingIndexes(string text, string pattern)
        {
            if (string.IsNullOrWhiteSpace(text)
                || string.IsNullOrWhiteSpace(pattern)
                || text.Length < pattern.Length)
            {
                return new List<int>();
            }

            return GetKMPMatchingIndexes(text.ToCharArray(), pattern.ToCharArray());
        }

        private List<int> GetKMPMatchingIndexes(char[] text, char[] pattern)
        {
            var matchingIndexes = new List<int>();
            var kmpPatternIndexList = GetKMPPatternIndexList(pattern);

            var j = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(pattern[j]))
                {
                    j++;
                }
                else if (j > 0)
                {
                    j = kmpPatternIndexList[j - 1];

                    if (text[i].Equals(pattern[j]))
                    {
                        j++;
                    }
                }

                if (j.Equals(pattern.Length))
                {
                    matchingIndexes.Add(i - j);
                    j = 0;
                }
            }

            return matchingIndexes;
        }

        private int[] GetKMPPatternIndexList(char[] pattern)
        {
            var j = 0;

            var kmpPatternIndexes = new int[pattern.Length];
            kmpPatternIndexes[0] = j;

            for (var i = 1; i < pattern.Length; i++)
            {
                kmpPatternIndexes[i] = -1;

                if (pattern[i].Equals(pattern[j]))
                {
                    kmpPatternIndexes[i] = ++j;
                }
                else
                {
                    while (j > 0)
                    {
                        j = kmpPatternIndexes[j - 1];
                        if (pattern[i].Equals(pattern[j]))
                        {
                            kmpPatternIndexes[i] = ++j;
                            break;
                        }
                    }

                    if (kmpPatternIndexes[i].Equals(-1))
                    {
                        kmpPatternIndexes[i] = 0;
                    }
                }
            }

            return kmpPatternIndexes;
        }
    }
}
