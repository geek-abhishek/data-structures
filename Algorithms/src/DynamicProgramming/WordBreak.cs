namespace DynamicProgramming
{
    using System.Collections.Generic;
    using System.Linq;

    public class WordBreak
    {
        public bool CanBeSegmented(string s, IList<string> wordDict)
        {
            if (wordDict.Any() == false)
            {
                return false;
            }

            if (s.Length.Equals(0))
            {
                return true;
            }

            var sLength = s.Length;
            for (int i = 1; i <= sLength; i++)
            {
                if (wordDict.Contains(s.Substring(0, i))
                    && CanBeSegmented(s.Substring(i, sLength - i), wordDict))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
